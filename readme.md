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

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.ForgotPassword;Account.ResetPassword"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.Manage.ChangePassword"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.Logout"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.ResendEmailConfirmation"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.ConfirmEmail"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.ForgotPasswordConfirmation"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.Manage.Index"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.Manage.Email"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --files "Account.Manage"
>> 

dotnet aspnet-codegenerator identity -dc proyecto_inkamanu_net.Data.ApplicationDbContext --files "Account.ConfirmEmail"

dotnet aspnet-codegenerator identity -dc petclinic.Data.ApplicationDbContext --force

>> 
>> 
>> 
>> 
>> 

dotnet add package AspNetCore.HealthChecks --version 1.0.0
dotnet add package DinkToPdf --version 1.0.8
dotnet add package EPPlus --version 6.2.9
dotnet add package FirebaseAuthentication.net --version 3.7.2
dotnet add package FirebaseStorage.net --version 1.0.3
dotnet add package FluentValidation --version 11.7.1
dotnet add package FluentValidation.AspNetCore --version 11.3.0
dotnet add package itext7 --version 8.0.1
dotnet add package MailKit --version 4.2.0
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore --version 7.0.11
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 7.0.11
dotnet add package Microsoft.AspNetCore.Identity.UI --version 7.0.11
dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.11
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.11
dotnet add package Microsoft.Extensions.Http --version 7.0.0
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0.10
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 7.0.11
dotnet add package X.PagedList.Mvc --version 8.0.7
dotnet add package X.PagedList.Mvc.Core --version 8.4.7

para autenticarme con google
dotnet add package Microsoft.AspNetCore.Authentication.Google

para los cookies bloqueados
dotnet add package Microsoft.AspNetCore.CookiePolicy

En jesus_petclinic3 el dia 13/10/2023 agregue varios cambios de la clase, agregu roles, lo del pedido controller y el API DE PRODUCTOS

En jesus_petclinic4 el dia 21/10/2023 le puse correctamente el servicio de api rest para productos, tambien agregue graficos de prueba en formato json para mostrar estadisticas de acuerdo a la data que hay en mi base de datos