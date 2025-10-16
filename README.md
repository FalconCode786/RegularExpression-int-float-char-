Perfect 👍 — you now want your **README.md** to describe a C# Windows Forms project that validates **`int`**, **`float`**, and **`char`** inputs using **Regular Expressions**.

Here’s a complete and polished **GitHub README** for that:

---

# 🧮 Input Type Validator (int | float | char) — C# Windows Forms App

A simple **Windows Forms Application (C#)** built in **Visual Studio 2022**, designed to validate user input for **integers**, **floating-point numbers**, and **characters** using **Regular Expressions (Regex)**.

---

## 🚀 Features

* ✅ Validates **integer**, **float**, and **character** inputs
* 💬 Displays valid inputs in the output box
* ⚠️ Shows message boxes for invalid entries
* 🪟 Clean, beginner-friendly GUI using **Windows Forms**
* 🧠 Uses multiple regular expressions for type checking

---

## 🧠 Regular Expressions Used

| Data Type     | Regex Pattern                              | Description                                                                 |
| ------------- | ------------------------------------------ | --------------------------------------------------------------------------- |
| **Integer**   | `^[+-]?[0-9]+$`                            | Matches integers (e.g., `12`, `-45`, `+78`)                                 |
| **Float**     | `^[+-]?[0-9]*[.][0-9]+([eE][+-]?[0-9]+)?$` | Matches floating-point and scientific numbers (e.g., `3.14`, `1.2e-3`)      |
| **Character** | `^'[a-zA-Z0-9]'$`                          | Matches a single character inside single quotes (e.g., `'a'`, `'Z'`, `'5'`) |

---

## 🧪 Example Input

```
123 45.67 'a' -10 +5 1.2e-3 'A' abc .5 'ab'
```

### ✅ Expected Output

| Input    | Type  | Result    |
| -------- | ----- | --------- |
| `123`    | int   | Valid     |
| `45.67`  | float | Valid     |
| `'a'`    | char  | Valid     |
| `-10`    | int   | Valid     |
| `+5`     | int   | Valid     |
| `1.2e-3` | float | Valid     |
| `'A'`    | char  | Valid     |
| `abc`    | —     | ❌ Invalid |
| `.5`     | —     | ❌ Invalid |
| `'ab'`   | —     | ❌ Invalid |

---

## 🖥️ How It Works

1. The user enters space-separated inputs in **TextBox1**.
2. When the **Validate** button is clicked:

   * Each token is checked against three regexes (int, float, char).
   * The matched type is added to **TextBox2**.
   * Invalid values trigger a message box.

---

## 🧩 Technologies Used

* **C# (Windows Forms)**
* **.NET Framework / .NET 6+**
* **Visual Studio 2022**
* **System.Text.RegularExpressions** library

---

## ⚙️ Example Code Snippet

```csharp
Regex intRegex = new Regex(@"^[+-]?[0-9]+$");
Regex floatRegex = new Regex(@"^[+-]?[0-9]*[.][0-9]+([eE][+-]?[0-9]+)?$");
Regex charRegex = new Regex(@"^'[a-zA-Z0-9]'$");

foreach (string word in words)
{
    if (intRegex.IsMatch(word))
        textBox2.AppendText(word + " → Integer\n");
    else if (floatRegex.IsMatch(word))
        textBox2.AppendText(word + " → Float\n");
    else if (charRegex.IsMatch(word))
        textBox2.AppendText(word + " → Char\n");
    else
        MessageBox.Show("Invalid: " + word);
}
```

---

## 📂 Project Structure

```
📦 WinFormsApp1
 ┣ 📜 Form1.cs
 ┣ 📜 Form1.Designer.cs
 ┣ 📜 Program.cs
 ┗ 📜 README.md
```

---

## 🧑‍💻 Author

**Muhammad Haseeb**


---

## 💡 Future Enhancements

* Add support for **string literals**
* Highlight invalid inputs instead of showing popups
* Include **data type summary counts** (e.g., total ints, floats, chars)

---

Would you like me to also include the **full C# code** for the form (the version that validates all three types)? I can make it ready to run in Visual Studio 2022.
