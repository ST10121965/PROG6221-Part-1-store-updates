using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask1
{
    public class Recipe
    {
        //methods -- menu, display, lists, scaled
        //global declarations - List
        private static List<Ingredients> ingredients = new List<Ingredients>();
        private static List<Ingredients> stepsRecipe = new List<Ingredients>();
        private static List<Ingredients> scaledQnty = new List<Ingredients>();

        //global variables
        public static int ingredientNum = 0;
        public static int stepsNum = 0;
        public bool scale = false;
        public static string recipeName = "";

        //method 1 - main menu
        public void mainMenu()
        {
            //optional -- console.color // LOADING 
            Console.WriteLine("1: Add a new recipe\n" +
                "2: Display recipe \n" +
                "3: Scale recipe \n" +
                "4: Clear all \n" +
                "5: Exit ");
            //LOGIC -- user selects
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    //check for existing entries
                    if (ingredientNum > 0)
                    {
                        Console.WriteLine("Recipe already stored - reset first");
                        mainMenu();
                    }
                    else
                    {
                        //lets you continue to capture
                        recipePrompt();
                    }
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    //clear all the lists t or use a method

                    break;

                case "5":
                    break;
                default:
                    Console.WriteLine("Enter a valid option - 1 - 5");
                    mainMenu();
                    break;
            }//switch
        }//method 

        //method to add a recipe
        public void recipePrompt()
        {
            Console.WriteLine("Enter recipe name >>>");
            recipeName = Console.ReadLine();

            Console.WriteLine("How many ingredients ?");
            //valid input  --> word or numeric
            bool temp = false;
            while (temp == false)
            {
                try
                {
                    ingredientNum = Int32.Parse(Console.ReadLine());
                    if (ingredientNum == 0)
                    {
                        Console.WriteLine("Enter a valid number");
                    }
                    else
                    {
                        temp = true;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Enter a valid number");
                }//try catch ends
            }//while ends
            for (int i = 0; i < ingredientNum; i++)
            {
                Console.WriteLine("Enter the name of the ingred {0}: ", i + 1);
                string name = Console.ReadLine();
                Console.WriteLine("Enter the qnty of the ingred {0}: ", i + 1);
                Double ingredQuant = 0;
                temp = false;

                while (temp == false)
                {
                    try
                    {
                        ingredQuant = Double.Parse(Console.ReadLine());
                        temp = true;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Enter a valid option");
                    }//try catch ends
                }// while ends
                //handling the units of measurement
                Console.WriteLine("Select the unit of measurement: \n" +
                    "1: cups \n" +
                    "2: L \n" +
                    "3: ml \n" +
                    "4: Teaspoon \n" +
                    "5: Tablespoon");
                // to save the input 
                string unit = "";
                //use the 5 options
                string input = Console.ReadLine();
                temp = false;
                while (temp == false)
                {
                    switch (input)
                    {
                        case "1":
                            unit = "cups";
                            temp = true;
                            break;
                        case "2":
                            unit = "L";
                            temp = true;
                            break;
                        case "3":
                            unit = "ml";
                            temp = true;
                            break;
                        case "4":
                            unit = "tsp";
                            temp = true;
                            break;
                        case "5":
                            unit = "tblspn";
                            temp = true;
                            break;

                        default:
                            Console.WriteLine("Enter a valid option");
                            temp = false;
                            input = Console.ReadLine();
                            break;
                    }//switch ends
                }//while ends

                // add --> Lists 
                //if the user chooses to scale
                scaledQnty.Add(new Ingredients
                {
                    scaledName = name,
                    scaledQnty = ingredQuant,
                    scaledUnit = unit
                });

                //now add the ingredients into the list
                ingredients.Add(new Ingredients
                {
                    ingredName = name,
                    ingredQnty = ingredQuant,
                    ingredUnit = unit
                });

            }//for loop
        }//method


        //methods
        //clearAll();
        // scaling
        //display all 
        // exit 
    }
}
