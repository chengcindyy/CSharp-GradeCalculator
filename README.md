# CSharp-GradeCalculator

A collection of C# console and GUI applications that demonstrate fundamental programming concepts through the implementation of a student GPA (Grade Point Average) calculator. Each subproject showcases a specific aspect of C# programming, from input validation to file handling and GUI design. These projects were developed as a progressive series of assignments for the CSIS1175 course.

---

## 🗂️ Projects Overview

### 01-StudentGPA-InputValidation
**Description:**
Basic console app that collects and validates GPA-related inputs (e.g., midterms, quizzes, final exam scores) from the user.

- Demonstrates: Console I/O, type conversion, input validation.
- Output: Displays calculated GPA and verifies exam average ≥ 50%.

---

### 02-StudentGPA-ArraysAndLoop
**Description:**
Enhances the previous logic using arrays and loops to manage multiple students' scores.

- Demonstrates: Arrays, `for` and `foreach` loops, GPA calculation using weighted averages.
- Output: Weighted total and exam average per student.

---

### 03-StudentGPA-MenuDrivenCalculator
**Description:**
Introduces a menu-based interface that allows users to choose actions like input scores, calculate GPA, or display results.

- Demonstrates: `switch` statements, looped menus, structured program design.
- Output: Flexible user interaction with GPA calculation workflow.

---

### 04-StudentGPA-ClassBasedCalculator
**Description:**
Refactors the menu-driven program into an object-oriented version using a custom `Student` class.

- Demonstrates: Class creation, constructors, encapsulation, method organization.
- Output: More maintainable and modular code structure.

---

### 05-StudentGPA-FileProcessing
**Description:**
Reads student data from a text file, calculates GPA, and writes results to a binary file using a `Student` class.

- Demonstrates: File I/O with `StreamReader` and `BinaryWriter`, parsing input, object encapsulation.
- Output: Console log output and binary file `studentsGPA.dat`.

---

### 06-StudentGPA-GUIFinalCalculator
**Description:**
Windows Forms application that calculates GPA based on user-entered weights and grades.

- Demonstrates: GUI layout, WinForms controls, event handling (`Form_Load`, `Button_Click`), and weighted average logic.
- Output: User-friendly GPA display interface with real-time result calculation.

---

## 🧰 Tech Stack
- **Language:** C#
- **Frameworks:** 
  - .NET SDK 8 (Console Projects)
  - .NET Framework 4.7.2 (Windows Forms GUI)
- **Tools:** Visual Studio / VS Code

---

## 📂 Folder Structure

```
CSharp-GradeCalculator
│
├── 01-StudentGPA-InputValidation
├── 02-StudentGPA-ArraysAndLoop
├── 03-StudentGPA-MenuDrivenCalculator
├── 04-StudentGPA-ClassBasedCalculator
├── 05-StudentGPA-FileProcessing
├── 06-StudentGPA-GUIFinalCalculator
└── README.md
```


---

## 🧑‍💻 Author

Cindy Cheng  
GitHub: [@CindyCheng](https://github.com/)

---

## 📎 Notes

- Each project is standalone and can be executed independently.
- `.csproj` files are included in each folder for simplified `dotnet run` execution.
- GUI and console output screenshots included for better demonstration.
