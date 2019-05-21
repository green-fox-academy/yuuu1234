using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditProject.Models;

namespace RedditProject.Interfaces
{
    public interface IUserService
    {

        Task<bool> LoginCheckAsync(string name, string password);
        bool RegistrationCheck(User user, string passwordAgain);
        Task RegisterationAsync(User user);
        Task<IEnumerable<Post>> GetUserPostsAsync(string user);

    }
}
