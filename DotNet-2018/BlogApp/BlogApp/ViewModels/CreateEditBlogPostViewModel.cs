using System.Collections.Generic;
using BlogApp.Models;

namespace BlogApp.ViewModels
{
    public class CreateEditBlogPostViewModel
    {
        public BlogPost BlogPost { get; set; }

        public List<Category> Categories { get; set; }
    }
}