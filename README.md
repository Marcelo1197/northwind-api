# NorthwindAPI

## Intro
NorthwindAPI es una API RESTFUL desarrollada con .NET 6 utilizando la base de datos [Northwind](https://github.com/Marcelo1197/northwind-api/tree/main/sql-scripts) que provee Microsoft.
Por ahora cuenta con las operaciones básicas de un CRUD. 

## Recursos necesarios
#### Debe descargar e instalar:
* **[VisualStudio](https://visualstudio.microsoft.com/es/)**
* **[SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)**
* **[SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)**

## Usar

#### Crear la base de datos

* Abrir los [scripts](https://github.com/Marcelo1197/northwind-api/tree/main/sql-scripts) de SQL para crear/insertar los datos con SQL Server Management Studio
* Ejecutarlos con F5

#### Configurar conexión a la Base de Datos

* Abrir el archivo [appsettings.json](https://github.com/Marcelo1197/northwind-api/blob/main/NorthwindAPI/NorthwindAPI/appsettings.json)
* Modificar la propiedad [ConnectionStrings](https://github.com/Marcelo1197/northwind-api/blob/7308050eb68ea1013a6b1970755d4e7d9f1b78c0/NorthwindAPI/NorthwindAPI/appsettings.json#L10) con el nombre de tu servidor. Ej:
```
 "Northwind": "Data Source=TU_SERVIDOR_AQUÍ;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

```

#### Ejecutar el Proyecto
* Click derecho sobre el proyecto **NorthwindAPI**
* Seleccionar **Set as Startup Project**
* Ejecutar con F5 o el botón de la ToolBar
