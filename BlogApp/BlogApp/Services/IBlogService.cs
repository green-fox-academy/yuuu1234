using System.Collections.Generic;
using BlogApp.Models;

namespace BlogApp.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetAll();
        void Create(BlogPost blogPost);
        void Update(BlogPost blogPost);
        BlogPost FindById(long blogPostId);
        void Delete(BlogPost blogPost);
    }
}