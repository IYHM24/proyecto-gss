using Microsoft.EntityFrameworkCore;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Models.Cliente> Cliente { get; set; }
        public DbSet<Models.Carro> Carro { get; set; }
        public DbSet<Models.Alquiler> Alquiler { get; set; }
        public DbSet<Models.Pagos> Pagos { get; set; }
        public DbSet<Models.Registro> Registro { get; set; }
        public DbSet<Models.Contador> Contador { get; set; }


    }
    
}
