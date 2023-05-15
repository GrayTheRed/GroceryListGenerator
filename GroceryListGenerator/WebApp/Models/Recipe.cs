using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Recipe
    {
        public long Id { get; set; }
        public string Name { get; set; }
        //public RecipeMetadata Metadata { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Recipe()
        {

        }
    }
}
