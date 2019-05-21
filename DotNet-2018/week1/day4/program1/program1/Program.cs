using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //excercise1
            Console.WriteLine("Hello Yu");
            //excercise 2
            Console.WriteLine("Humpty Dumpty sat on a wall,");
            Console.WriteLine("Humpty Dumpty had a great fall.");
            Console.WriteLine("All the king's horses and all the king's men");
            Console.WriteLine("Couldn't put Humpty together again.");
            //excercise 3
            Console.WriteLine("Hello Wan \nHello Grace\nHello Zoe");
            //excercise 4
            Console.WriteLine("Wang Yu\nEdiburgh University\nLanzhou");
            //excercise5
            int number1 = 22;
            int number2 = 13;
            Console.WriteLine("add: "+ (number1 - number2));
            Console.WriteLine("substract: "+(number1-number2));
            Console.WriteLine("multiply: "+(number1 * number2));
            Console.WriteLine("divide: "+((decimal)number1 /(decimal)number2));
            Console.WriteLine("integer part after division: "+(number1/number2));
            Console.WriteLine("reminder: "+(number1 %number2));
            //excercise 6
            Console.WriteLine("working hours"+(6*5*17));
            double percent = 52.0 / (17 * 7 * 24)*100;
            //percent.ToString() + "%"
            Console.WriteLine("percentage: "+ percent.ToString() + "%");
            //excercise 7
            var favouriteNumber = "26";
            Console.WriteLine("my favourite number is {0}",favouriteNumber);
            //excercise 8:
            int a = 123, b=526;
            int temp;
            Console.WriteLine("before temp a is {0} b is {1}",a,b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After temp a is {0} b is {1}", a, b);
            //excercise 10
            string[] info = {"wang yu", "25", "169", "single"};
            Console.WriteLine("my name is  {0}, my age is  {1},my height is  {2}, my marriage is  {3}", info[0], info[1],
            info[2],info[3]);
           









        }
    }
}
