using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListGenerator
{
    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public MeasurementType Measurement { get; set; }

        public Ingredient(string name, double quantity, MeasurementType measurement)
        {
            Name = name;
            Quantity = quantity;
            Measurement = measurement;
        }

        public enum MeasurementType
        {
            Pound,
            Ounce,
            Tablespoon,
            Teaspoon,
            Gram,
            Cup,
            Pinch
        }
    }
}
