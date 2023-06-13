using GroceryListGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAbstraction
{
    public class Package
    {
        public void SaveRecipes(List<Recipe> recipes)
        {

        }

        public List<Meal> GetRecipes(string id)
        {
            List<Meal> results = new List<Meal>();

            results = TestRecipes();
                        
            return results;
        }

        private List<Meal> TestRecipes()
        {
            List<Meal> results = new List<Meal>();

            List<Ingredient> ingredientsA = new List<Ingredient>();
            Ingredient aFirst = new Ingredient("pasta", 3.5, "oz");
            Ingredient aSecond = new Ingredient("Sauce", 8.0, "oz");
            ingredientsA.Add(aFirst);
            ingredientsA.Add(aSecond);
            Meal a = new Meal("Spaghetti", ingredientsA);
            results.Add(a);

            return results;
        }
    }
}
