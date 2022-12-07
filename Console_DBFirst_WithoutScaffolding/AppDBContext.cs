using Console_DBFirst_WithoutScaffolding.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DBFirst_WithoutScaffolding
{
    internal class AppDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=WebApiAutores;User Id=postgres;Password=634510");
        }

        public DbSet<Autores> Autores { get; set; }

        public DbSet<Libros> Libros { get; set; }   
    }
}
