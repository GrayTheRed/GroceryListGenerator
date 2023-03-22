using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListGenerator
{
    interface IRecipeMetadata
    {
        int Difficulty { get; set; }
        int HealthLevel { get; set; }
        double PrepTimeMinutes { get; set; }
        DateTime LastPurchased { get; set; }
        int NumberOfDishes { get; set; }
    }
}
