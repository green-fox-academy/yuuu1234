using System.Collections.Generic;
using System.Linq;
using BlogApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApplicationContext applicationContext;

        public BlogPostRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public List<BlogPost> FindAll()
        {
            return applicationContext.BlogPosts.Include(p => p.Category).ToList();
        }
    }
}