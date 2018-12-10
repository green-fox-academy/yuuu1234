using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using PagedList;
using RedditProject.Interfaces;
using RedditProject.Models;
using RedditProject.Services;

namespace RedditProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext applicationContext;
        private readonly IPostService postService;
        private readonly IUserService userService;
        private static bool hasLoggedIn;
        private static string currentUser;
        private static int voteCount;
        private static long voteId;
        public HomeController(ApplicationContext applicationContext, IPostService postService, IUserService userService)
        {
            this.applicationContext = applicationContext;
            this.postService = postService;
            this.userService = userService;

        }


        [HttpGet("/")]
        public IActionResult Index(int page = 0)
        {
            ViewBag.currentUser = currentUser;
            ViewBag.hasLoggedIn = hasLoggedIn;
            ViewBag.voteCount = voteCount;
            var sortedPosts = postService.RankPosts(applicationContext.Posts.ToList());
            const int PageSize = 3;

            var count = sortedPosts.Count();

            var data = sortedPosts.Skip(page * PageSize).Take(PageSize).ToList();

            this.ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);

            this.ViewBag.Page = page;

            return this.View(data);
        }

        [HttpPost("/")]
        public IActionResult UpdateVote(long id, string symbol)
        {
            voteCount++;
            if (voteCount > 1)
            {
                return RedirectToAction(nameof(Index), "Home", applicationContext.Posts.ToList());
            }
            postService.UpdateVote(id, symbol);
            ViewBag.voteCount = voteCount;
            voteId = id;
            ViewBag.voteId = voteId;
            return RedirectToAction(nameof(Index), "Home", applicationContext.Posts.ToList());
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult CheckLogIn(string name, string password)
        {
            if (userService.LoginCheck(name, password))
            {
                hasLoggedIn = true;
                currentUser = name;
                ViewBag.currentUser = currentUser;
                return View(nameof(Index), postService.RankPosts(applicationContext.Posts.ToList()));
            }
            ViewBag.hastheUser = false;
            return RedirectToAction(nameof(Index), "Home", postService.RankPosts(applicationContext.Posts.ToList()));
        }

        public IActionResult Logout()
        {
            hasLoggedIn = false;
            currentUser = null;
            voteCount = 0;
            ViewBag.currentUser = currentUser;
            ViewBag.voteCount = 0;
            return RedirectToAction(nameof(Index), "Home", postService.RankPosts(applicationContext.Posts.ToList()));
        }

        [HttpGet("/addpost")]
        public IActionResult AddNewPost(string name, string password)
        {
            if (hasLoggedIn)
            {
                ViewBag.currentUser = currentUser;
                return View();
            }
            else
            {
                return RedirectToAction(nameof(Index), "Home", postService.RankPosts(applicationContext.Posts.ToList()));
            }

        }

        public IActionResult AfterAddNewPost(Post post)
        {
            postService.AddNewPost(post);
            return RedirectToAction(nameof(Index), "Home", postService.RankPosts(applicationContext.Posts.ToList()));
        }


    }
}
