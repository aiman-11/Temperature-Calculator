using System;

class TemperatureConverter
{
    public static void ConvertTemperature()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n[1] Celsius to Fahrenheit");
        Console.WriteLine("[2] Fahrenheit to Celsius");
        Console.WriteLine("[3] Celsius to Kelvin");
        Console.WriteLine("[4] Kelvin to Celsius");
        Console.WriteLine("[5] Fahrenheit to Kelvin");
        Console.WriteLine("[6] Kelvin to Fahrenheit");
        Console.ResetColor();

        Console.Write("\nEnter conversion option (1-6): ");
        if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 6)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid choice! Please enter a number between 1-6.\n");
            Console.ResetColor();
            return;
        }

        Console.Write("\nEnter temperature value: ");
        if (!double.TryParse(Console.ReadLine(), out double temperature))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid input! Please enter a numeric value.\n");
            Console.ResetColor();
            return;
        }

        double result = 0;
        string unit = "";

        switch (option)
        {
            case 1:
                result = (temperature * 9 / 5) + 32;
                unit = "°F";
                break;
            case 2:
                result = (temperature - 32) * 5 / 9;
                unit = "°C";
                break;
            case 3:
                result = temperature + 273.15;
                unit = "K";
                break;
            case 4:
                result = temperature - 273.15;
                unit = "°C";
                break;
            case 5:
                result = (temperature - 32) * 5 / 9 + 273.15;
                unit = "K";
                break;
            case 6:
                result = (temperature - 273.15) * 9 / 5 + 32;
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
