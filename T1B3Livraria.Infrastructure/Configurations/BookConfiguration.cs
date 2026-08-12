using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1B3Livraria.Domain.Entities;

namespace T1B3Livraria.Infrastructure.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            // Define a chave primária
            builder.HasKey(b => b.Id);

            // Configurações dos campos
            builder.Property(b => b.Title)
                .IsRequired()           
                .HasMaxLength(200);     

            builder.Property(b => b.Autor)
                .HasMaxLength(200);

            builder.Property(b => b.Editora)
                .HasMaxLength(500);

            builder.HasOne(g => g.Category)       
                .WithMany(c => c.Books)           
                .HasForeignKey(g => g.CategoryId) 
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
