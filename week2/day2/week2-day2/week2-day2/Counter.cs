using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class Counter
    {
        public int count;
        public int initial;
        public Counter(int count)
        {
            this.count = count;
            this.initial = count;
        }

        public Counter():this(0)
        {
            
        }

        public void Add(int number)
        {
            this.count += number;
        }

        public void Add()
        {
            this.count++;
        }

        public string Get()
        {
            return count.ToString();
        }

        public void Reset()
        {
            this.count = this.initial;
        }
    }
}
