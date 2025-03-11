# Temperature Converter

## Overview
The **Temperature Converter** is a simple console-based application written in C#. It allows users to convert temperatures between different units, including Celsius, Fahrenheit, and Kelvin. The program provides an interactive menu where users can select the type of conversion they need and input the temperature value for conversion.

## Features
- Convert **Celsius to Fahrenheit**
- Convert **Fahrenheit to Celsius**
- Convert **Celsius to Kelvin**
- Convert **Kelvin to Celsius**
- Convert **Fahrenheit to Kelvin**
- Convert **Kelvin to Fahrenheit**
- User-friendly menu interface
- Input validation to ensure correct numerical entries
- Color-coded outputs for better readability

## Installation
To run this application, you need to have **.NET SDK** installed on your system.

### Steps to Install and Run:
1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/temperature-converter.git
   ```
2. Navigate to the project directory:
   ```sh
   cd temperature-converter
   ```
3. Compile the program:
   ```sh
   dotnet build
   ```
4. Run the program:
   ```sh
   dotnet run
   ```

## Usage
1. The application displays a menu with conversion options.
2. Enter the corresponding number for your desired conversion.
3. Input the temperature value when prompted.
4. The converted temperature will be displayed.
5. To exit, select option `7`.

## Example Output
```
=======================================
       TEMPERATURE CONVERTER       
=======================================

[1] Celsius to Fahrenheit
[2] Fahrenheit to Celsius
[3] Celsius to Kelvin
[4] Kelvin to Celsius
[5] Fahrenheit to Kelvin
[6] Kelvin to Fahrenheit
[7] Exit

Enter your choice (1-7): 1

Enter temperature value: 25

=====================================
 Converted Temperature: 77.00 °F 
=====================================
```

## File Structure
```
temperature-converter/
│── Program.cs           # Main application logic
│── README.md            # Documentation
│── .gitignore           # Ignoring unnecessary files
│── LICENSE              # MIT License file
│── SECURITY.md          # Security policy and vulnerability reporting
│── CODE_OF_CONDUCT.md   # Community guidelines for behavior
│── CONTRIBUTING.md      # Guidelines for contributing to the project
│── ISSUE_TEMPLATE.md    # Template for reporting issues
│── PULL_REQUEST_TEMPLATE.md # Template for submitting pull requests
│── CHANGELOG.md         # Log of changes and updates
```

## Contributing
We welcome contributions! Please read our [CONTRIBUTING.md](CONTRIBUTING.md) to get started.

## Security Policy
For reporting vulnerabilities, please refer to our [SECURITY.md](SECURITY.md).

## License
This project is licensed under the **MIT License** – see the [LICENSE](LICENSE) file for details.

---

Happy Coding! 🚀

