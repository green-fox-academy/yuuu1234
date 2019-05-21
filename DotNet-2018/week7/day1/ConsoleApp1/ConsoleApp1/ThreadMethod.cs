using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadExample
{
    class ThreadMethod
    {
        private  int[] array;
        private  int from;
        private  int count;
        public ThreadMethod(int[] array, int from, int count)
        {
            this.array = array;
            this.from = from;
            this.count = count;

        }
        public  void Sum()
        {
            int result = 0;
            for (int i = this.from; i < this.from + this.count; i++)
            {
                result += array[i];
            }
            Console.WriteLine("The current thread is:"+Thread.CurrentThread.Name);
            Console.WriteLine($"the Sum from index {from} to index {from + count } is : {result}");
        }
    }
}
