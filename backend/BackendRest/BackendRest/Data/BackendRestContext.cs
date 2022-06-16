using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackendRest.Model;

namespace BackendRest.Data
{
    public class BackendRestContext : DbContext
    {
        public BackendRestContext (DbContextOptions<BackendRestContext> options)
            : base(options)
        {
        }

        public DbSet<BackendRest.Model.Cliente>? Cliente { get; set; }

        public DbSet<BackendRest.Model.Carro>? Carro { get; set; }

        public DbSet<BackendRest.Model.Alquiler>? Alquiler { get; set; }

        public DbSet<BackendRest.Model.Pagos>? Pagos { get; set; }
    }
}
