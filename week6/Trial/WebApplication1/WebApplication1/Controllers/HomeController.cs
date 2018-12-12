using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext applicationContext;
        private readonly ISpaceshipService _spaceshipService;
        private readonly IPlanetService _planetService;
        public HomeController(ApplicationContext applicationContext, ISpaceshipService spaceshipService, IPlanetService planetService)
        {
            this.applicationContext = applicationContext;
            this._spaceshipService = spaceshipService;
            this._planetService = planetService;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
            ViewBag.spaceships = applicationContext.Spaceships;
            return View(applicationContext.planets.ToList());
        }

        [HttpPost("/movehere/{id}")]
        public IActionResult MoveToAnotherPlanet(long id)
        {
            _spaceshipService.ChangeTheLocation(id);
            ViewBag.spaceships = applicationContext.Spaceships;
            return View(nameof(Index), applicationContext.planets.ToList());
        }
        [HttpPost("/toplanet/{id}")]
        public IActionResult ToPlanet(long id)
        {
            if (_spaceshipService.GetUltilization() == 0)
            {
                ViewBag.spaceships = applicationContext.Spaceships;
                ViewBag.Utilization = 0;
                return View(nameof(Index), applicationContext.planets.ToList());
            }
            else
            {
                _spaceshipService.DecreaseUltilization();
                _planetService.IncreasePopulation(id);
                ViewBag.spaceships = applicationContext.Spaceships;
                return View(nameof(Index), applicationContext.planets.ToList());
            }
            
        }
        [HttpPost("/toship/{id}")]
        public IActionResult ToSpaceship(long id)
        {
            if (_spaceshipService.GetUltilization() ==60)
            {
                ViewBag.spaceships = applicationContext.Spaceships;
                ViewBag.Utilization = 60;
                return View(nameof(Index), applicationContext.planets.ToList());
            }
            else
            {
                _spaceshipService.IncreaseUltilization();
                _planetService.DecreasePopulation(id);
                ViewBag.spaceships = applicationContext.Spaceships;
                return View(nameof(Index), applicationContext.planets.ToList());
            }
            
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
