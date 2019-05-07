using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
namespace ThreadExample
{
    public class Program
    {
        public static void Main()
        {

            var GeneratedRandomArray = GenerateRandomNumbers();
            /*
            int result1=0, result2=0,result3=0,result4=0,mainResulut=0;
            Thread t1 = new Thread(() =>Sum(GeneratedRandomArray,0,25000,out result1));
            t1.Name = "1";
            Thread t2 = new Thread(() => Sum(GeneratedRandomArray, 25000, 25000,out result2));
            t2.Name = "2";
            Thread t3 = new Thread(() => Sum(GeneratedRandomArray, 500000, 25000,out result3));
            t3.Name = "3";
            Thread t4=new Thread(() => Sum(GeneratedRandomArray, 750000, 25000,out result4));
            t4.Name = "4";
            Sum(GeneratedRandomArray, 0, 1000000, out mainResulut);
            
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            t3.Start();
            t3.Join();
            t4.Start();
            t4.Join();
            Console.WriteLine("the main result:" + mainResulut);
            Console.WriteLine("sum with threads:"+(result1+result2+result3+result4));
           */

            //using threadpool
            List<int> startIndex = new List<int>() { 0, 250000, 500000, 750000 };
            foreach (var ind in startIndex)
            {
                //Console.WriteLine("start");
                //ThreadPool.QueueUserWorkItem(state=>Sum(GeneratedRandomArray,ind,25000,out result));
                //ThreadPool.QueueUserWorkItem(SumWithThreadPool,new object[] {GeneratedRandomArray,ind,25000});
                Task t =Task.Run(() => Sum(GeneratedRandomArray, ind, 25000));
                t.Wait();
            }

        }


        public static int[] GenerateRandomNumbers()
        {
            int[] result = new int[1000000];
            Random random = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                result[i] = random.Next(1, 5);
            }

            return result;
        }

        public static void Sum(int[] array, int from, int count)
        {
            int sum = 0;
            for (int i = from; i < from + count; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("The current thread is:" + Thread.CurrentThread.Name);
            Console.WriteLine($"the Sum from index {from} to index {from + count } is : {sum}");
        }

        public static void SumWithThreadPool(object state)
        {
            Console.WriteLine("hello");
            object[] array = state as object[];
            int[] inputArray = array[0] as int[];
            int from = (int)array[1];
            int count = (int)array[2];
            int sum = 0;
            for (int i = 0; i < from + count; i++)
            {
                sum += inputArray[i];
            }
            Console.WriteLine("The current thread is:" + Thread.CurrentThread.Name);
            Console.WriteLine($"the Sum from index {from} to index {from + count } is : {sum}");
        }





    }

}


