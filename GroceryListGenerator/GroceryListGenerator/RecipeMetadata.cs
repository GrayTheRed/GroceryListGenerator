using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListGenerator
{
    public class RecipeMetadata : IRecipeMetadata
    {
        public int Difficulty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double PrepTimeMinutes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime LastPurchased { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfDishes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HealthLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
