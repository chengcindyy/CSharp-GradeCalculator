# 02 - Weighted Average With Methods

This C# console application calculates the weighted average of a student's performance, using modularized methods to enhance code clarity and maintainability. It is a refactored version of the previous assignment, transforming the original procedural structure into a method-based design.

## 📌 Features

- Method refactoring of the weighted average calculator
- Uses:
  - User-defined methods with parameters
  - Predefined methods from `Console` and `Math` classes
  - `Parse()` method for string-to-float conversion
  - Method overloading for displaying formatted output

## 🛠 Implemented Methods

- `GetUserInput(string prompt)`: Prompts the user and returns a numeric input.
- `DisplayBanner()`: Displays the application header.
- `DisplayTableRow(string label, string value, string percentage)`: Displays a row of text values.
- `DisplayTableRow(string label, float grade, float weight)`: Overloaded version for numeric values.
- `WeightedGrade(float grade, float weight)`: Calculates the weighted contribution of a grade.

## ✅ Objectives

- Apply method definitions and refactor code structure
- Learn method overloading and proper parameter use
- Maintain original program behavior with improved readability

## 🧪 Output Example

The program mimics the behavior of the original weighted average calculator but improves precision using `Math.Ceiling()` and `Math.Floor()` functions where required. Sample outputs match the executable provided in the assignment.

## 📁 Project Structure

02-WeightedAverageWithMethods/
├── Program.cs # Main program logic using modular methods
├── 02-WeightedAverageWithMethods.csproj
├── README.md


## 🧑‍🎓 Author

Cindy Cheng  
CSIS 1175 – Assignment 3  
Douglas College

---

