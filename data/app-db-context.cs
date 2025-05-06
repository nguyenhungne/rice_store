using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using rice_store.models;
using rice_store.services;

using System.IO;

namespace rice_store.data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public DbSet<SalesOrder> SalesOrder { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public DbSet<Supplier> Supplier { get; set; }

        private readonly IConfiguration _configuration;

        // Constructor for Dependency Injection
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        // Parameterless constructor for design-time migration
        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

                if (!File.Exists(configPath))
                {
                    throw new FileNotFoundException($"Configuration file not found: {configPath}");
                }

                var config = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // global query filter for soft delete
            modelBuilder.Entity<Customer>()
                .HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Product>()
                .HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Supplier>()
                .HasQueryFilter(s => !s.IsDeleted);
            modelBuilder.Entity<Category>()
                .HasQueryFilter(c => !c.IsDeleted);

            // Seed data for Category
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Gạo Tám Thơm", IsDeleted = false },
                new Category { Id = 2, Name = "Gạo ST25", IsDeleted = false },
                new Category { Id = 3, Name = "Gạo Lứt", IsDeleted = false },
                new Category { Id = 4, Name = "Gạo Nếp", IsDeleted = false },
                new Category { Id = 5, Name = "Gạo Tài Nguyên", IsDeleted = false },
                new Category { Id = 6, Name = "Gạo Hương Lài", IsDeleted = false },
                new Category { Id = 7, Name = "Gạo Nhật", IsDeleted = false },
                new Category { Id = 8, Name = "Gạo Tấm", IsDeleted = false },
                new Category { Id = 9, Name = "Gạo Hữu Cơ", IsDeleted = false }
            );

            // Seed data for Inventory
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { Id = 1, name = "Quận 7, Tp. Hồ Chí Minh" },
                new Inventory { Id = 2, name = "Quận 10, Tp. Hồ Chí Minh" },
                new Inventory { Id = 3, name = "Quận Thủ Đức, Tp. Hồ Chí Minh" }
            );

            // Seed admin user
            string hashedPassword = HashingService.HashPassword("Password123");
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = hashedPassword,
                    Role = "admin",
                    Name = "Admin",
                    Phone = "123456789",
                    Email = "admin@gmail.com",
                    Salary = 10000000,
                    IsDeleted = false
                }
            );
        }
    }
}
