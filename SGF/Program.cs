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
            //Repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRevenueCategoryRepository, RevenueCategoryRepository>();
            services.AddScoped<IExpenseCategoryRepository, ExpenseCategoryRepository>();
            services.AddScoped<IRevenueRepository, RevenueRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            //Service
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRevenueCategoryService, RevenueCategoryService>();
            services.AddScoped<IExpenseCategoryService, ExpenseCategoryService>();
            services.AddScoped<IRevenueService, RevenueService>();
            services.AddScoped<IExpenseService, ExpenseService>();
            //Screen
            services.AddScoped<Login>();
            services.AddScoped<UserRegister>();
            services.AddScoped<RevenueRegister>();
            services.AddScoped<ExpenseRegister>();
            services.AddScoped<RevenueAdd>();
            services.AddScoped<ExpenseAdd>();
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