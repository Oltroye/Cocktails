using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cocktails.Models;
using System.Diagnostics.Metrics;
using System;

namespace cocktails.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CocktailsController : ControllerBase
    {
        [HttpGet(Name = "GetCocktail")]
        public IEnumerable<Cocktail> Get()
        {
            var cocktails = new List<Cocktail>
            {
                new Cocktail
                {
                    Name = "Mojito",
                    PreparationTime = 5,
                    IsHot = false,
                    Ingredients = new List<string> { "Rhum", "Menthe", "Sucre", "Eau gazeuse", "Citron vert" },
                    Price = 8.5m
                },
                new Cocktail
                {
                    Name = "Irish Coffee",
                    PreparationTime = 10,
                    IsHot = true,
                    Ingredients = new List<string> { "Café", "Whisky", "Crème", "Sucre" },
                    Price = 7.5m
                }
            };
            
            return cocktails;
        }
    }

}











