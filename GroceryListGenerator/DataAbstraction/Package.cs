using GroceryListGenerator;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAbstraction
{
    public class Package
    {
        private static readonly string EndpointUri = ConfigurationManager.AppSettings["EndpointUri"];
        private static readonly string PrimaryKey = ConfigurationManager.AppSettings["PrimaryKey"];
        
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
