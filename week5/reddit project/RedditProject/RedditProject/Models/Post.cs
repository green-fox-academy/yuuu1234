using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace RedditProject.Models
{
    public class Post
    {
        public long PostId { get; set; }
        public string PostContent { get; set; }
        public string Url { get; set; }
        public long Vote { get; set; } = 0;
        public DateTime PostDate { get; set; }=DateTime.Now;
        public User User { get; set; }
        public long? UserId { get; set; }
        public Post()
        {
            
        }

    }
}
