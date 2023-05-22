using _02_Dominio.Entidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura.Context
{
    public class PostgresContext : DbContext
    {
        public DbSet<Libro> Libros { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Set the PostgreSQL connection string
            optionsBuilder.UseNpgsql("Host=postgres;Port=5432;Database=Libros;Username=root;Password=root;");
        }
    }
}
