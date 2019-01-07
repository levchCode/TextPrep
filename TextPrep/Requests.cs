using System;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;


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
        private static string dictURL = "https://dictionary.yandex.net/api/v1/dicservice.json/lookup?key=dict.1.1.20190101T101257Z.92f00ce56ddec9ca.1d814ae8913506a5179b4c3f582bae82082f6b6a&lang=ru-en&text=";

        public static string sendYandex(String w)
        {
            try
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                var resp = client.GetAsync(dictURL + w).Result;

                dynamic result = serializer.Deserialize<dynamic>(resp.Content.ReadAsStringAsync().Result);

                return result["def"][0]["tr"][0]["text"];
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка. Проверьте список слов!");
                return String.Empty;
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
