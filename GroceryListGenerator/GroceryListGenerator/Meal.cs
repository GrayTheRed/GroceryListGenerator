using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListGenerator
{
    class Meal
    {
        public string Name { get; set; }
        public DifficultyCategory Difficulty { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }

        public Meal(string name, DifficultyCategory difficulty)
        {
            Name = name;
            Difficulty = difficulty;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void RemoveIngredient (Ingredient ingredient)
        {
            Ingredients.Remove(ingredient);
        }

        public void SetDifficulty(DifficultyCategory difficulty)
        {
            Difficulty = difficulty;
        }

        public enum DifficultyCategory
        {
            Easy,
            Medium,
            Hard
        }
    }
}
