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