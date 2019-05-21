using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeProject.Models;
using RecipeProject.Services;

namespace RecipeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipeService _recipeService;
        public HomeController(IRecipeService recipeService)
        {
            this._recipeService = recipeService;
        }
        [HttpGet("/")]
        public async Task<IActionResult> Index()
        {
            var recipes = await _recipeService.GetAllRecipes();
            return View(recipes);
        }

        public async Task<IActionResult> CreateRecipe()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
