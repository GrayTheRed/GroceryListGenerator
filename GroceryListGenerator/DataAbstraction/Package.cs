using GroceryListGenerator;
using Microsoft.Azure.Cosmos;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace DataAbstraction
{
    public class Package
    {
        private readonly string EndpointUri = ConfigurationManager.AppSettings["EndPointUri"];
        private readonly string PrimaryKey = ConfigurationManager.AppSettings["PrimaryKey"];
        //private  CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey, new CosmosClientOptions() { ApplicationName = "GroceryListGenerator" });

        public void SaveRecipes(List<Recipe> recipes)
        {

        }

        public List<Meal> GetRecipes(string id)
        {
            List<Meal> results = new List<Meal>();
            //results = await GetRecipesCosmos(id);
            results = TestRecipes();
                        
            return results;
        }

        //public async Task GetRecipesCosmos(string id)
        //{
        //    List<Meal> results = new List<Meal>();
        //    string endpointUri = ConfigurationManager.AppSettings["EndPointUri"];
        //    string primaryKey = ConfigurationManager.AppSettings["PrimaryKey"];
        //    //var db = cosmosClient.GetDatabase("GroceryList");
        //    //var container = cosmosClient.GetContainer(db.Id, "Recipes");
        //    string query = ($"SELECT * FROM c WHERE c.user =\'{id}\'");
        //    QueryDefinition queryDef = new QueryDefinition(query);
        //    FeedIterator<Meal> queryResultSetIterator = container.GetItemQueryIterator<Meal>(queryDef);

        //    while (queryResultSetIterator.HasMoreResults)
        //    {
        //        FeedResponse<Meal> currentResultSet = await queryResultSetIterator.ReadNextAsync();
        //        foreach(Meal r in currentResultSet)
        //        {
        //            results.Add(r);
        //        }
        //    }
        //}

        private  List<Meal> TestRecipes()
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
