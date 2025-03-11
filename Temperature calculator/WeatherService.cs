using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class WeatherService
{
    private static readonly string apiKey = "1a5fc18905a5e560cd399284a1b505c6";
    private static readonly HttpClient client = new HttpClient();

    public static WeatherData GetWeather(string city)
    {
        try
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}";
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (!response.IsSuccessStatusCode)
                return null;

            string jsonResponse = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<WeatherData>(jsonResponse);
        }
        catch
        {
            return null;
        }
    }
}
