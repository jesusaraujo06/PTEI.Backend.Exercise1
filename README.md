# **PTEI.Backend.Exercise1**
## WEB API para operaciones CRUD de productos en una base de datos SQLServer
## Requisitos

[.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)

[SQLServer](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)

## Empezar

Empiece clonando el repositorio

```bash
git clone https://github.com/jesusaraujo06/PTEI.Backend.Exercise1.git
```

Diríjase a la ruta donde clonó el repositorio y abra la solución con Visual Studio o Visual Studio Code.

```bash
cd your_path
```

Diríjase al proyecto ‘`ProductManagement.API`’, abra el archivo ‘`appsettings.json`’ y modifique la propiedad ‘`ConnectionStrings`' según la conexión a su base de datos SQLServer.

```json
"ConnectionStrings": {
    "ProductConnection": "Server=YourSERVERSQLServer;Database=Exercise1Db;User Id=root;Password=root123; Integrated Security=True; TrustServerCertificate=True;"
  }
```

### Migraciones

Dentro de su Visual Studio diríjase al menu: 

🔗 Herramientas → Administrador de paquetes Nuget → Consola del Administrador de paquetes.

Dentro de la consola del Administrador de paquetes, en el apartado de ‘Proyecto predeterminado’, elegir `ProductManagement.Data` y copiar el siguiente código en la consola:

```bash
update-database
```

Si su conexión a SQLServer fue exitosa, en este punto ya se habrá creado la base de datos ‘Exercise1Db’ en su SQLServer.

Eso es todo, ya podemos ejecutar el proyecto `ProductManagement.API`

## Demostración:

![Untitled](https://github.com/jesusaraujo06/PTEI.Backend.Exercise1/assets/72844628/0ef15222-93e3-4744-809f-b94ca0d7687b)


### Prueba del endpoint: `GetAll`
Descripción del endpoint: Obtiene el listado completo de productos

Request URL:

```bash
https://localhost:7023/api/Products/GetAll
```

Response:

```json
{
  "success": true,
  "data": [
    {
      "id": 1,
      "name": "Camisa de Python",
      "description": "Camisa con estampado del logo de Python",
      "price": 100000,
      "stock": 100,
      "creationDate": "2023-09-12T22:14:03.0637192",
      "modificationDate": "2023-09-12T22:14:03.0637204"
    },
    {
      "id": 2,
      "name": "Camisa de JavaScript",
      "description": "Camisa con estampado de código JavaScript",
      "price": 120000,
      "stock": 75,
      "creationDate": "2023-09-12T22:14:03.0637207",
      "modificationDate": "2023-09-12T22:14:03.0637208"
    },
    {
      "id": 3,
      "name": "Camisa de C#",
      "description": "Camisa con estampado del logo de C#",
      "price": 250000,
      "stock": 80,
      "creationDate": "2023-09-12T22:14:03.0637209",
      "modificationDate": "2023-09-12T22:14:03.063721"
    },
    {
      "id": 4,
      "name": "Camisa de Java",
      "description": "Camisa con estampado del logo de Java",
      "price": 50000,
      "stock": 70,
      "creationDate": "2023-09-12T22:14:03.0637212",
      "modificationDate": "2023-09-12T22:14:03.0637212"
    },
    {
      "id": 5,
      "name": "Camisa de Angular",
      "description": "Camisa con estampado del logo de Angular",
      "price": 250000,
      "stock": 90,
      "creationDate": "2023-09-12T22:14:03.0637214",
      "modificationDate": "2023-09-12T22:14:03.0637214"
    },
    {
      "id": 6,
      "name": "Camisa de Everest Intelligent",
      "description": "Camisa con estampado del logo de Everest Intelligent",
      "price": 500000,
      "stock": 5,
      "creationDate": "2023-09-12T22:14:03.0637216",
      "modificationDate": "2023-09-12T22:14:03.0637217"
    }
  ],
  "message": null,
  "isException": false
}
```

### Consideraciones
La solución esta creada de tal forma que:
- **Respuestas de la API unificadas** Los endpoints de esta WEB API utilizan la misma logica de respuesta, lo cual hará que esta sea más facil de consumir por cualquier servicio propio o externo.
- Implementa el patron de diseño Repository el cual encapsula el comportamiento de almacenamiento, obtención y búsqueda de datos.
- Se abstrae la logica de negocio / empresarial en un proyecto Domain
- Se utiliza la inyección de dependencias.
- Utiliza EntityFramework como ORM para el acceso a datos.

### Pendiente o por mejorar
- Paginar los resultados de la WEB API.

## **Descripción de la prueba técnica**

**Ejercicio práctico 1**
En este ejercicio, se te pide que desarrolles un controlador en una Web API .NET Core C# que
implemente el principio SOLID de Responsabilidad Única. El controlador debe permitir a los
usuarios realizar operaciones CRUD (crear, leer, actualizar, eliminar) en una tabla de productos en una base de datos SQL Server.

**Requisitos**

- La Web API debe implementar una clase Repository que sera responsable de las operaciones de lectura y escritura en la tabla de productos.
- El controlador debe ser capaz de recibir solicitudes en formato JSON y devolver respuestas en formato JSON.
- La Web API debe implementar un controlador que se encargue de manejar las solicitudes de los usuarios para realizar operaciones CRUD en la tabla de productos.
- El controlador debe estar diseñado de manera que cada método sea responsable de una única tarea (Responsabilidad Única).

**Entregables**

- El código fuente de la Web API en un repositorio de Git.
- Un archivo README que explique cómo se puede ejecutar la Web API y cualquier otra información relevante.
