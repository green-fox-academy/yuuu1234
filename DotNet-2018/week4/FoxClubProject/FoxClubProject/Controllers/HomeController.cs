using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubProject.Services.Fox;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FoxClubProject.Controllers
{

    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index(string Name)
        {
            if (Name == null)
            {
                return View(nameof(Login));
            }
            return View((Object)Name);
        }

        [HttpGet("/login")]
        public IActionResult Login(String Name)
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult ShowName(String Name)
        {
            //Anonymous object
            return RedirectToAction(nameof(Index), "Home", new { Name = Name });
        }

    }
}