using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class Blog
    {
        public  List<BlogPost> blogList=new List<BlogPost>();

        public void Add(BlogPost blogpost)
        {
            this.blogList.Add(blogpost);
        }

        public void Delete(int remove)
        {
            blogList.RemoveAt(remove);
        }

        public void Update(int update, BlogPost newblog)
        {
            blogList[update] = newblog;
        }
    }
}
