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

        public List<Meal> GetRecipes(string id)
        {
            Task.WaitAll(GetCosmosData(id));
            return meals;
        }

        public async Task GetCosmosData(string id)
        {
            //string EndpointUri = ConfigurationManager.AppSettings["EndpointUri"];
            //string PrimaryKey = ConfigurationManager.AppSettings["PrimaryKey"];
            cosmosClient = new CosmosClient(EndpointUri, PrimaryKey, new CosmosClientOptions() { ApplicationName = "GroceryListGenerator" });
            container = cosmosClient.GetContainer(databaseId, containerId);
            database = cosmosClient.GetDatabase(databaseId);
            
            var queryText = $"SELECT * FROM c where c.user = \"{id}\"";
            QueryDefinition queryDefinition = new QueryDefinition(queryText);
            FeedIterator<Meal> queryResultSetIterator = container.GetItemQueryIterator<Meal>(queryDefinition);
            
            meals = new List<Meal>();

            while (queryResultSetIterator.HasMoreResults)
            {
                FeedResponse<Meal> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                foreach(Meal meal in currentResultSet)
                {
                    meals.Add(meal);
                }
            }
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
