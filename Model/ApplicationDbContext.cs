using Microsoft.EntityFrameworkCore;

namespace NowBuilding.Model
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
           optionsBuilder.UseSqlServer("Server=.;Database=NowBuilding;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().HasOne(o => o.Customer).WithMany(o => o.Orders).HasForeignKey(o => o.CustomerID);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.ProductID);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //   optionsBuilder.uses.UseSqlServer("Server=.;Database=NowBuilding;Trusted_Connection=True;TrustServerCertificate=True;")
        //}
    }
}
