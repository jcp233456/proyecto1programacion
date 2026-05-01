# GEMINI.md - Project Context

## Project Overview
**proyecto1programacion** is a desktop application developed using **C#** and **Windows Forms**, targeting **.NET Framework 4.7.2**. It serves as an inventory management prototype, allowing users to input product details and persist them using JSON.

### Tech Stack
- **Language:** C#
- **Framework:** .NET Framework 4.7.2
- **UI:** Windows Forms (WinForms)
- **Dependencies:** 
  - `Newtonsoft.Json` (v13.0.5-beta1): Used for data serialization and persistence.
- **IDE:** Visual Studio (inferred from `.slnx`, `.csproj`, and `.vs` folder).

## Project Structure
- `Program.cs`: Entry point of the application. It launches `Form1`.
- `Form1.cs`: The primary data entry form for products. It handles user input and triggers persistence logic.
- `MenuPrincipalForm.cs`: A secondary form intended to serve as a main menu.
- `Producto.cs`: Data model representing a product with properties like `Codigo`, `Nombre`, `Marca`, `Precio_compra`, `Precio_venta`, and `Cantidad_existente`.
- `PersistenciaProducto.cs`: Data Access Layer (DAL). Manages reading from and writing to `jsonProducto.txt` using JSON serialization.
- `proyecto1programacion.csproj`: Project configuration and dependency management.
- `App.config`: Application configuration.
- `packages.config`: NuGet package management file.

## Data Persistence
The application uses a simple file-based persistence strategy:
- **File:** `jsonProducto.txt` (local directory).
- **Format:** JSON array of `Producto` objects.
- **Logic:** Encapsulated in `PersistenciaProducto.cs`.

## Building and Running
As a standard .NET Framework project, it can be managed using `msbuild`.

### Prerequisites
- .NET Framework 4.7.2 Developer Pack.
- MSBuild (usually included with Visual Studio or Build Tools for Visual Studio).

### Building
To build the project in Debug mode:
```powershell
msbuild /p:Configuration=Debug
```

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
- **Naming:** Follows standard .NET PascalCase for classes, methods, and public properties. Internal fields in `Producto.cs` currently use camelCase (e.g., `codigo`).
- **Namespace:** `proyecto1programacion`.
- **UI Logic:** Encapsulated in code-behind files (`.cs`) associated with WinForms designers.
- **Persistence:** All data management should go through `PersistenciaProducto`.

## TODOs / Next Steps
- [ ] Implement robust error handling for file I/O in `PersistenciaProducto`.
- [ ] Expand `MenuPrincipalForm` with actual navigation or dashboard features.
- [ ] Add validation logic for product input (e.g., numeric constraints, required fields).
- [ ] Consider migrating to a more formal database if the dataset grows.
