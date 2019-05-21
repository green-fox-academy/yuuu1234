using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using week4day1workshop.Models;

namespace week4day1workshop.Controllers.Rest
{
    [Route("api")]
    public class RestController
    {
        private readonly long id;
        [HttpGet("hello")]
        public string Hello()
        {
            return "hello yu";
        }
  
        [HttpGet("greeting")]
        
        public Greeting Greet(string content)
        {
            Greeting greet = new Greeting();
            greet.Content = content;
            return greet;
        }
    }
}
