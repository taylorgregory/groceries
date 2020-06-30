using System;
using System.Collections;
using System.Collections.Generic;
using GroceryManagement;

namespace GroceryConsoleTest
{
    class Program
    {
        public static FoodCollection foodCol = new FoodCollection();

        static void DisplayMainMenu()
        {
            // displays the main menu functionality

            Console.WriteLine("======= Main Menu =======");
            Console.WriteLine("1. My cupboard");
            Console.WriteLine("2. My recipes");
            Console.WriteLine("3. Meal planning");
            Console.WriteLine("0. Exit");
            Console.WriteLine("==========================");
            Console.WriteLine("Please make a selection (1-3 or 0 to exit)");
        }

        static void DisplayContentsOfCupboard()
        {
            
            // scan the food collection

            Console.WriteLine("The current contents of your pantry/fridge are: ");

        }

        static void DisplayCupboardMenu()
        {
            DisplayContentsOfCupboard();

            // return to main menu
            //
        }

        static void FunctionalMainMenu()
        {
            // function that handles user input on the main menu

            bool invalid = false; // error message not initially shown
            string mainMenuSelection;

            do
            {
                Console.Clear();

                if (invalid) // error message shown if value is invalid
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.WriteLine();
                }

                DisplayMainMenu();
                mainMenuSelection = Console.ReadLine();
                // TODO: tryparse here?? 

                switch (mainMenuSelection)
                {
                    case "1":
                        // TODO: add functionality
                        break;

                    case "2":
                        // TODO: add functionality
                        break;

                    case "3":
                        // TODO: add functionality
                        break;

                    case "0":
                        break; // exit

                    default:
                        invalid = true; // prompting an error message on the next do while loop
                        break;
                }
            } while (mainMenuSelection != "0");
        }

        static void CreateDummyFood()
        {
            // note: to be replaced/removed once i either read from csv OR use databases

            // -- adding umbrella term (this will be used in recipes)

            foodCol.PantryItems.Add("Peanut Butter", new Dictionary<string, Food>());

            Food peanutButter1 = new Food("Bega Crunchy Peanut Butter", 2580, 23.7, 51.3, 10.3, new Dictionary<string, ArrayList>());

            peanutButter1.Properties.Add("1970-01-01 00:00:01", new ArrayList {"help", 4, "please"});
            peanutButter1.Properties.Add("1970-01-01 00:00:02", new ArrayList { "helpp", 5, "pplease" });

            Food peanutButter2 = new Food("Bega Simply Nuts Crunchy Peanut Butter", 2550, 27.5, 49.0, 6.0, new Dictionary<string, ArrayList>());
            peanutButter2.Properties.Add("1970-01-01 00:00:03", new ArrayList { "helpo", 6, "oplease" });

            foodCol.PantryItems["Peanut Butter"].Add(peanutButter1.Name, peanutButter1);
            foodCol.PantryItems["Peanut Butter"].Add(peanutButter2.Name, peanutButter2);

            // -- adding specific item descriptions (kj etc)

            // adding cupboard contents (quantity, use by etc)
        }

        static void Main(string[] args)
        {
            CreateDummyFood();

            FunctionalMainMenu(); // program entry point
        }
    }
}
