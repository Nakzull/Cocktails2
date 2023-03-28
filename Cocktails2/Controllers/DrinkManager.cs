using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocktails2.Models;
using Cocktails2.Repositories;

namespace Cocktails2.Controllers
{
    public class DrinkManager : IDrink
    {
        private readonly DatabaseManager databaseManager;

        public DrinkManager(DatabaseManager databaseManager)
        {
            this.databaseManager = databaseManager;
        }

        public Drink? GetDrink(string name)
        {
            return databaseManager.CreateContext().Drinks.Where(x => x.Name == name).FirstOrDefault();
        }


        public void GetDrinks()
        {

        }

        public void CreateDrink(Drink drink)
        {
            databaseManager.UseContext(context =>
            {
                context.Drinks.Add(drink);
            });
        }

        public void UpdateDrink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public void DeleteDrink()
        {
            throw new NotImplementedException();
        }
    }
}
