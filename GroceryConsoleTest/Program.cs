using System;
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



        static void Main(string[] args)
        {
            FunctionalMainMenu(); // program entry point
        }
    }
}
