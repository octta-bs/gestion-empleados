# Gestión de Empleados

Dos proyectos que muestran la evolución de una misma aplicación: de .NET Framework clásico a una arquitectura más moderna con MVC, Entity Framework y Web API.

## Proyecto 1: GestionEmpleados (Web Forms)

- ASP.NET Web Forms con AJAX (`UpdatePanel`)
- ADO.NET con consultas parametrizadas
- Separación en capas (formulario y repositorio)
- Manejo de excepciones con `try/catch`

## Proyecto 2: GestionEmpleadosMVC

- ASP.NET MVC con vistas Razor
- Entity Framework 6 (Code First sobre una tabla existente)
- CRUD completo: crear, listar, editar y borrar
- Inyección de dependencias (interfaz + repositorio)
- Web API REST (`api/EmpleadosApi`)

## Cómo correrlo

1. Tener Visual Studio y SQL Server LocalDB.
2. Crear la base `Practica` con la tabla `EmpleadosGestion` (Id, Nombre, Puesto).
3. Abrir la solución de cada proyecto y presionar F5.

## Autor

Octavio Sánchez
