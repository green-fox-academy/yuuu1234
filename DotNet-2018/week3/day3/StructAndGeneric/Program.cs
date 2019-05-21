using System;
using System.Collections;
using System.Collections.Generic;

namespace StructAndGeneric
{
    class Program
    {
        public struct CoOrds
        {
            public readonly double x;
            public readonly double y;

            public CoOrds(double x,double y)
            {
                this.x = x;
                this.y = y;
            }
        }

         
        static void Main(string[] args)
        {
            int choice =4;
            switch (choice)
            {
                case 1:
                    List<CoOrds> coOrds = new List<CoOrds>();
                    Fill(coOrds);
                    Console.WriteLine(Closest(coOrds));
                    break;
                case 2:
                    Random r=new Random();
                    Prize prize=new Prize(r.Next(1000, 10001),(Currency)r.Next(0,4));
                    Participant may=new Participant("May");
                    Console.WriteLine($"{may.Name} prize : {may.Prize.Amount} {may.Prize.Currency}");
                    may.ChangePrize();
                    Console.WriteLine($"After change\n: {may.Name} prize : {may.Prize.Amount} {may.Prize.Currency}");
                    break;
                //sort Array
                case 3:
                    int[] i=new int[]{4,3,5,1,2};
                    SortArray<Array>(i);
                    break;
                case 4:
                    Container<int> primitiveContainer = new Container<int>();
                    primitiveContainer.Add(1);
                    primitiveContainer.Add(1);
                    primitiveContainer.Add(2);
                    Container<Person> personContainer = new Container<Person>();
                    personContainer.Add(new Person("James"));
                    personContainer.Add(new Person("James"));
                    personContainer.Add(new Person("John"));
                    Console.WriteLine(primitiveContainer.ToString());  // Expected output : 1 2
                    Console.WriteLine(personContainer.ToString());  // Expected output : James John
                    Console.ReadLine();
                    break;

            }
            
        }

        public static void Fill(List<CoOrds> l)
        {
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();
                double x = r.Next(0, 101);
                double y = r.Next(0, 101);
                l.Add(new CoOrds(x, y));
            }
        }

        public static double  Closest(List<CoOrds> l)
        {
            double closest = 0;
            foreach (var c in l)
            {
                double temp = Math.Sqrt(Math.Pow(c.x, 2) + Math.Pow(c.y, 2));
                if (closest < temp)
                {
                    closest = temp;
                }
            }
            return closest;
        }

        public static void SortArray<U>(Array array) 
        {
            Array.Sort(array);
            Array.Reverse(array);
            foreach (var t in array)
            {
                Console.WriteLine(t.ToString());
            }
        }

    }
}
