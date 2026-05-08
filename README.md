TP2 Programación III - Blazor WebAssembly

Descripción

Este proyecto corresponde al Trabajo Práctico Nº2 de la materia Programación III. Se trata de una aplicación web desarrollada con Blazor WebAssembly (WASM) en .NET 9.0, que incluye:

Login con validación.

Listado de personas con datos básicos.

Formulario para agregar personas.

Componentes reutilizables (ejemplo: Saludo.razor).

Requisitos

.NET SDK 9.0+

Visual Studio 2026 

Navegador moderno (Edge, Chrome, Firefox)

Ejecución del proyecto

Clonar el repositorio:

git clone https://github.com/MelisaA008/tp2ProgramacionIII.git

Entrar en la carpeta del proyecto:

cd tp2ProgramacionIII

Restaurar dependencias:

dotnet restore

Ejecutar la aplicación:

dotnet run

Abrir en el navegador la dirección:

https://localhost:7176

Estructura del proyecto

UI/ → Páginas y componentes Blazor.

BL/ → Lógica de negocio (servicios).

DAL/ → Modelos y repositorios.

wwwroot/ → Archivos estáticos (CSS, imágenes, JS).

Autenticación

Usuario: alumno

Contraseña: 1234

Notas

Se incluye un archivo .gitignore para evitar subir archivos innecesarios (bin/, obj/, .vs/, etc.).

El proyecto utiliza Bootstrap para estilos.

👩‍💻 Autora: MelisaA008
