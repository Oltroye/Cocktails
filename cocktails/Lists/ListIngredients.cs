namespace WebApplication4
{
    public class ListIngredients
    {
        public Ingredients[] List => new[]
        {
            new Ingredients
            {
                Name = "Rhum Blanc"
            },
            new Ingredients
            {
                Name = "Jus de citron vert"
            },
            new Ingredients
            {
                Name = "Feuilles de menthe"
            },
            new Ingredients
            {
                Name = "Sucre"
            },
            new Ingredients
            {
                Name = "Eau gazeuse"
            },
        };
    }
}
