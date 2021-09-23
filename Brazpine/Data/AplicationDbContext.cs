using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brazpine.Models;
using Microsoft.EntityFrameworkCore;

namespace Brazpine.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext (DbContextOptions<AplicationDbContext> options) : base (options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("Produto");
        }
    }
}
