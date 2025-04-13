using Microsoft.Extensions.DependencyInjection;
using rice_store.repositories;
using rice_store.repositories.interfaces;
using rice_store.services;
using rice_store.data;
using Microsoft.EntityFrameworkCore;

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

            // Register Services
            services.AddScoped<AuthenticationService>();
            services.AddScoped<ProductService>();
            services.AddScoped<CategoryService>();

            return services;
        }
    }
}
