using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {       
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.CreateRecipe());
        }
    }
}