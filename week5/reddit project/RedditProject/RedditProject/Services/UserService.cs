using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedditProject.Interfaces;
using RedditProject.Models;

namespace RedditProject.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext applicationContext;


        public UserService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        public async Task<bool> LoginCheckAsync(string name, string password)
        {
            var users = await applicationContext.Users.ToListAsync();
            foreach (var user in users)
            {
                if (user.UserName == name && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool RegistrationCheck(User user, string passwordAgain)
        {
            return user.Password == passwordAgain;
        }

        public async Task RegisterationAsync(User user)
        {
            await applicationContext.Users.AddAsync(user);
            await applicationContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Post>> GetUserPostsAsync(string user)
        {
            List<Post> posts = new List<Post>();
            var postsInDB = await applicationContext.Posts.Include(p => p.User).ToListAsync();
            foreach (var post in postsInDB)
            {
                if (post.User.UserName == user)
                {
                    posts.Add(post);
                }
            }

            return posts;
        }
    }
}
