using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using rice_store.forms;
using rice_store.data;
using rice_store.services;

namespace rice_store
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string connectionString = config.GetConnectionString("DefaultConnection")?? "";

            var services = new ServiceCollection()
                .AddApplicationServices(connectionString)
                .AddScoped<ProductManagementForm>()
                .AddScoped<ProductInformationForm>()
                .AddScoped<ContractManagementForm>()
                .AddScoped<PaymentManagementForm>()
                .AddScoped<ShortTermRentalManagementForm>()
                .AddScoped<CustomerManagementForm>()
                .AddScoped<SendNotificationForm>()
                .AddScoped<SystemSettingForm>()
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
