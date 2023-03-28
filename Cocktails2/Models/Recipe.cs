using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails2.Models
{
    public class Recipe
    {
        //public Recipe()
        //{
        //    Ingredients = new HashSet<Ingredient>();
        //}
        [ForeignKey("Drink")]
        public int StudentAddressId { get; set; }

        [Key]
        public int RecipeId { get; private init; }
        public virtual Drink Drink { get; set; }
        //public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
