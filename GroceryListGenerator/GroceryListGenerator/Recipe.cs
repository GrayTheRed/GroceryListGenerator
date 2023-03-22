using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListGenerator
{
    abstract class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public RecipeMetadata Metadata { get; set; }
        
        public List<Ingredient> Ingredients { get; set; }

        public Recipe(string name, List<Ingredient> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void RemoveIngredient(Ingredient ingredient)
        {
            Ingredients.Remove(ingredient);
        }
    }
}
