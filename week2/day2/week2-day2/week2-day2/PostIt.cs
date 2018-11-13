using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class PostIt
    {
        public string backgroundColor;
        public string text;
        public string textColor;

        public PostIt(string bc, string tx, string tc)
        {
            this.backgroundColor = bc;
            this.text = tx;
            this.textColor = tc;
        }
    }
}
