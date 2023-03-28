using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails2.Controllers
{
    public class DatabaseManager
    {
        private string connectionString { get; set; }

        public DatabaseManager()
        {
            connectionString = "Server=ZBC-E-CH-SKP047\\MSSQLSERVER01;Database=Cocktail;TrustServerCertificate=True;Trusted_Connection=True";
        }

        public CocktailsContext CreateContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CocktailsContext>().UseSqlServer(connectionString);

            return new CocktailsContext(optionsBuilder.Options);
        }

        public void UseContext(Action<CocktailsContext> action)
        {
            var context = CreateContext();

            action(context);

            context.SaveChanges();
        }
    }
}
