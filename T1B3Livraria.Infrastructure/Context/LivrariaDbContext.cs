using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1B3Livraria.Domain.Entities;
using T1B3Livraria.Infrastructure.Configurations;

namespace T1B3Livraria.Infrastructure.Context
{
    public class LivrariaDbContext : IdentityDbContext
    {
        public LivrariaDbContext(DbContextOptions<LivrariaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// Tabela de Categorias no banco de dados.
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
