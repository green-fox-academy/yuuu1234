﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditProject.Models
{
    public class User
    {
        public long UserId { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public ICollection<Post> Posts { get; set; }
        public User()
        {
            
        }
    }
}
