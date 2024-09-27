using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace RPGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<RPGameDbContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            using (var context = new RPGameDbContext(optionsBuilder.Options))
            {
                // Your database operations here
                context.Database.EnsureCreated();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new Login());
        }
    }
}