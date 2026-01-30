# AgendaSolucion

Aplicación de agenda de contactos desarrollada en C# (.NET) siguiendo arquitectura por capas y aplicando patrones de diseño como Repository y Facade.
El proyecto está pensado con fines educativos y como base sólida para aplicaciones más grandes (consola o gráficas).

## Objetivo del Proyecto
- Practicar buenas prácticas de arquitectura
- Aplicar patrones de diseño
- Separar responsabilidades (UI, negocio, datos)

## Arquitectura
El proyecto está dividido en capas:

Presentation (Console / UI)
        ↓
Facade (AgendaFacade)
        ↓
Business (ContactService)
        ↓
Data (Repository)
        ↓
Entities (Contact)

## Patrones de Diseño Utilizados
Repository Pattern: 
 - Encapsula el acceso a los datos y permite cambiar la fuente (memoria, archivo, DB) sin afectar el resto del sistema.

Facade Pattern: 
 - Simplifica la interacción entre la capa de presentación y la lógica de negocio.

## Tecnologías
- C#
- .NET
- Visual Studio 2022
- Programación Orientada a Objetos
- Arquitectura por capas

## Posibles mejoras futuras
- Guardado de contactos en archivo JSON
- Implementar base de datos (SQLite / SQL Server)
- Interfaz gráfica con WinForms o WPF
- Búsqueda y ordenamiento (Strategy Pattern)
- Tests unitarios

## Autor
- Emmanuel R.
- Desarrollador Backend en formación
- Intereses: C#, .NET, C++, Arquitectura de Software, Backend, Desktop Apps
