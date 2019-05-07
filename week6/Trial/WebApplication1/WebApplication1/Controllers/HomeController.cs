using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ISpaceshipService _spaceshipService;
        private readonly IPlanetService _planetService;
        public HomeController( ISpaceshipService spaceshipService, IPlanetService planetService)
        {
            this._spaceshipService = spaceshipService;
            this._planetService = planetService;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
       
            ViewBag.spaceships = _spaceshipService.GetSpaceship();
            return View(_planetService.GetAllPlanets());
        }

        [HttpPost("/movehere/{id}")]
        public IActionResult MoveHere(long id)
        {
            _spaceshipService.ChangeTheLocation(id);
            ViewBag.spaceships = _spaceshipService.GetSpaceship();
            return View(nameof(Index),_planetService.GetAllPlanets());
        }
        [HttpGet("/toplanet/{id}")]
        public IActionResult ToPlanet(long id)
        {
            if (_spaceshipService.AbleToMoveToPlanet())
            {
                _planetService.ToPlanet(id);
                ViewBag.move = true;
                ViewBag.spaceships = _spaceshipService.GetSpaceship();
                return View(nameof(Index),_planetService.GetAllPlanets());
            }
            else
            {
                ViewBag.move = false;
                ViewBag.spaceships = _spaceshipService.GetSpaceship();
                return View(nameof(Index),_planetService.GetAllPlanets());
            }
            

        }
        [HttpGet("/toship/{id}")]
        public IActionResult ToSpaceship(long id)
        {
            if (_spaceshipService.AbleToMoveToShip())
            {
                _spaceshipService.ToSpaceship();
                ViewBag.move = true;
                ViewBag.spaceships = _spaceshipService.GetSpaceship();
                return View(nameof(Index), _planetService.GetAllPlanets());
            }
            else
            {
                ViewBag.move = false;
                ViewBag.spaceships = _spaceshipService.GetSpaceship();
                return View(nameof(Index), _planetService.GetAllPlanets());
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
