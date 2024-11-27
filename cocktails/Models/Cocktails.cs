namespace cocktails.Models
{
    public class Cocktail
    {
        public string Name { get; set; }

        public int PreparationTime { get; set; }

        public bool IsHot { get; set; }

        public List<string> Ingredients { get; set; }

        public decimal Price { get; set; }
    }
}
