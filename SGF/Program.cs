using SGF.Data;

namespace SGF
{
    internal static class Program
    {
      
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();

            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
            }

                Application.Run(new Login());
        }
    }
}