using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails2.Models
{
    public class Ingredient
    {
        //public Ingredient()
        //{
        //    Recipes = new HashSet<Recipe>();
            
        //}

        [Key]
        public int Id { get; private init; }
        public string Name { get; set; }
        //public virtual ICollection<Recipe> Recipes { get; set; }
        
    }
}
