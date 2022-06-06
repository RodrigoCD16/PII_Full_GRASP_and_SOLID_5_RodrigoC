namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Interfaz creada para aplicar DIP, esta interfaz permitira que los printer ahora dependan de ella, en vez de Recipe,
    /// lo cual permite que podamos imprimir no solo objetos tipo Recipe, sino cualquier otro subtipo de IRecipeContent,
    /// a su vez podemos llevarnos los printer a otro programa siempre y cuando llevemos esta interfaz, otro beneficio es
    /// que los cambios en Recipe no afectan a los printer.
    /// </summary>
    public interface IRecipeContent
    {
        string GetTextToPrint();
    }
}