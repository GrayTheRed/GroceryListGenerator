using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListGenerator
{
    abstract class Recipe
    {
        public long Id { get; private set; }
        public string Name { get; set; }
        public RecipeMetadata Metadata { get; set; }
        
        public List<Ingredient> Ingredients { get; private set; }

        public Recipe(string name, long id)
        {
            Name = name;
            Id = id;
            Ingredients = new List<Ingredient>();
        }
        public Recipe(string name, long id, List<Ingredient> ingredients)
        {
            Name = name;
            Id = id;
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
