using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using week4day1workshop.Models;

namespace week4day1workshop.Controllers.Web
{
    [Route("web")]
    public class WebController : Controller
    {
        [HttpGet("greeting")]
        public IActionResult Greeting(string content)
        {
            var greeting = new Greeting()
            {
                Content = content
            };

            return View(greeting);
        }

        [HttpGet("hellos")]
        public IActionResult GreetingInDifferentLanguages(string content)
        {
            var greeting = new Greeting()
            {
                Content = content
            };
            return View(greeting);
        }
    }
}
