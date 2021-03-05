using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Model;

namespace CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(
                entity =>
                {
                    entity.HasMany(s => s.Enderecos);
                    entity.HasIndex(u => u.Email).IsUnique();
                });
            //modelBuilder.Entity<Usuario>(
            //    e =>
            //    {
            //        e.HasKey(k => new { k.Nome, k.Email, k.Celular, k.DataNascimento });
            //    });
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
