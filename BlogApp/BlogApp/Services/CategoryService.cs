using System.Collections.Generic;
using System.Linq;
using BlogApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationContext applicationContext;

        public CategoryService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public List<Category> FindAll()
        {
            return applicationContext.Categories.ToList();
        }

        public Category FindById(long id)
        {
            return applicationContext
                .Categories
                .Include(c => c.BlogPosts)
                .FirstOrDefault(c => c.CategoryId == id);
        }
    }
}