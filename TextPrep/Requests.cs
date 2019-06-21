using System;
using System.Xml;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Collections.Generic;
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
        private static string dictURL = "https://translate.yandex.net/api/v1.5/tr.json/translate?key={2}&text={0}&lang={1}";
        private static string pairsURL = "https://translate.yandex.net/api/v1.5/tr.json/getLangs?ui=en&key={0}";

        public static string sendYandex(string w, bool dir)
        {
            //dir sets direciton of translation
            //true if you want learn_lang->main_lang or false other way around
            string key = "";
            string mainLang = "";
            string learnLang = "";

            using (XmlReader reader = XmlReader.Create(@"settings.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "yandexKey":
                                key = reader.ReadString();
                                break;
                            case "mainLang":
                                mainLang = reader.ReadString();
                                break;
                            case "learnLang":
                                learnLang = reader.ReadString();
                                break;
                        }
                    }
                }
            }

            string pair = learnLang + "-" + mainLang;

            try
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                var resp = client.GetAsync(string.Format(dictURL, w, pair, key)).Result;

                dynamic result = serializer.Deserialize<dynamic>(resp.Content.ReadAsStringAsync().Result);

                return result["text"][0];
            }
            catch (Exception)
            {
                MessageBox.Show("Can't connect to Yandex.Translate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static dynamic get_pairs()
        {
            string key = "";
            using (XmlReader reader = XmlReader.Create(@"settings.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "yandexKey":
                                key = reader.ReadString();
                                break;
                        }
                    }
                }
            }

            try
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();

                var resp = client.GetAsync(string.Format(pairsURL, key)).Result;

                dynamic result = serializer.Deserialize<dynamic>(resp.Content.ReadAsStringAsync().Result);

                return result["dirs"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
