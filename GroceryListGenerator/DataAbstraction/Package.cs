using GroceryListGenerator;
using Microsoft.Azure.Cosmos;
using System.Collections.Generic;


namespace DataAbstraction
{
    public static class Package
    {
        public static void SaveRecipes(List<Recipe> recipes)
        {

        }

        public static List<Recipe> GetRecipes(string id)
        {
            List<Recipe> results = new List<Recipe>();

            results = TestRecipes();
                        
            return results;
        }

        //public static string GetRecipesCosmos(string id)
        //{
        //    string queryText = "SELECT * FROM recipes WHERE "
        //}

        private static List<Recipe> TestRecipes()
        {
            List<Recipe> results = new List<Recipe>();

            List<Ingredient> ingredientsA = new List<Ingredient>();
            Ingredient aFirst = new Ingredient("pasta", 3.5, "oz");
            Ingredient aSecond = new Ingredient("Sauce", 8.0, "oz");
            ingredientsA.Add(aFirst);
            ingredientsA.Add(aSecond);
            Meal a = new Meal("Spaghetti", ingredientsA);
            results.Add(a);

            Ingredient bFirst = new Ingredient("Chips", 1.0, "bag");
            Snack b = new Snack("Chips", new List<Ingredient> {bFirst});
            results.Add(b);

            return results;
        }
    }
}
