using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    [ApiController]
    //[Route("/api")]
    public class ApiController : ControllerBase
    {
        private readonly ApplicationContext applicationContext;
        private readonly ISpaceshipService _spaceshipService;
        private readonly IPlanetService _planetService;
        public ApiController(ApplicationContext applicationContext, ISpaceshipService spaceshipService, IPlanetService planetService)
        {
            this.applicationContext = applicationContext;
            this._spaceshipService = spaceshipService;
            this._planetService = planetService;
        }
        [HttpGet("api/top-planets")]
        public ActionResult<PlanetsList> TopPlanet()
        {
            var topPlanets = _planetService.TopPlanets();
            return new PlanetsList() { TopPlanet = topPlanets};
        }

    }
}