# GEMINI.md - Project Context

## Project Overview
**proyecto1programacion** is a desktop application developed using **C#** and **Windows Forms**, targeting **.NET Framework 4.7.2**. The project currently serves as a baseline or initial prototype for a Windows-based application.

### Tech Stack
- **Language:** C#
- **Framework:** .NET Framework 4.7.2
- **UI:** Windows Forms (WinForms)
- **IDE Context:** Visual Studio (inferred from `.slnx`, `.csproj`, and `.vs` folder)

## Project Structure
- `Program.cs`: The entry point of the application.
- `Form1.cs`: The main user interface form.
- `proyecto1programacion.csproj`: The project configuration and dependency file.
- `App.config`: Application configuration file.
- `Properties/`: Contains assembly information, resources, and settings.

## Building and Running
As a standard .NET Framework project, it can be managed using the `dotnet` CLI or `msbuild`.

### Building
To build the project in Debug mode:
```powershell
msbuild /p:Configuration=Debug
```
*Note: Ensure `msbuild` is in your PATH (usually via a Developer Command Prompt for Visual Studio).*

### Running
To run the application after building:
```powershell
.\bin\Debug\proyecto1programacion.exe
```

### Cleaning
To clean build artifacts:
```powershell
msbuild /t:clean
```

## Development Conventions
- **Naming Conventions:** Follows standard .NET naming conventions (PascalCase for classes, methods, and properties).
- **UI Logic:** UI logic is encapsulated within WinForms `Form` classes.
- **Namespaces:** The primary namespace is `proyecto1programacion`.

## TODOs / Next Steps
- [ ] Implement core application logic in `Form1.cs`.
- [ ] Define specific user requirements and UI components.
- [ ] Add unit tests if applicable.
