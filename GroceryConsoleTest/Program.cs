using System;
using GroceryManagement;

namespace GroceryConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodCollection foodCol = new FoodCollection();

            foodCol.FruitVegItems.Add("help", new Food("help"));

        }
    }
}
