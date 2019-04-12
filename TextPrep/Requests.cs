using System;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Diagnostics;

namespace TextPrep
{
    class Requests
    {
        private static string[] Scopes = { DriveService.Scope.Drive,
                           DriveService.Scope.DriveAppdata,
                           DriveService.Scope.DriveFile,
                           DriveService.Scope.DriveMetadataReadonly,
                           DriveService.Scope.DriveReadonly,
                           DriveService.Scope.DriveScripts };

        private static readonly HttpClient client = new HttpClient();
        private static string dictURL = "https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20181117T095158Z.4b7a56f1d15a185f.5f6f8ec4625da21142f2a21ca85476bf76526cb9&text={0}&lang={1}";

        public static string sendYandex(string w, string dir)
        {

            try
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                
                
                var resp = client.GetAsync(string.Format(dictURL, w, dir)).Result;

                dynamic result = serializer.Deserialize<dynamic>(resp.Content.ReadAsStringAsync().Result);

                return result["text"][0];
            }
            catch (Exception)
            {
                MessageBox.Show("Не могу соединиться с сервисами Яндекс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static string googleupload(string path, string TextName, string folderName)
        {
            UserCredential credential;

                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    // The file token.json stores the user's access and refresh tokens, and is created
                    // automatically when the authorization flow completes for the first time.
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "leVch",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                // Create Drive API service.
                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "text prep",
                });

                var folderMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = folderName,
                    MimeType = "application/vnd.google-apps.folder"
                };

                var r = service.Files.Create(folderMetadata);
                r.Fields = "id";
                var file = r.Execute();

                var folderid = file.Id;

                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = TextName,
                    MimeType = "application/vnd.google-apps.document"
                };

                FilesResource.CreateMediaUpload request;
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    request = service.Files.Create(fileMetadata, stream, "text/plain");
                    request.Fields = "id";
                    request.Upload();
                }

                var fileid = file.Id;


            var updateRequest = service.Files.Update(new Google.Apis.Drive.v3.Data.File(), file.Id);
            updateRequest.RemoveParents = folderid;
            updateRequest.AddParents = folderid;
            file = updateRequest.Execute();

            return "OK";
        }
    }
}
