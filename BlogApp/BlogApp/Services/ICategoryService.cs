using System.Collections.Generic;
using BlogApp.Models;

namespace BlogApp.Services
{
    public interface ICategoryService
    {
        List<Category> FindAll();
        Category FindById(long id);
    }
}