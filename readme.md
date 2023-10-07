## petclinic

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 7.0.4

dotnet tool update --global dotnet-ef --version 7.0.10

// migracion de la vez pasada
dotnet ef migrations add InitialMigration --context petclinic.Data.ApplicationDbContext -o "D:\JESUS SORIA\Todo mi 6to ciclo de la UNI\CURSOS DEL 6TO CICLO\PROGRAMACION I\Proyectos_de_Programacion_I\Proy_Sem3_Clases\petclinic\Data\Migrations"

dotnet ef database update

dotnet ef migrations remove

// migracion de la clase del 08 de setiembre
dotnet ef migrations add ProductoMigration --context petclinic.Data.ApplicationDbContext -o "D:\JESUS SORIA\Todo mi 6to ciclo de la UNI\CURSOS DEL 6TO CICLO\PROGRAMACION I\Proyectos_de_Programacion_I\Proy_Sem3_Clases\petclinic\Data\Migrations"

// migracion de la clase del 15 de setiembre
dotnet ef migrations add ProformaMigration --context petclinic.Data.ApplicationDbContext -o "D:\JESUS SORIA\Todo mi 6to ciclo de la UNI\CURSOS DEL 6TO CICLO\PROGRAMACION I\Proyectos_de_Programacion_I\Proy_Sem3_Clases\petclinic\Data\Migrations"

dotnet ef database update

// dependencia antes del codigo de codegenerator
proimero poner esta dependencia
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0.10

// codigo para modificar el login 15/09/2023
dotnet tool install -g dotnet-aspnet-codegenerator // poner esto si te sale error 

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.Register;Account.Login"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.Register;Account.Login"


// mi cadena de conexión localmente lo que va en el appsettings.json

"PostgresSQLConnection":"Host=dpg-cjp6jtojbais73fb94dg-a.oregon-postgres.render.com ;Database=petclinic_database_un42;Username=petclinic_database_un42_user;Password=7vHSGANJGOUlOZNzQ4GEsI5FHg1WooL8;Port=5432;SSL Mode=Require;Trust Server Certificate=true"

// comando para agregar el healchetf

dotnet add package AspNetCore.HealthChecks --version 1.0.0 


### CRUD GENERAR UN CRUD
dotnet aspnet-codegenerator controller -name ProductoController -m Producto -dc petclinic.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

dotnet add package Microsoft.EntityFrameworkCore.SqlServer


dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.11
