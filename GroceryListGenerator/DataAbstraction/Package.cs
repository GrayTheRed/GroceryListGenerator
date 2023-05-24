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

        public static List<Meal> GetRecipes(string id)
        {
            List<Meal> results = new List<Meal>();

            results = TestRecipes();
                        
            return results;
        }

<<<<<<< HEAD
        //public static string GetRecipesCosmos(string id)
        //{
        //    string queryText = "SELECT * FROM recipes WHERE "
        //}

        private static List<Recipe> TestRecipes()
=======
        private static List<Meal> TestRecipes()
>>>>>>> main
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
