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
        DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string PastaApp = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "GestaoFinanceira"
            );

            string CaminhoDb =
            Path.Combine(PastaApp, "financeiro.db");

            optionsBuilder.UseSqlite( CaminhoDb );
        }
    }
}
