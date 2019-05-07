using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;
using BlogApp.Services;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogService blogService;
        private readonly ICategoryService categoryService;

        public HomeController(IBlogService blogService, ICategoryService categoryService)
        {
            this.blogService = blogService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var blogPosts = blogService.GetAll();
            return View(blogPosts);
        }

        [HttpGet("by-category/{id}")]
        public IActionResult ByCategory(long id)
        {
            Category category = categoryService.FindById(id);

            if (category == null)
            {
                return BadRequest();
            }

            return View(category);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
