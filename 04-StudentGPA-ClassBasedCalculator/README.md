# Block Letter Drawing Tool (Assignment 5)

A C# console application that prompts users to enter a string composed of specific English letters and then renders each letter in a block-shaped pattern using asterisks.

## 🧩 Features

- ✅ **Input validation with retry loop**  
  Ensures all characters in user input belong to the allowed set `EHLNTXZ`.

- 🔢 **Shape dimension enforcement**  
  Accepts only odd numbers ≥ 3 for letter dimensions.

- 🔄 **Switch-based letter rendering**  
  Dynamically calls drawing methods (e.g., `DrawE`, `DrawX`, etc.) based on user input.

- 🖨️ **ASCII-art style output**  
  Displays each letter using asterisk (`*`) characters in console output.

---

## 📦 What's Implemented

- `GetUserString()`  
  Accepts a valid input string (letters must be among `EHLNTXZ`).

- `GetUserInput(prompt)`  
  Prompts user for an odd integer ≥ 3 and keeps retrying until valid.

- `DrawE(int dimension)`  
- `DrawH(int dimension)`  
- `DrawL(int dimension)`  
- `DrawN(int dimension)`  
- `DrawT(int dimension)`  
- `DrawX(int dimension)`  
- `DrawZ(int dimension)`  
  Each function uses nested loops to render the appropriate letter pattern.

## 🛠 Technologies Used

- Language: `C#`
- Framework: `.NET SDK 8`
- IDE: `VS Code`
- Runtime: `Console App`

---

## 🚀 How to Run

```bash
# Clone this repository and navigate to this subfolder
cd CSharp-GradeCalculator/05-BlockLetterDrawer
```

# Build and run using .NET CLI
```bash
dotnet run
```