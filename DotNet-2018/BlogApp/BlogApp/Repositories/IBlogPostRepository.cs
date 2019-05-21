using System.Collections.Generic;
using BlogApp.Models;

namespace BlogApp.Repositories
{
    public interface IBlogPostRepository
    {
        List<BlogPost> FindAll();
    }
}