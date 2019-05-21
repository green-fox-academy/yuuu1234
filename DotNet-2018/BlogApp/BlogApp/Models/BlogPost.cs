using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    // dependent entity
    public class BlogPost
    {
        public long BlogPostId { get; set; }

        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        [MinLength(3)]
        public string Content { get; set; }

        // navigation property
        public Category Category { get; set; }

        // this foreign key
        // CId is not a good name, this is just for the demo
        public long? CId { get; set; }
    }
}