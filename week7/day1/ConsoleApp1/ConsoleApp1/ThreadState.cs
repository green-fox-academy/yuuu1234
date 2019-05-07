using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadExample
{
    class ThreadState
    {
        private readonly int value;

        public ThreadState(int number)
        {
            value = number;
        }

        public void ThreadMain()
        {
            Console.WriteLine(value);
        }
    }
}
