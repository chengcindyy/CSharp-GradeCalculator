# Assignment 4: Grade Calculator with Input Validation and Letter Grade Conversion

This C# console application enhances the previous assignment by introducing **robust user input validation**, **letter grade conversion**, and **modular method design** using `out` parameters and `bool` return types. It is part of the *Student Grade Tools* series developed during CSIS1175.

---

## 🧠 Key Concepts Practiced

- Using methods with `out` parameters and return values
- Input validation via `float.TryParse()`
- Logical conditions with `&&`, `||`, and nested `if-else` blocks
- Letter grade assignment based on numeric value
- Conditional display logic
- Modular design for reusable and scalable input-handling

---

## 🛠️ Features

- `GetUserInput(...)`: A generic method for validated input, accepting dynamic min/max ranges and returning both the value and a validity flag.
- `LetterGrade(...)`: Converts a numeric grade (float) to its corresponding letter based on Douglas College's grading policy.
- `DisplayTableRow(...)`: Extended to include and print the letter grade alongside weight, numeric grade, and weighted result.
- Validates all input before performing calculations
- Final result includes letter grades and pass/fail decision logic

---

## 📂 Project Structure

```
/04-ValidatedGradeCalculator
├── Program.cs                # Main application logic
├── GradeUtils.cs            # Input, validation, and letter-grade methods
├── CSharp-GradeCalculator.csproj
└── README.md
```

---

## 🔍 Sample Logic

```csharp
bool isValid = GetUserInput("Assignments", 0, 100, out float assignments);
if (isValid) {
    string gradeLetter = LetterGrade(assignments);
    DisplayTableRow("Assignments", 10, assignments, gradeLetter);
}
```

---

## 📊 Output Example

```
Assignments (10%)     85.5     B+     8.55
Midterm (30%)         70.0     B      21.0
Final Exam (40%)      92.0     A      36.8
-------------------------------------------
Weighted Average:     84.3     B+
Status: PASS
```

---

## 📘 What I Learned

- Built reusable methods using parameter passing by reference (`out`)
- Implemented nested condition validation
- Improved modularity and readability
- Gained hands-on experience with real-world grade logic


---

## 💡 How to Run

1. Clone this repository
2. Open in Visual Studio Code
3. Make sure you have .NET 6+ SDK installed
4. Navigate to this folder and run:

```bash
dotnet run
```

---

🗰️ This project is part of a learning series, demonstrating progressive C# skill development in a classroom setting.
