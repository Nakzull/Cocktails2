using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails2.Models
{
    public class IngredientRecipe
    {
        [Key, Column(Order = 0)]
        public int RecipeId { get; set; }
        [Key, Column(Order = 1)]
        public int IngredientId { get; set; }

        public virtual Recipe Recipe { get; set; }
        public virtual Ingredient Ingredient { get; set; }

        public int Amount { get; set; }
    }
}
