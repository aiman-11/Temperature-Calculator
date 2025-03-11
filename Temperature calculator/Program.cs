using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("=======================================");
        Console.WriteLine("       TEMPERATURE CONVERTER       ");
        Console.WriteLine("=======================================\n");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[1] Celsius to Fahrenheit");
            Console.WriteLine("[2] Fahrenheit to Celsius");
            Console.WriteLine("[3] Celsius to Kelvin");
            Console.WriteLine("[4] Kelvin to Celsius");
            Console.WriteLine("[5] Fahrenheit to Kelvin");
            Console.WriteLine("[6] Kelvin to Fahrenheit");
            Console.WriteLine("[7] Exit");
            Console.ResetColor();

            Console.Write("\nEnter your choice (1-7): ");
            string choice = Console.ReadLine();

            // Validate choice before proceeding
            if (!int.TryParse(choice, out int option) || option < 1 || option > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice! Please select a number between 1-7.\n");
                Console.ResetColor();
                continue;
            }

            if (option == 7)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nThank you for using the Temperature Converter. Goodbye! 🌟\n");
                Console.ResetColor();
                break;
            }

            Console.Write("\nEnter temperature value: ");
            if (!double.TryParse(Console.ReadLine(), out double temperature))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter a numeric value.\n");
                Console.ResetColor();
                continue;
            }

            double result = 0;
            string unit = "";

            switch (option)
            {
                case 1:
                    result = CelsiusToFahrenheit(temperature);
                    unit = "°F";
                    break;
                case 2:
                    result = FahrenheitToCelsius(temperature);
                    unit = "°C";
                    break;
                case 3:
                    result = CelsiusToKelvin(temperature);
                    unit = "K";
                    break;
                case 4:
                    result = KelvinToCelsius(temperature);
                    unit = "°C";
                    break;
                case 5:
                    result = FahrenheitToKelvin(temperature);
                    unit = "K";
                    break;
                case 6:
                    result = KelvinToFahrenheit(temperature);
                    unit = "°F";
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=====================================");
            Console.WriteLine($" Converted Temperature: {result:F2} {unit} ");
            Console.WriteLine("=====================================\n");
            Console.ResetColor();
        }
    }

    static double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
    static double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
    static double CelsiusToKelvin(double c) => c + 273.15;
    static double KelvinToCelsius(double k) => k - 273.15;
    static double FahrenheitToKelvin(double f) => (f - 32) * 5 / 9 + 273.15;
    static double KelvinToFahrenheit(double k) => (k - 273.15) * 9 / 5 + 32;
}
