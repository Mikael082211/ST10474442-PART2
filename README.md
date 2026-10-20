# ST10474442
<img width="1901" height="1033" alt="image" src="https://github.com/user-attachments/assets/40e568fc-28f4-4997-aa29-acc7f8321f7f" />

# ST10474442 – RaceDay System

## Project Description

RaceDay is a web-based racing management system developed using C# and ASP.NET Core MVC. The project is designed to organise racing-related information and provide a web interface for managing system data.

This project forms part of RaceDay Part 2 and builds on the database design completed in Part 1.

## Technologies Used

- C#
- ASP.NET Core MVC
- Microsoft SQL Server
- Entity Framework Core
- HTML and CSS
- GitHub

## Project Structure

- **Areas:** Organises different sections of the application.
- **Controllers:** Handles user requests and application logic.
- **Data:** Contains database-related code.
- **Models:** Defines the data used by the system.
- **Views:** Contains the pages displayed to users.
- **wwwroot:** Stores CSS, JavaScript, and image files.
- **Raceway.Tests:** Contains automated tests.
- **Program.cs:** Configures and starts the application.

## Setup Instructions

1. Clone or download the repository from GitHub.
2. Open `Raceway.sln` in Visual Studio.
3. Restore the NuGet packages.
4. Configure the SQL Server connection string in the application settings.
5. Make sure the database matches the design from Part 1.
6. Build and run the application.

## Running Tests

To run the automated tests, use:

```bash
dotnet test Raceway.sln
```

## Conclusion

The RaceDay system uses ASP.NET Core MVC to organise the application's code into models, views, and controllers. The project builds on the database design from Part 1 and provides a foundation for further development of the racing management system.
