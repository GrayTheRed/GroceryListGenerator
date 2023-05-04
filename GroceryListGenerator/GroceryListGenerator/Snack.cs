using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListGenerator
{
    public class Snack : Recipe
    {
        public Snack(string name, List<Ingredient> ingredients) : base (name, ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}
