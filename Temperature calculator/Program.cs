using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=================================================");
        Console.WriteLine("       TEMPERATURE CONVERTER & WEATHER APP       ");
        Console.WriteLine("=================================================\n");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1] Convert Temperature");
            Console.WriteLine("[2] Get Live Weather Data");
            Console.WriteLine("[3] Exit");
            Console.ResetColor();

            Console.Write("\nEnter your choice (1-3): ");
            string choice = Console.ReadLine();

            if (!int.TryParse(choice, out int option) || option < 1 || option > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid choice! Please enter a number between 1-3.\n");
                Console.ResetColor();
                continue;
            }

            if (option == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThank you for using the application. Goodbye!\n");
                Console.ResetColor();
                break;
            }

            if (option == 1)
            {
                TemperatureConverter.ConvertTemperature();
            }
            else if (option == 2)
            {
                Console.Write("\nEnter city name: ");
                string city = Console.ReadLine();

                Console.WriteLine("\nFetching weather details... Please wait.\n");

                WeatherData weather = WeatherService.GetWeather(city);
                if (weather != null)
                {
                    weather.DisplayWeather();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError retrieving weather data. Please check the city name.\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
