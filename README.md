# GestionStock

A C# WinForms application designed for inventory management. Although the codebase and database schema use terms like "employee" due to the project's origin, all such references now represent stock items (products, parts, etc.).

## Overview

GestionStock allows small businesses to efficiently manage their inventory. The application provides a user-friendly interface for adding, updating, listing, and deactivating stock items, as well as organizing them by categories such as brands and item types.

## Main Features

- **Stock Item Management:**  
  Add, edit, list, and deactivate stock items.

- **Category Organization:**  
  Items can be grouped by brands and types.

- **Search and Filtering:**  
  Quickly search and filter items by name or category.

- **Database Integration:**  
  Uses SQL Server for data storage. The provided scriptDB.sql sets up the necessary tables and initial data. All database operations are handled via stored procedures for reliability and performance.

- **Extensible Architecture:**  
  The project is organized into layers:  
  - **Datos/**: Data access layer (e.g., `D_Empleados` for stock item data)  
  - **Entidades/**: Entity classes (e.g., `E_Empleado` for stock item objects)  
  - **Presentacion/**: WinForms UI (e.g., `FrmEmpleados` for the main stock item form)

## Database

- **Tables:**  
  - `tb_empleados`: Stores stock items (originally named for employees)  
  - `tb_departamentos`: Stores item categories or brands  
  - `tb_cargos`: Stores item types or subcategories

- **Initial Data:**  
  The SQL script includes sample data for brands and types.

## Usage

1. **Database Setup:**  
   Run scriptDB.sql on your SQL Server instance to create and initialize the database.

2. **Configuration:**  
   Update the connection string in `App.config` to point to your SQL Server.  
   _Ensure you do not commit sensitive information like passwords to public repositories._

3. **Running the Application:**  
   Open the solution in Visual Studio, build, and run.  
   Use the UI to manage your inventory.

## Important Note

> All references to "employee(s)" in code, forms, and database actually refer to stock items. For example, `FrmEmpleados` is the main inventory form, and `D_Empleados` is the data access class for stock items. This will be modified in upcoming updates.

## Project Structure

```
GestionStock/
│
├── Datos/           # Data access layer (ADO.NET)
├── Entidades/       # Entity classes (stock items, categories, types)
├── Presentacion/    # WinForms UI (forms for managing stock)
├── scriptDB.sql     # SQL Server database creation and seed script
├── GestionStock.sln # Visual Studio solution file
└── App.config       # Application configuration (connection string)
```

## Contribution

Feel free to fork and adapt the project for your own inventory management needs. If you improve the code or adapt the naming to reflect the new domain, contributions are welcome!

