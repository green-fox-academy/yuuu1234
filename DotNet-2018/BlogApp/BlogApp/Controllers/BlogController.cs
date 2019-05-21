using System.ComponentModel.DataAnnotations;
using BlogApp.Models;
using BlogApp.Services;
using BlogApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService blogService;
        private readonly ICategoryService categoryService;

        public BlogController(IBlogService blogService, ICategoryService categoryService)
        {
            this.blogService = blogService;
            this.categoryService = categoryService;
        }

        [HttpGet("form")]
        public IActionResult AddForm()
        {
            var categories = categoryService.FindAll();

            // ViewBag.Categories = 
            // ViewData["Categories"] = 

            return View(new CreateEditBlogPostViewModel
            {
                Categories = categoryService.FindAll()
            });
        }

        [HttpGet("edit/{id}")]
        public IActionResult EditForm([Required] long id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            BlogPost blogPost = blogService.FindById(id);

            if (blogPost == null)
            {
                return NotFound();
            }

            return View(new CreateEditBlogPostViewModel
            {
                BlogPost = blogPost,
                Categories = categoryService.FindAll()
            });
        }

        [HttpPost("create")]
        public IActionResult Create(BlogPost blogPost)
        {
            if (ModelState.IsValid)
            {
                blogService.Create(blogPost);

                return RedirectToAction("Index", "Home");
            }

            return View(nameof(AddForm));
        }

        [HttpPost("update/{id}")]
        public IActionResult Update([Required] long id, BlogPost blogPost, string action)
        {
            if (action == "delete")
            {
                blogService.Delete(blogPost);
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(nameof(EditForm));
            }

            blogService.Update(blogPost);
            return RedirectToAction("Index", "Home");
        }
    }
}