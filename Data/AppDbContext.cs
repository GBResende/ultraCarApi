using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using UltracarAPI.Models;

namespace UltracarAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockMovement>()
                .HasKey(sm => sm.Id);

            modelBuilder.Entity<Budget>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Part>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<StockMovement>()
                .HasOne(sm => sm.Part)
                .WithMany(p => p.StockMovements)
                .HasForeignKey(sm => sm.PartId);

            modelBuilder.Entity<StockMovement>()
                .HasOne(sm => sm.Budget)
                .WithMany(b => b.StockMovements)
                .HasForeignKey(sm => sm.BudgetId);
        }

    }
}
