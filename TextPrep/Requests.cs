using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.Windows.Forms;

namespace TextPrep
{
    class Requests
    {
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
    }
}
