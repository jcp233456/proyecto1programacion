# Proyecto 1 Programación - Sistema de Gestión

Este proyecto es una aplicación de escritorio desarrollada en C# utilizando Windows Forms. Está diseñada para gestionar clientes, productos y facturas, utilizando archivos JSON locales para la persistencia de datos.

## Descripción del Proyecto

La aplicación permite realizar operaciones básicas de CRUD (Crear, Leer, Actualizar, Borrar) sobre las entidades principales del sistema. La persistencia se maneja de forma sencilla mediante la serialización y deserialización de listas de objetos a archivos de texto en formato JSON.

### Tecnologías Principales

- **Lenguaje:** C#
- **Framework:** .NET Framework 4.7.2
- **Interfaz de Usuario:** Windows Forms (WinForms)
- **Librerías Externas:** `Newtonsoft.Json` (para el manejo de archivos JSON)

## Arquitectura y Estructura

El proyecto sigue una estructura tradicional de WinForms con lógica en el código subyacente (*code-behind*), apoyada por clases de persistencia dedicadas.

### Componentes Clave

- **Modelos (`.cs`):**
  - `Cliente.cs`: Define los atributos de los clientes.
  - `Producto.cs`: Define los atributos de los productos (código, nombre, marca, precios, existencia).
  - `Factura.cs`: Gestiona la información de las ventas/facturación.
- **Persistencia (`Persistencia*.cs`):**
  - Clases como `PersistenciaCliente`, `PersistenciaProducto` y `PersistenciaFactura` encapsulan la lógica de lectura y escritura en archivos JSON (ej. `jsonCliente.txt`).
- **Formularios (`Form*.cs`):**
  - `Form1.cs`: Actúa como la interfaz principal para la gestión de datos y visualización.
  - `MenuPrincipalForm.cs`: Sirve como punto de navegación central de la aplicación.

## Guía de Desarrollo

### Convenciones de Código

- **Nomenclatura:** Se utiliza PascalCase para propiedades y clases, y camelCase para variables locales. Algunas propiedades de modelos pueden incluir guiones bajos (ej. `Precio_compra`).
- **Persistencia:** Cualquier cambio en las listas de objetos debe ser seguido por una llamada al método `GuardarJson` de la clase de persistencia correspondiente para asegurar que los cambios se reflejen en el disco.
- **UI:** El enlace de datos en los formularios se realiza comúnmente a través de la propiedad `DataSource` de los controles (como `ComboBox`).

### Construcción y Ejecución

1.  **Requisitos:** Tener instalado Visual Studio (2017 o superior) con la carga de trabajo de desarrollo de escritorio de .NET.
2.  **Restauración de Paquetes:** Asegurarse de que el paquete `Newtonsoft.Json` esté restaurado vía NuGet.
3.  **Compilación:** Abrir el archivo `.slnx` o `.csproj` en Visual Studio y presionar `F5` o utilizar el botón de "Iniciar".

---
*Nota: Este archivo fue generado automáticamente para proporcionar contexto al asistente Gemini.*
