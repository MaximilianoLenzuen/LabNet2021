namespace EjercicioEntity.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using EjercicioEntity.Entities;

    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
            : base("name=NorthwindConnection")
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Employees2)
                .HasForeignKey(e => e.ReportsTo);

            modelBuilder.Entity<Orders>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Orders>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);
        }
    }
}
