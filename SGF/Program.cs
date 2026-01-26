using Microsoft.Extensions.DependencyInjection;
using SGF.Data;
using SGF.Interfaces.IRepository;
using SGF.Interfaces.IService;
using SGF.Repositories;
using SGF.Services;
using SGF.Utils;

namespace SGF
{
    internal static class Program
    {
      
        [STAThread]
        static void Main()
        {
           
        var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRevenueCategoryRepository, RevenueCategoryRepository>();
            services.AddScoped<IRevenueCategoryService, RevenueCategoryService>();
            services.AddScoped<Login>();
            services.AddScoped<UserRegister>();
            services.AddScoped<RevenueRegister>();
            services.AddSingleton<UserSession>();

            var provider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }

            Application.Run(provider.GetRequiredService<Login>());
            
        }
    }
}