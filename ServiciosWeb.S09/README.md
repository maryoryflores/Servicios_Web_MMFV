//ServiciosWeb.S09

Proyecto desarrollado en ASP.NET Core Web API (.NET 10)

//Requisitos

* Visual Studio 2026 Community.
* .NET 10 SDK.
* Git instalado.

//Clonar el repositorio

git clone URL_DEL_REPOSITORIO

Ingresar a la carpeta del proyecto:

cd ServiciosWeb.S09

//Ejecutar el proyecto

1. Abrir la solución en Visual Studio.
2. Restaurar los paquetes NuGet si es necesario.
3. Presionar **F5** o **Iniciar Depuración**.
4. Copiar el puerto HTTPS generado por Visual Studio.

Ejemplo:

https://localhost:7024

5. Abrir el archivo `wwwroot/index.html`.
6. Verificar que la variable `baseUrl` tenga el mismo puerto:
const baseUrl = "https://localhost:7024/api/condicionales";
7. Guardar los cambios y ejecutar la aplicación.

//Funcionalidades

* Clasificar Edad.
* Validar Acceso.
* Calcular Descuento.
* Obtener Día de la Semana.
