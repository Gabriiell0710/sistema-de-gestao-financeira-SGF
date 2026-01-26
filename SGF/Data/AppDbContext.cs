using Microsoft.EntityFrameworkCore;
using SGF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGF.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<RevenueCategoryModel> RevenueCategories { get; set; }
        public DbSet<ExpenseCategoryModel> ExpenseCategories { get; set; }
        public DbSet<RevenueModel> Revenues { get; set; }
        public DbSet<ExpenseModel> Expenses { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string pastaApp = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "GestaoFinanceira"
            );

            if (!Directory.Exists( pastaApp))
            {
                Directory.CreateDirectory( pastaApp );
            }

            string caminhoDb =
            Path.Combine(pastaApp, "financeiro.db");

            optionsBuilder.UseSqlite($"Data Source={caminhoDb}");
        }
    }
}
