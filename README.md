📌 Hartek Maintenance App

This is a Windows Forms application developed for managing machine maintenance operations in a factory environment.
It supports:

✔ Machine-based maintenance tracking

✔ Daily–weekly–monthly inspection management

✔ SQL database integration

✔ User roles (Admin / Operator)

✔ Real maintenance records with date–user–machine info

🚀 Technologies Used

C# (.NET Framework / WinForms)

SQL Server

ADO.NET

Object-Oriented Programming

Git & GitHub

🔧 Features

Add, remove, and update maintenance items

Select machine from ComboBox

Define maintenance types (Inspection, Replik, Replacement, Lubrication, Calibration)

Store and load data from SQL Server

Save notes for each maintenance record

GridView for displaying all maintenance items

📦 Database Structure

Table: MaintenanceItems

Column	Type	Description
Id	int	Primary Key
MachineName	nvarchar(100)	Machine selected from ComboBox
MaintenanceType	nvarchar(50)	Inspection / Replik / Replacement / Lubrication / Calibration
Description	nvarchar(MAX)	Maintenance details
Notes	nvarchar(MAX)	Operator/Admin notes
CreatedAt	datetime	Record timestamp
🖼️ Screenshots (Eklenecek)

You can add screenshots later.

📈 Future Improvements

User login system

Role-based permissions

Report export (Excel / PDF)

QR code machine scanning

Cloud database integration

Multi-language support

🔧 How to Run the Project

Clone the repository

Open solution in Visual Studio

Update SQL connection string

Run DB script

Run the application

📬 Author

Ekrem Örenli
Factory Manager / Industrial Engineer
Learning C#, SQL and building real-life applications