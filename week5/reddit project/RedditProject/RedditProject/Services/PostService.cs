using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using RedditProject.Interfaces;
using RedditProject.Models;
using PagedList;
namespace RedditProject.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationContext applicationContext;

        public PostService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public void AddNewPost(Post post)
        {
            applicationContext.Posts.Add(post);
            applicationContext.SaveChanges();
        }

        public void UpdateVote(long id, string symbol)
        {
            var post = applicationContext.Posts.Find(id);
            if (symbol == "-")
            {
                post.Vote--;
            }else if (symbol == "+")
            {
                post.Vote++;
            }

            applicationContext.SaveChanges();
        }

        public List<Post> RankPosts(List<Post> postsLists)
        {
            List<Post> sortedList = postsLists.OrderByDescending(n => n.Vote).ToList();
            return sortedList;
        }
    }
}
