# Cashier System 🛒

A lightweight C# console application that simulates an automated retail checkout register. Built as a hands-on project to practice fundamental C# programming concepts learned in Sololearn's *Introduction to C#* course.

## 🚀 Features

- **Customer Membership Tracking:** Automatically determines customer status (`VIP` vs `Standard`) using a ternary operator based on loyalty points.
- **Item Scanning Simulation:** Uses a `for` loop to simulate barcode scanning of items.
- **Tiered Discount Logic:** Applies progressive subtotal discounts:
  - **20% off** for subtotals over `$3,000`
  - **10% off** for subtotals over `$2,000`
- **VIP Bonus Stacking:** Adds an extra **5% discount** on top of existing base savings if the customer is a VIP.
- **Custom Method Calculation:** Calculates total savings and displays formatted bill details via a helper method.

## 🛠️ Concepts Covered

- **Variables & Data Types:** `string`, `int`, `double`
- **Type Conversion:** `Convert.ToDouble()`, `Convert.ToInt32()`
- **Ternary Operator:** `condition ? trueExpression : falseExpression`
- **Control Flow:** `for` loops, `if / else if / else` statements
- **Methods:** Static local methods with parameter passing

## 🖥️ How to Run

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.
- Visual Studio Code (or any preferred text editor).

### Execution Steps
1. Clone or download this repository.
2. Open your terminal in VS Code and navigate to the project directory:
   ```bash
   cd CashierSystem
