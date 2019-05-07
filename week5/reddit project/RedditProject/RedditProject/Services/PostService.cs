using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task AddNewPostAsync(Post post)
        {
            await applicationContext.Posts.AddAsync(post);
            await applicationContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await applicationContext.Posts.Include(p => p.User).ToListAsync();
        }
        public async Task UpdateVoteAsync(long id, string symbol)
        {
            var post = await applicationContext.Posts.FindAsync(id);
            if (symbol == "-")
            {
                post.Vote--;
            }
            else if (symbol == "+")
            {
                post.Vote++;
            }

            await applicationContext.SaveChangesAsync();
        }

        public List<Post> RankPosts(List<Post> postsLists)
        {
            var sortedList = postsLists.OrderByDescending(n => n.Vote).ToList();
            return sortedList;
        }
    }
}
