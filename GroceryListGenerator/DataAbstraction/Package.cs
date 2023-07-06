using GroceryListGenerator;
using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Azure.Cosmos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAbstraction
{
    public class Package
    {
        //TODO: Find out why config manager isn't working properly
        //private static readonly string EndpointUri = ConfigurationManager.AppSettings["EndpointUri"];
        //private static readonly string PrimaryKey = ConfigurationManager.AppSettings["PrimaryKey"];
        private static readonly string EndpointUri = @"https://grocerylistgenerator.documents.azure.com:443/";
        private static readonly string PrimaryKey = @"trrxRJ5ByVmEWliRR5EJzNSiSAvIZiOKy8iy7cWZ2TVI6mgL54TpWCKRXmihxbOvYTu9RzJQTuU8ACDbEDkK8g==";
        private CosmosClient cosmosClient;
        private string databaseId = "GroceryList";
        private string containerId = "Recipes";
        private Database database;
        private Container container;
        private List<Meal> meals;

        public Package()
        {
            string whatevs = ConfigurationManager.AppSettings["EndpointUri"];
        }

        public void SaveRecipe(List<Meal> recipes)
        {
            Task.WaitAll(SaveRecipeCosmos(recipes));
        }

        public async Task SaveRecipeCosmos(List<Meal> recipes)
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
