using System;
using System.Collections;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID.Library
{   
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipe());
        }
    }
}

    

