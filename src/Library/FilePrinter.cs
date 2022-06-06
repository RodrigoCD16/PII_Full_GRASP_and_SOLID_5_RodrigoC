using System.IO;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Clase modificada para aplicar DIP, ahora el método PrintRecipe recibe como parámetro un tipo IRecipeContent
    /// lo que causa que esta clase ahora dependa de la interfaz IRecipeContent, en vez de la clase Recipe.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            File.WriteAllText("Recipe.txt", recipeContent.GetTextToPrint());
        }
    }
}