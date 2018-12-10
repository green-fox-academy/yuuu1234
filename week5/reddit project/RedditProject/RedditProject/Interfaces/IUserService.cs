using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditProject.Interfaces
{
    public interface IUserService
    {
        
        bool LoginCheck(string name, string password);
    }
}
