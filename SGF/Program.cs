using Microsoft.Extensions.DependencyInjection;
using SGF.Data;
using SGF.Interfaces.IRepository;
using SGF.Interfaces.IService;
using SGF.Repositories;
using SGF.Services;

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
            services.AddScoped<Login>();
            services.AddScoped<UserRegister>();

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