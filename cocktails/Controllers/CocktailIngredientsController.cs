using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CocktailIngredientsController
    {
        Random rng = new Random();
        [HttpGet(Name = "GetCocktailIngredients")]
        public IEnumerable<CocktailIngredients> Get()
        {
            return new ListCocktailIngredients().List
                .OrderBy(_ => rng.Next())
                .Take(rng.Next(1, 6))
                .ToList();
        }
    }
}
