using System.ComponentModel;
using Newtonsoft.Json;

namespace WebLinqExercises.Services;


public class KrisInfo
{
    public List<DateTime> Datum { get; set; }
    public string Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string ImageUrl { get; set; }
    public string LinkUrl { get; set; }
    public int Displaymode { get; set; }
    public bool Emergency { get; set; }
}

public class KrisInfoService
{

    public class Test
    {
        public List<KrisInfo> ThemeList { get; set; } = new List<KrisInfo>();
    }

    public List<KrisInfo> GetAll()
    {
        var client = new HttpClient();
        string result = client.GetStringAsync("https://api.krisinformation.se/v1/themes?format=json").Result;

        var listan = JsonConvert.DeserializeObject<Test>(result);
        return listan.ThemeList;
    }
}