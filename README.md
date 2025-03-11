# **Temperature Calculator & Live Weather Data**

![GitHub issues](https://img.shields.io/github/issues/aiman-11/Temperature-Calculator)
![GitHub forks](https://img.shields.io/github/forks/aiman-11/Temperature-Calculator?style=social)
![GitHub stars](https://img.shields.io/github/stars/aiman-11/Temperature-Calculator?style=social)

## **Table of Contents**
- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Installation & Setup](#installation--setup)
- [Usage](#usage)
- [Example Interaction](#example-interaction)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

---

## **Overview**

The **Temperature Calculator & Live Weather Data** application is a **C# console-based tool** that allows users to:

1. **Convert temperatures** between different units.
2. **Fetch real-time weather details** for any city using an external weather API.

It provides an **interactive menu**, error handling, and formatted output for a better user experience.

---

## **Features**

✅ Convert **Celsius, Fahrenheit, and Kelvin**  
✅ Fetch **real-time weather data** for any city  
✅ **Formatted output** with an easy-to-read UI  
✅ **Error handling** for invalid inputs  
✅ **User-friendly interactive menu**  

---

## **Technologies Used**

- **C#** (.NET Console Application)
- **.NET Core SDK**
- **OpenWeather API** (for live weather data)

---

## **Installation & Setup**

### **1. Clone the Repository:**
```sh
git clone https://github.com/aiman-11/Temperature-Calculator.git
```

### **2. Navigate to the Project Directory:**
```sh
cd Temperature-Calculator
```

### **3. Build and Run the Application:**
- **Using Visual Studio:**
  - Open the project in **Visual Studio**
  - Press **F5** to run
- **Using .NET CLI:**
```sh
dotnet build
dotnet run
```

---

## **Usage**

1. **Run the application.**
2. **Select an option from the menu:**
   - **[1] Convert Temperature**
   - **[2] Get Live Weather Data**
   - **[3] Exit**
3. **For temperature conversion:**
   - Choose a conversion type.
   - Enter the temperature value.
   - View the converted temperature.
4. **For live weather data:**
   - Enter the name of the city.
   - View the temperature, humidity, wind speed, and weather conditions.
5. **Repeat or exit the program.**

---

## **Example Interaction**

### **Temperature Conversion**
```sh
=======================================
      TEMPERATURE CALCULATOR      
=======================================

[1] Convert Temperature
[2] Get Live Weather Data
[3] Exit

Enter your choice (1-3): 1
Enter temperature value: 100

[1] Celsius to Fahrenheit
[2] Fahrenheit to Celsius
[3] Celsius to Kelvin
[4] Kelvin to Celsius
[5] Fahrenheit to Kelvin
[6] Kelvin to Fahrenheit

Enter conversion option (1-6): 1

=====================================
 Converted Temperature: 212.00 °F
=====================================
```

### **Live Weather Data**
```sh
=======================================
      LIVE WEATHER INFORMATION      
=======================================

Enter city name: London

==================== Weather Details ====================
 City: London
 Temperature: 12.35°C
 Feels Like: 10.8°C
 Humidity: 81%
 Wind Speed: 3.45 m/s
 Weather: light rain
=========================================================
```

---

## **Project Structure**
```
Temperature-Calculator/
│-- TemperatureCalculator/
│   │-- obj/
│   │-- bin/
│   │-- Properties/
│   │-- Program.cs
│   │-- TemperatureConverter.cs
│   │-- WeatherService.cs
│-- .github/
│   │-- ISSUE_TEMPLATE/
│   │-- CONTRIBUTING.md
│   │-- CODE_OF_CONDUCT.md
│-- TemperatureCalculator.sln
│-- README.md
│-- LICENSE
```

- **`Program.cs`** → Handles menu navigation and user interaction
- **`TemperatureConverter.cs`** → Contains functions for temperature conversion
- **`WeatherService.cs`** → Fetches live weather data from OpenWeather API
- **`.github/`** → Contains GitHub-related files (issues, contribution guidelines, etc.)
- **`obj/` & `bin/`** → Compiled binaries and build artifacts
- **`TemperatureCalculator.sln`** → Solution file for the .NET project

---

## **Contributing**

We welcome contributions! If you'd like to contribute:

1. **Fork the repository**
2. **Create a new branch** (`feature-branch`)
3. **Commit your changes**
4. **Push to your branch**
5. **Open a Pull Request**

For detailed contribution guidelines, check the [`CONTRIBUTING.md`](.github/CONTRIBUTING.md) file.

---

## **License**

This project is open-source and available under the [`MIT LICENSE`](LICENSE).

---

## **Contact**

For any questions or suggestions, feel free to reach out!

- **GitHub:** [aiman-11](https://github.com/aiman-11)


