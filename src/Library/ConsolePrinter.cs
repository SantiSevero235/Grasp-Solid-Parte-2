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
    } /*Para hacer se tuvo en cuenta el patrón SRP, todas las responsabilidades de las clases están asociadas 
     solamente a esta funcionalidad de la aplicación, todos los métodos y atributos están alineados 
     con esta responsabilidad, esta se convierte en la única responsabilidad. */
}

    

