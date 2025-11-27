# Hartek Maintenance App 🛠️

**HartekMaintenanceApp** is a simple maintenance & equipment tracking application built with **C# WinForms** and **SQLite**.

## 🚀 About the Project

This application allows users to:

- Register machines (Name, Last Maintenance Date, Notes)  
- Create and manage maintenance records (Type, Date, Notes)  
- Perform full CRUD operations (Add, Update, Delete, List)  
- Store data locally using **SQLite**  
- Use a clean and functional Windows Forms UI  

It is designed for small or medium-sized workshops to easily track daily machine maintenance activities.

## 📂 Project Structure (Recommended)

/HartekMaintenanceApp
/Models — Data models (Machine, Maintenance, etc.)
/Data — Database access layer (DatabaseHelper, Repository)
/Services — Business logic classes
/UI — Windows Forms (MainForm + Designer)
Program.cs — Application entry point


## 🛠️ Setup & Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/orenliEkrem/HartekMaintenanceApp.git
2. Open the project in Visual Studio
3. Install required NuGet package:
	-System.Data.SQLite
4. Run the application
	-The SQLite database and tables will be created automatically.

## ✅ Current Features
| Feature                                                                       | Status                  |
| ----------------------------------------------------------------------------- | ----------------------- |
| Machine CRUD (Add / Update / Delete / List)                                   | ✅ Completed             |
| SQLite local storage                                                          | ✅ Completed             |
| WinForms GUI                                                                  | ✅ Completed             |
| Maintenance types (inspection, repair, replacement, lubrication, calibration) | ⚠ Partially implemented |

## 📈 Future Improvements / Roadmap

	-Separate Repository & Service layers (UI → Logic → Data)

	-Improved error handling and input validation

	-Unit tests and cleaner architecture

	-Support for multiple databases (SQLite, PostgreSQL, etc.)

	-REST API + Web UI (future expansion)

	-Reporting (Excel, PDF), maintenance planning, reminders

	-Export / Import features

## 🤝 Contributing

Contributions are welcome!
Please read the CONTRIBUTING.md before opening a pull request.

## 📄 License

This project is licensed under the MIT License — see the LICENSE file for details.

## 👤 Developer

**Ekrem Örenli**
Factory Manager / Industrial Engineer
Learning C#, SQL and building real-life applications