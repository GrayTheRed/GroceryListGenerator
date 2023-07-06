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

        public List<Recipe> GetRecipes(string id)
        {
            List<Recipe> results = new List<Recipe>();

            results = TestRecipes();
                        
            return results;
        }

        private List<Recipe> TestRecipes()
        {
            List<Recipe> results = new List<Recipe>();

            List<Ingredient> ingredientsA = new List<Ingredient>();
            Ingredient aFirst = new Ingredient("pasta", 3.5, "oz");
            Ingredient aSecond = new Ingredient("Sauce", 8.0, "oz");
            ingredientsA.Add(aFirst);
            ingredientsA.Add(aSecond);
            Recipe a = new Recipe("Spaghetti", ingredientsA);
            results.Add(a);

            return results;
        }
    }
}
