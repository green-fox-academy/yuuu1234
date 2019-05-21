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
        public async Task<IActionResult> Index(int page = 0)
        {
            ViewBag.currentUser = currentUser;
            ViewBag.hasLoggedIn = hasLoggedIn;
            ViewBag.voteCount = voteCount;
            var sortedPosts = await postService.GetAllPostsAsync();
            const int PageSize = 3;

            var count = sortedPosts.Count();

            var data = sortedPosts.Skip(page * PageSize).Take(PageSize).ToList();

            this.ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);

            this.ViewBag.Page = page;

            return this.View(data);
        }

        [HttpPost("/")]
        public async Task<IActionResult> UpdateVote(long id, string symbol)
        {
            var posts = await postService.GetAllPostsAsync();
            voteCount++;
            if (voteCount > 1)
            {                
                return RedirectToAction(nameof(Index), "Home", posts);
            }
            await postService.UpdateVoteAsync(id, symbol);
            ViewBag.voteCount = voteCount;
            voteId = id;
            ViewBag.voteId = voteId;
            return RedirectToAction(nameof(Index), "Home",posts);
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult CheckLogIn(string name, string password)
        {
            if (userService.LoginCheckAsync(name, password))
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

        [HttpGet("/register")]
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult CheckRegisteration(User user, string passwordAgain)
        {
            if (!userService.RegistrationCheck(user, passwordAgain))
            {
                ViewBag.successRegisteration = false;
                return View(nameof(Register));
            }
            else
            {
                userService.RegisterationAsync(user);
                hasLoggedIn = true;
                currentUser = user.UserName;
                ViewBag.currentUser = currentUser;
                return View(nameof(Index), postService.RankPosts(applicationContext.Posts.ToList()));
            }

        }

        [HttpGet("/addpost")]
        public IActionResult AddNewPost(string name, string password)
        {
            if (hasLoggedIn==true)
            {
                ViewBag.currentUser = currentUser;
                return View();
            }
            else
            {
                return RedirectToAction(nameof(Login));
            }

        }

        public IActionResult AfterAddNewPost(Post post)
        {
            postService.AddNewPostAsync(post);
            return RedirectToAction(nameof(Index), "Home", postService.RankPosts(applicationContext.Posts.ToList()));
        }

        public IActionResult GetUserPosts()
        {
            ViewBag.currentUser = currentUser;
            return View(userService.GetUserPostsAsync(currentUser));
        }


    }
}
