using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using week4Day3Workshop.Interfaces;
using week4Day3Workshop.Models;
using week4Day3Workshop.Services;
using week4Day3Workshop.Services.Student;

namespace week4Day3Workshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly UtilityService utilityService;
        private readonly StudentService studentService;
        public HomeController(UtilityService utility, StudentService student)
        {
            this.studentService = student;
            this.utilityService = utility;
        }

        [HttpGet("home")]
        public IActionResult Index()
        {
            return View(utilityService);
        }

        [HttpGet("/useful")]
        public IActionResult Useful()
        {
            
            return View(utilityService);
        }

        [HttpGet("/useful/colored")]
        public IActionResult RandomBackground()
        {
            return View(utilityService);
        }

        [HttpGet("/useful/email")]
        public IActionResult ValidateEmail(string email)
        {
            return View((object)email);
        }

        [HttpGet("caesar")]
        public IActionResult CaesarCoding(string text, int number)
        {
            CaesarCode caesar = new CaesarCode();

            return View((object)caesar.Caesar(text, number));
        }

        [HttpGet("/gfa")]
        public IActionResult GreenFox()
        {
            return View();
        }

        [HttpGet("/gfa/list")]
        public IActionResult UnorderedList()
        {

            return View();
        }

        [HttpGet("gfa/add")]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost("gfa/add")]
        public IActionResult AddPerson(string Name)
        {
            studentService.Save(Name);
            return View(nameof(AddStudent));
        }
    }

}