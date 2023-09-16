using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using petclinic.Models;
namespace petclinic.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

     public DbSet<Contacto> DataContactos { get; set; }
     public DbSet<Producto> DataProductos { get; set; }
     public DbSet<Proforma> DataCarrito { get; set; }
}
