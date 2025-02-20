
# Microservicios Cliente Hospital

## Instrucciones para la configuración y ejecución del sistema.

 Requisitos previos y dependencias del proyecto
Para ejecutar correctamente este proyecto, es necesario contar con los siguientes requisitos previos y herramientas:
 ### Framework y herramientas: 
- .NET Core en la versión especificada en el repositorio del proyecto.
- SQL Server Management Studio (SSMS) para gestionar las bases de datos.
- RabbitMQ configurado en el sistema.
- Docker instalado y configurado correctamente para ejecutar contenedores.
- Otras dependencias y paquetes con su versión recomendada también se encuentran detallados en los archivos de configuración del proyecto (como csproj y appsettings.json). .

## Clonación del Repositorio
Clona el repositorio desde la rama principal utilizando el siguiente comando:

```bash
git clone https://github.com/camjor/PruebaTecnicaMicroservicios.git
```

## Preparación de los Contenedores en Docker
Ejecuta las siguientes imágenes en Docker:

- **SQL Server**: Asegúrate de asignar el puerto según las configuraciones en `appsettings.json`.
- **RabbitMQ**: Configura RabbitMQ para comunicarse en el puerto correspondiente. Asegúrate de que los puertos expuestos coincidan con los configurados en los microservicios.

## Configuración de las Bases de Datos
Cada microservicio utiliza su propia base de datos independiente. Configura las cadenas de conexión en el archivo `appsettings.json` de cada microservicio. Asegúrate de que las cadenas de conexión apunten a la base de datos del contenedor SQL Server.

## Configuración de RabbitMQ
Configura la URL del servidor RabbitMQ en los archivos `appsettings.json` de los microservicios relacionados con Citas y Recetas.

## Migración y Ejecución de los Microservicios
1. Navega a la carpeta de cada microservicio utilizando PowerShell o cualquier terminal de tu preferencia.
2. Ejecuta las migraciones necesarias para preparar las bases de datos con el siguiente comando:
   ```bash
   dotnet ef migrations add NombreDeLaMigracion
   ```
3. Una vez completada la migración, ejecuta el microservicio con el comando:
   ```bash
   dotnet run
   ```

## Pruebas y Endpoints
Para probar los endpoints de cada microservicio, puedes utilizar Postman o cualquier otra herramienta de cliente HTTP. Consulta la documentación del proyecto para obtener detalles sobre los endpoints disponibles y su funcionalidad.

