# Laboratorio: Aplicación de Gestión de Estudiantes con ASP.NET Core MVC

## Descripción

Este laboratorio consiste en crear una aplicación web utilizando **ASP.NET Core MVC** para gestionar estudiantes. El objetivo es crear un formulario que permita insertar estudiantes en una base de datos **SQL Server**. El proyecto está organizado siguiendo la arquitectura **MVC** y emplea una estructura por capas.

## Instrucciones

### 1. Crear un nuevo proyecto en ASP.NET Core MVC

- Abre **Visual Studio** y selecciona **Crear un nuevo proyecto**.
- Selecciona **Aplicación web (Modelo-Vista-Controlador)**.
- Asigna un nombre y una ruta para el proyecto.
- Marca la opción **Colocar la solución y el proyecto en el mismo directorio**.
- Elige **.NET 6.0** como marco de trabajo.
- Asegúrate de habilitar la opción **Configurar para HTTPS**.

### 2. Estructura del Proyecto

- **Controllers**: Aquí es donde se crean los controladores para manejar las solicitudes HTTP.
  - `HomeController.cs`: Se encargará de la lógica principal para el formulario de inserción de estudiantes.
  
- **Models**: Aquí se colocan los modelos de datos.
  - **Domain**: Define las clases relacionadas con la lógica de negocio.
    - `Student.cs`: Contendrá las propiedades del estudiante.
  - **Data**: Encapsula la lógica para acceder a la base de datos.
    - `StudentDAO.cs`: Será la clase encargada de realizar la inserción de estudiantes en la base de datos.

- **Views**: Contiene las vistas o páginas HTML de la aplicación.
  - **Home**: Aquí estarán las páginas principales.
    - `Index.cshtml`: Página con el formulario de inserción de estudiantes.
    - `Privacy.cshtml`: Página de confirmación tras enviar el formulario.
  - **Shared**: Páginas compartidas entre todas las vistas.
    - `_Layout.cshtml`: El diseño base de la aplicación.

### 3. Crear la clase `Student`

En la carpeta `Models/Domain`, crea la clase `Student.cs`:

```csharp
namespace lab2LenguajesDaniel.Models.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
