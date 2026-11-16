# AgendaElectronica

# Agenda Electrónica Multicapa

## Descripción del proyecto

Agenda Electrónica es una aplicación de escritorio desarrollada en C# con Windows Forms, que permite administrar contactos mediante operaciones CRUD (Crear, Leer, Actualizar y Eliminar).

El proyecto utiliza una arquitectura multicapa para separar las responsabilidades y facilitar el mantenimiento del código.

## Tecnologías utilizadas

- C#
- Windows Forms
- .NET 10
- SQL Server
- Microsoft.Data.SqlClient
- Visual Studio

## Arquitectura del proyecto

La solución está organizada en cuatro capas:

- **Agenda.Presentacion:** interfaz gráfica e interacción con el usuario.
- **Agenda.Negocio:** validaciones y reglas de negocio.
- **Agenda.Datos:** conexión con SQL Server y ejecución de consultas y procedimientos almacenados.
- **Agenda.Entidades:** clases que representan los datos de los contactos.

## Funcionalidades

- Registrar contactos.
- Consultar y listar contactos.
- Buscar contactos.
- Modificar información de contactos.
- Eliminar contactos.
- Validar los datos antes de guardarlos.

## Base de datos

El proyecto utiliza SQL Server y una base de datos llamada `AgendaElectronica_Multicapa`.

La tabla principal es `Contactos` y contiene los siguientes campos:

- Id
- Nombre
- Telefono
- Correo
- Direccion

Los scripts para crear la base de datos y sus procedimientos almacenados se encuentran en la carpeta `BaseDatos`.

## Instalación y ejecución

1. Clonar o descargar el repositorio.
2. Abrir la solución `AgendaElectronica.sln` en Visual Studio.
3. Ejecutar el script `BaseDatos/CrearBaseDatos.sql` en SQL Server, si la base de datos todavía no existe.
4. Verificar la cadena de conexión en la clase `Conexion.cs`.
5. Restaurar los paquetes NuGet.
6. Seleccionar `Agenda.Presentacion` como proyecto de inicio.
7. Ejecutar la aplicación.

## Autor

Francheska Then Ubiera - Proyecto académico desarrollado como práctica de programación multicapa.