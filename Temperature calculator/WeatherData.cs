using System;

class WeatherData
{
    public WeatherMain main { get; set; }
    public Wind wind { get; set; }
    public WeatherDescription[] weather { get; set; }
    public string name { get; set; }

    public void DisplayWeather()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n==================== Weather Details ====================");
        Console.WriteLine($" City: {name}");
        Console.WriteLine($" Temperature: {main.temp}°C");
        Console.WriteLine($" Feels Like: {main.feels_like}°C");
        Console.WriteLine($" Humidity: {main.humidity}%");
        Console.WriteLine($" Wind Speed: {wind.speed} m/s");
        Console.WriteLine($" Weather: {weather[0].description}");
        Console.WriteLine("=========================================================\n");
        Console.ResetColor();
    }
}

class WeatherMain
{
    public double temp { get; set; }
    public double feels_like { get; set; }
    public int humidity { get; set; }
}

class Wind
{
    public double speed { get; set; }
}

class WeatherDescription
{
    public string description { get; set; }
}
