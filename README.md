# TAB---project
The project presents the clinic's database. It stores patients, doctors, registrars, lab managers and lab workers.

ENTITY FRAMEWORK GUIDE:
 Tools->NuGet Package Manager -> Manage NuGet Packages for Solution
 Find and install:
      Microsoft.EntityFrameworkCore.SqlServer
      Microsoft.EntityFrameworkCore.Tools
 Tools -> NuGet Package Manager -> Package Manager Console
 Run command to generate classes from an existing DB:
      Scaffold-DbContext "Server=localhost;Database=ClinicDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Database

 "Build failed"? Make sure your project compiles without errors before running.
