using Cocktails2.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails2
{
    public class CocktailsContext : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientRecipe> IngredientRecipe { get; set; }

        public CocktailsContext(DbContextOptions<CocktailsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Recipe>();
            modelBuilder.Entity<Drink>();
            modelBuilder.Entity<Ingredient>();
            modelBuilder.Entity<IngredientRecipe>().HasKey(q =>
            new {
                q.IngredientId,
                q.RecipeId
            });
        }
    }
}
