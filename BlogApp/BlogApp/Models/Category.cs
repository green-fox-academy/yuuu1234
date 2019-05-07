using System.Collections.Generic;

namespace BlogApp.Models
{
    public class Category
    {
        public long CategoryId { get; set; }

        public string Name { get; set; }

        // inverse navigation property
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}