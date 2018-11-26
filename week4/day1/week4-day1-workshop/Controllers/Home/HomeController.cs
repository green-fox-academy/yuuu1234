using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace week4day1workshop.Controllers
{
    public class HomeController
{
    [Route("/")]
    public string Index()
    {
        return "Hello from the controller";
    }
}
}
