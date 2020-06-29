using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GroceryManagement
{
    public class FoodCollection
    {
        public Dictionary<string, Dictionary<string, Dictionary<string, Food>>> FoodCol { get; set; } 
        public Dictionary<string, Dictionary<string, Food>> BakeryItems { get; set; }
        public Dictionary<string, Dictionary<string, Food>> FruitVegItems { get; set; }
        public Dictionary<string, Dictionary<string, Food>> MeatDeliItems { get; set; }
        public Dictionary<string, Dictionary<string, Food>> DairyEggItems { get; set; }
        public Dictionary<string, Dictionary<string, Food>> PantryItems { get; set; }
        public Dictionary<string, Dictionary<string, Food>> FrozenItems { get; set; }

        public FoodCollection() {
            FoodCol.Add("Bakery", BakeryItems);
            FoodCol.Add("Fruit and Veg", FruitVegItems);
            FoodCol.Add("Meat and Deli", MeatDeliItems);
            FoodCol.Add("Dairy, Eggs etc.", DairyEggItems);
            FoodCol.Add("Pantry", PantryItems);
            FoodCol.Add("Frozen", FrozenItems);
        }
    }
}
