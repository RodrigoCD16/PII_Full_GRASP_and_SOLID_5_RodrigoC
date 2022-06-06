
namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Interfaz modificada para aplicar DIP, ahora el método PrintRecipe recibe como parámetro un tipo IRecipeContent
    /// lo que causa que esta interfaz ahora dependa de la interfaz IRecipeContent, en vez de la clase Recipe.
    /// </summary>
    public interface IPrinter
    {
         void PrintRecipe(IRecipeContent recipeContent);
    }
}