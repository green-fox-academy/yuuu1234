using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class BlogPost
    {
        public string authorName;
        public string title;
        public string text;
        public string publicationDate;

        public BlogPost(string an, string title,string text,string pd)
        {
            this.authorName = an;
            this.title = title;
            this.text = text;
            this.publicationDate = pd;
        }
    }
}
