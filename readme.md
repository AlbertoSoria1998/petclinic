## petclinic

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 7.0.4

dotnet tool update --global dotnet-ef --version 7.0.10

dotnet ef migrations add InitialMigration --context petclinic.Data.ApplicationDbContext -o "C:\Users\XXXXX\XXXXXXX\petclinic\Data\Migrations"

dotnet ef database update

dotnet ef migrations remove