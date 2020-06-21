using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace przykladoweKolokwium.Models
{
    public class SweetShopContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        public SweetShopContext()
        {

        }
        public SweetShopContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>(opt =>
            {
                opt.HasKey(p => p.IdClient);
                opt.Property(p => p.IdClient)
                .ValueGeneratedOnAdd();

                opt.Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsRequired();

                opt.Property(p => p.Surname)
               .HasMaxLength(60)
               .IsRequired();

                opt.HasMany(p => p.Orders)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.IdClient);
            });

            modelBuilder.Entity<Employee>(opt =>
            {
                opt.HasKey(p => p.IdEmployee);
                opt.Property(p => p.IdEmployee)
                .ValueGeneratedOnAdd();

                opt.Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsRequired();

                opt.Property(p => p.Surname)
               .HasMaxLength(60)
               .IsRequired();

                opt.HasMany(p => p.Orders)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.IdEmployee);
            });

            modelBuilder.Entity<Order>(opt =>
            {
                opt.HasKey(p => p.IdOrder);
                opt.Property(p => p.IdOrder)
                .ValueGeneratedOnAdd();
               
                opt.Property(p => p.Notes)
                .HasMaxLength(300);

            });

            modelBuilder.Entity<ProductOrder>(opt =>
            {
                opt.HasKey(a => new { a.IdProduct, a.IdOrder });

                opt.Property(p => p.Notes)
               .HasMaxLength(60);

                opt.HasOne(p => p.Product)
                .WithMany(p => p.ProductOrders)
                .HasForeignKey(p => p.IdProduct);

                opt.HasOne(p => p.Order)
                .WithMany(p => p.ProductOrders)
                .HasForeignKey(p => p.IdOrder);
            });

            modelBuilder.Entity<Product>(opt =>
            {
                opt.HasKey(p => p.IdProduct);
                opt.Property(p => p.IdProduct)
                .ValueGeneratedOnAdd();

                opt.Property(p => p.Name)
                .HasMaxLength(200)
                .IsRequired();

                opt.Property(p => p.Type)
               .HasMaxLength(40)
               .IsRequired();
            });


            modelBuilder.Entity<Client>().HasData(new Client
            {
                IdClient = 1,
                FirstName = "Anna",
                Surname = "Kowalska"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                IdEmployee = 1,
                FirstName = "Tomasz",
                Surname = "Kot"
            });

            modelBuilder.Entity<Order>().HasData(new Order
            {
                IdOrder = 1,
                OrderDate = DateTime.Now,
                RealizationDate = DateTime.Now.AddDays(2),
                Notes = "Tort bezowy",
                IdClient = 1,
                IdEmployee = 1,
            });
           
            modelBuilder.Entity<Product>().HasData(new Product
            {
                IdProduct = 1,
                Name = "Ptys",
                Price = 4,
                Type = "Maly wyrob"
            });

           
                modelBuilder.Entity<ProductOrder>().HasData(new ProductOrder
            {   
                IdProduct = 1,
                IdOrder = 1,
                Quantity = 5,
                Notes = "pakowac osobno"
            });
            /*modelBuilder.Entity<ProductOrder>((builder) =>
            {
                builder.HasKey(a => new { a.IdProduct, a.IdOrder });

            });*/
        }
    }
}
