using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cocktails2.Models;

namespace Cocktails2.Repositories
{
    internal interface IDrink
    {
        public Drink? GetDrink(string name);

        public void GetDrinks();

        public void CreateDrink(Drink drink);

        public void UpdateDrink(Drink drink);

        public void DeleteDrink();
    }
}