using System.Text;
using System.Text.Json;
using System.Net;
using Flurl.Http;

namespace TestTaskV2
{
    internal interface IDataSendToServer
    {
        public static void DataSender(List<int> SendingData)
        {
            string url = "";
            if (File.Exists("AppSettings.txt"))
            {
                string[] Fsettings = File.ReadAllLines("AppSettings.txt");
                foreach (string line in Fsettings)
                {
                    if (line.Contains("link:"))
                    {
                        url = line.Substring(line.IndexOf(":") + 1, line.Length - line.IndexOf(":") - 1);
                        Console.WriteLine(url);
                        break;
                    }
                }
                if (url == "")
                {
                    Console.WriteLine("Файл конфигурации не содержит ссылки");
                }
            }
            else
            {
                Console.WriteLine("Отсутствует файл кофигурации");
            }

            var json = JsonSerializer.Serialize(SendingData);
            using (var httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Headers.Add("Accept", "application/json");
                request.Content = new StringContent(json);
                var response = httpClient.SendAsync(request).Result;
                Console.WriteLine(response);
            }

        }
    }
}
