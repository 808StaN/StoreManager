# StoreManager

Desktop application for managing an online clothing and footwear store.

## Overview

`StoreManager` is a WinForms CRUD system built in C# for daily store operations:
- product catalog management,
- categories and brands,
- warehouse variants and stock,
- users,
- orders,
- returns.

The app uses an MDI layout (left navigation + module windows in the workspace area) and connects to SQL Server / Azure SQL.

## Tech Stack

- **Language:** C# 12
- **Framework:** .NET 8 (`net8.0-windows`)
- **UI:** Windows Forms (MDI)
- **Data Access:** ADO.NET (`System.Data.SqlClient`)
- **Database:** SQL Server / Azure SQL
- **Architecture:** Models + Repository-based DataAccess + Forms

## Main Features

- **Database login window** (credentials entered at runtime)
- **Products module** (`Nazwa`, `Opis`, `CenaBazowa`, category, brand)
- **Categories module** (parent-child category structure)
- **Brands module**
- **Warehouse module** (product variants, stock, EAN)
- **Users module**
- **Orders module** (status and total value)
- **Returns module** (`ID_Zwrotu`, `ID_Zamowienia`, `Powod`, `StatusZwrotu`)

## Screenshots

### 1) Main app - Products module
![StoreManager - Products](./docs/screenshots/menedzer-sklepu-produkty-1.png)

### 2) Main app - Products module (second screenshot)
![StoreManager - Products (2)](./docs/screenshots/menedzer-sklepu-produkty-2.png)

## Project Structure

```text
Sklep_ProjektC#/
?? Models/          # Domain/data models
?? DataAccess/      # Repositories + DatabaseHelper
?? Forms/           # WinForms modules
?? Img/             # Menu icons
?? Program.cs       # App entry point
```

## Getting Started

### Requirements
- Windows 10/11
- .NET 8 SDK
- Access to SQL Server / Azure SQL database

### Run
1. Open `Sklep_ProjektC#.sln` in Visual Studio.
2. Build the solution.
3. Start the app.
4. Click **"Po³¹cz z Baz¹"** and log in using database credentials.

## Notes

- The app no longer stores DB password in source code.
- Credentials are provided via the login form at runtime.

## License

For educational use.
