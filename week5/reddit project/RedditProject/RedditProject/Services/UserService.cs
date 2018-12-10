using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditProject.Interfaces;

namespace RedditProject.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationContext applicationContext;
 
        
        public UserService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        public  bool LoginCheck(string name, string password)
        {
            foreach (var user in applicationContext.Users)
            {
                if (user.UserName == name && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
