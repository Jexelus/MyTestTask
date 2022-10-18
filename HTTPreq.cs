using System.Text;
using System.Net;
using System.Text.Json;

class Postreq
{
    public static void PostReqGen(List<int> package)
    {
        string httplink = "";
        using (StreamReader Sreader = new StreamReader("link.txt"))
        {
            httplink = Sreader.ReadLine();
            httplink = httplink.Remove(0, 6);
        }
        string url = httplink;
        var json = JsonSerializer.Serialize(package);
        var wb = new WebClient();
        Console.WriteLine(url);
        var response = wb.UploadString(url, "POST", json);
    }
}
