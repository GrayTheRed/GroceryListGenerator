using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListGenerator
{
    public class Meal : Recipe
    {
        public Meal(string name, List<Ingredient> ingredients) : base(name, ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}
