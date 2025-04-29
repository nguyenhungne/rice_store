using Microsoft.Extensions.DependencyInjection;
using rice_store.repositories;
using rice_store.repositories.interfaces;
using rice_store.services;
using rice_store.data;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace rice_store
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, string connectionString)
        {
            // Register DbContext
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

            // Register Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IInventoryRepository, InventoryRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();
            services.AddScoped<IPurchaseOrderDetailRepository, PurchaseOrderDetailRepository>();
            services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
            services.AddScoped<ISalesOrderDetailRepository, SalesOrderDetailRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ISalesOrderRepository, SalesOrderRepository>();

            // Register Services
            services.AddScoped<AuthenticationService>();
            services.AddScoped<ProductService>();
            services.AddScoped<CategoryService>();
            services.AddScoped<InventoryService>();
            services.AddScoped<WarehouseService>();
            services.AddScoped<PurchaseOrderDetailService>();
            services.AddScoped<SalesOrderDetailService>();
            services.AddScoped<SupplierService>();
            services.AddScoped<SalesOrderService>();
            services.AddScoped<SmtpClient>();
            services.AddScoped<IEmailSender,EmailSender>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<CustomerService>();





            return services;
        }
    }
}
