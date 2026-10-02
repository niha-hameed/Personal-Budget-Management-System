<div align="center">

# Personal Budget Management System
### C# · Windows Forms · .NET Framework 4.7.2

A desktop project for recording expenses, organizing category budgets, and visualizing spending.

</div>

## Overview

Developed by **Nihal Hameed Alharbi**, this application combines expense entry, CSV file storage, date-based transaction searches, and category charts in a Windows Forms interface.

## Features

- Record an expense with its date, amount, and category.
- Choose Food, Transport, Shopping, or enter a custom category through Other.
- Validate positive amounts, required categories, and future transaction dates.
- Search transactions within a selected date range.
- Display category totals using a pie chart.
- Adjust category budgets with sliders and display configured threshold alerts.
- Save transaction records and category budgets in CSV files.

## Technologies

| Component | Technology |
| --- | --- |
| Language | C# |
| Desktop interface | Windows Forms |
| Target framework | .NET Framework 4.7.2 |
| Charts | System.Windows.Forms.DataVisualization |
| Data processing | LINQ |
| Storage | Local CSV files |

## Getting started

### Requirements

- Windows.
- Visual Studio with the **.NET desktop development** workload.
- The **.NET Framework 4.7.2 targeting pack**.

### Open and run

1. Clone this repository or download it using **Code → Download ZIP**.
2. Open `WindowsFormsApp1.sln` in Visual Studio.
3. Confirm that `WindowsFormsApp1` is the startup project.
4. Select **Build → Build Solution**.
5. Press **F5** to run with debugging, or **Ctrl+F5** to run without debugging.

These instructions are based on the solution and project files. The application has not been build-tested or run as part of preparing this README.

### Basic workflow

1. Enter a transaction date, category, and positive amount, then add the transaction.
2. Open the budget window, adjust the category sliders, and save.
3. Open the transaction view, choose a date range, and search to populate the table and category chart.

## Project structure

| File | Responsibility |
| --- | --- |
| `Program.cs` | Application entry point |
| `Form1.cs` | Transaction entry and validation |
| `TransactionManager.cs` | Transaction CSV storage and loading |
| `Budget.cs` | Budget controls, threshold messages, and saving |
| `View.cs` | Date filtering, transaction table, and pie chart |
| `CsvHelper.cs` | Additional CSV helper code |
| `WindowsFormsApp1.csproj` | Framework target and build configuration |

## Data files

- `transactions.csv`: Date, Amount, Category.
- `budgets.csv`: Category, Amount.

Paths are relative to the application's working directory. Transaction data is appended; saving budgets replaces the budget file.

## Current limitations

- Budget alerts use configured slider thresholds rather than comparing actual expenses with saved budgets.
- The transaction reader interprets stored dates as Hijri dates, while the writer formats the selected date directly. Date round-tripping should be checked before relying on search results.
- CSV handling uses simple comma-separated fields; quoted fields and categories containing commas are not supported.

## Author and repository history

**Nihal Hameed Alharbi** — [GitHub](https://github.com/niha-hameed)

This portfolio copy is forked from [ghazalalsharif/Personal-Budget-Management-System](https://github.com/ghazalalsharif/Personal-Budget-Management-System), preserving the original repository history.
