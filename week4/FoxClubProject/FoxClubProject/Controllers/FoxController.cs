using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubProject.Interfaces;
using FoxClubProject.Services.Fox;
using Microsoft.AspNetCore.Mvc;
using FoxClubProject.Repository;
namespace FoxClubProject.Controllers
{
    public class FoxController : Controller
    {
        private  readonly IFoxService _foxService;
        
        public FoxController(IFoxService f)
        {
            this._foxService = f;
        }

        [HttpGet("info")]
        public IActionResult FoxInformation(string Name)
        {
            return View(_foxService.FoxInList(Name));

        }

        [HttpGet("/nutritionstore")]
        public IActionResult NutritionStore(string Name)
        {
            return View(_foxService.FoxInList(Name));
        }

        [HttpPost("/nutritionstore")]
        public IActionResult AfterNutrition(string Name, string Food, string Drink)
        {
            _foxService.ChangeFoodDrink(Name,Food,Drink);
            return RedirectToAction(nameof(FoxInformation), "Fox", _foxService.FoxInList(Name));
        }

        [HttpGet("/trickCenter")]
        public IActionResult TrickCenter(string Name)
        {
            return View(_foxService.FoxInList(Name));
        }

        [HttpPost("/trickCenter")]
        public IActionResult AfterLearned(string Name,string learned)
        {
            foreach (var theFox in AllFoxes.Foxlist)
            {
                if (theFox.Name == Name)
                {
                    theFox.Learn(learned);
                    return RedirectToAction(nameof(TrickCenter),"Fox",theFox);
                }
            }

            return View(nameof(TrickCenter));
        }

        [HttpGet("/actionHistory")]
        public IActionResult ActionHistory(string Name)
        {
            return View(_foxService.FoxInList(Name));
        }

    }
}