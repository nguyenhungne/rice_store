using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using rice_store.forms;
using rice_store.data;
using rice_store.services;
using rice_store.Tests;

namespace rice_store
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {

            // Run tests
            UtilsTests.RunAllTests();

            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string connectionString = config.GetConnectionString("DefaultConnection")?? "";

            var services = new ServiceCollection()
                .AddApplicationServices(connectionString)
                .AddScoped<ProductManagementForm>()
                .AddScoped<ProductInformationForm>()
                .AddScoped<SaleOrderManagementForm>()
                .AddScoped<SuplierManagementForm>()
                .AddScoped<CustomerManagementForm>()
                .AddScoped<UserManagementForm>()
                .AddScoped<UserInformationForm>()
                .AddScoped<SendNotificationForm>()
                .AddScoped<ReportForm>()
                .AddScoped<HomeForm>()
                .AddScoped<InventoryListForm>()
                .AddScoped<InventoryManagementForm>()
                .AddScoped<MainForm>()
                .AddScoped<LoginForm>()
                .BuildServiceProvider();

            ServiceProvider = services;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }
    }
}
