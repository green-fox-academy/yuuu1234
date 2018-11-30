using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace MyFirstWebApplication.Controllers
{
    //actions
    public class HomeController: Controller
    {

        [Route("/")]
        public IActionResult Index()
        {
            //return View();
            return Redirect("/name/2");
        }
        [Route("/name")]
        //Route+Get
        //[HttpGet("/name")]
        public string Name([FromQuery] string name)
        {
            return $"Hi {name}";
        }

        [HttpGet("/name/{id}")]
        public string ID([FromRoute] long id)
        {
            return $"your id is {id}";
        }
    }
}
