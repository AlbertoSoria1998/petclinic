## petclinic

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 7.0.4

dotnet tool update --global dotnet-ef --version 7.0.10

// migracion de la vez pasada
dotnet ef migrations add InitialMigration --context petclinic.Data.ApplicationDbContext -o "D:\JESUS SORIA\Todo mi 6to ciclo de la UNI\CURSOS DEL 6TO CICLO\PROGRAMACION I\Proyectos_de_Programacion_I\Proy_Sem3_Clases\petclinic\Data\Migrations"

dotnet ef database update

dotnet ef migrations remove

// migracion de la clase del 08 de setiembre
dotnet ef migrations add ProductoMigration --context petclinic.Data.ApplicationDbContext -o "D:\JESUS SORIA\Todo mi 6to ciclo de la UNI\CURSOS DEL 6TO CICLO\PROGRAMACION I\Proyectos_de_Programacion_I\Proy_Sem3_Clases\petclinic\Data\Migrations"