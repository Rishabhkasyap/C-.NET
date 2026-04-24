# 📘 C# Basics

A beginner-friendly repository covering the fundamentals of C# programming — from syntax and data types to OOP and beyond.

---

## 📚 Table of Contents

- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Topics Covered](#topics-covered)
- [Code Examples](#code-examples)
- [How to Run](#how-to-run)
- [Contributing](#contributing)
- [License](#license)

---

## 🧾 Introduction

This repository is designed for beginners who want to learn C# from scratch. Each topic is explained with clean, well-commented code examples to make learning easy and practical.

---

## ✅ Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (version 6.0 or higher recommended)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- Basic understanding of programming concepts is helpful but not required

---

## 📂 Topics Covered

### 1. 🔤 Basics
- Hello World
- Comments (single-line `//` and multi-line `/* */`)
- `Console.WriteLine()` and `Console.ReadLine()`

### 2. 📦 Data Types & Variables
- Value types: `int`, `float`, `double`, `char`, `bool`
- Reference types: `string`, `object`
- `var` keyword (type inference)
- Constants with `const`

### 3. ➕ Operators
- Arithmetic: `+`, `-`, `*`, `/`, `%`
- Comparison: `==`, `!=`, `<`, `>`, `<=`, `>=`
- Logical: `&&`, `||`, `!`
- Assignment: `=`, `+=`, `-=`, etc.

### 4. 🔀 Control Flow
- `if`, `else if`, `else`
- `switch` statement
- Ternary operator `? :`

### 5. 🔁 Loops
- `for` loop
- `while` loop
- `do-while` loop
- `foreach` loop

### 6. 🧩 Methods
- Defining and calling methods
- Parameters and return types
- Method overloading
- `void` vs return values

### 7. 🗃️ Arrays & Collections
- Single and multi-dimensional arrays
- `List<T>`
- `Dictionary<TKey, TValue>`

### 8. 🏛️ Object-Oriented Programming (OOP)
- Classes and Objects
- Constructors
- Properties (getters & setters)
- Inheritance
- Encapsulation
- Polymorphism
- Interfaces and Abstract Classes

### 9. ⚠️ Exception Handling
- `try`, `catch`, `finally`
- Common exceptions
- Custom exceptions

### 10. 🔢 Number Conversions
- Binary to Decimal
- Decimal to Binary
- Type casting

---

## 💻 Code Examples

### Hello World
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

### Variables & Data Types
```csharp
int age = 20;
double price = 99.99;
string name = "Alice";
bool isStudent = true;
char grade = 'A';
```

### If-Else
```csharp
int num = 10;
if (num > 0)
    Console.WriteLine("Positive");
else if (num < 0)
    Console.WriteLine("Negative");
else
    Console.WriteLine("Zero");
```

### For Loop
```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

### Method Example
```csharp
static int Add(int a, int b)
{
    return a + b;
}
```

### Class & Object
```csharp
class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Brand} - {Year}");
    }
}

// Usage
Car myCar = new Car();
myCar.Brand = "Toyota";
myCar.Year = 2022;
myCar.DisplayInfo();
```

### Binary to Decimal Conversion
```csharp
public void NumberToBinary()
{
    int num = 1001;   // Binary input
    int b, s = 0, e = 0;

    while (num != 0)
    {
        b = num % 10;
        s = s + b * (int)Math.Pow(2, e);  // 2^position
        num = num / 10;
        e++;
    }

    Console.WriteLine("Decimal: " + s);   // Output: 9
}
```

---

## ▶️ How to Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/csharp-basics.git
   cd csharp-basics
   ```

2. **Run with .NET CLI**
   ```bash
   dotnet run
   ```

3. **Or open in Visual Studio** and press `F5` to run.

---

## 🤝 Contributing

Contributions are welcome! If you'd like to add examples or fix something:

1. Fork the repository
2. Create a new branch (`git checkout -b feature/your-topic`)
3. Commit your changes (`git commit -m "Add: topic name"`)
4. Push and open a Pull Request

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

> Made with ❤️ for C# beginners
