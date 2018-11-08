using System;
using System.Diagnostics;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //excercise 11
            int a = 3;
            // make it bigger by 10
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            // please double c's value

            Console.WriteLine((double)c);

            int d = 125;
            // please divide by 5 d's value

            Console.WriteLine(d/5);

            int e = 8;
            // please cube of e's value

            Console.WriteLine(Math.Pow(e,3));

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)
           Console.WriteLine("f1 is bigger than f2:"+(f1>f2));

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            Console.WriteLine("g2 is bigger than g1:" + (f1 > f2));

            long h = 1357988018575474;
            // tell if 11 is a divisor of h (print as a boolean)
            string result=(h%11==0)?"true":"false";
            Console.WriteLine("11 is a divisor of h:"+result);
            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            Console.WriteLine("i1 is higher than i2 squared and smaller than i2 cubed: "+
                              ((i1>Math.Pow(3,2))&&i1<Math.Pow(3,3)));
            int j = 1521;
            // tell if j is divisible by 3 or 5 (print as a boolean)
           Console.WriteLine("j is divisible by 3 or 5 :"+
                             ((j%3==0)||(j%5==0)));
            string k = "Apple";
            //fill the k variable with its content 4 times
            for(int i = 0; i<2; i++)
            {
                k +=k;
            }
            Console.WriteLine(k);

            // excercise 13
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;
            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
            Console.Write("remaining seconds: "+((24*60*60)-(14*60*60+34*60+42)));
             
            //excercise 14
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            Console.WriteLine("please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("hello "+name);

            //excercise 15
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("Please enter the distance in kilometer:");
            double kilo = double.Parse(Console.ReadLine());
            Console.WriteLine("convert to miles: "+(1.6*kilo));

            //excercise 18
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            Console.WriteLine("please enter a number:");
            int num = int.Parse(Console.ReadLine());
            string judgeNumber = (num % 2 == 0) ? "even" : "odd";
            Console.WriteLine("the number is : "+judgeNumber);

            //excercise 19
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
            Console.WriteLine("please enter a number");
            int num1 = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Not enough");
            }else if(num1==1)
            {
                Console.WriteLine("One");
            }else if(num==2)
            {
                Console.WriteLine("Two");
            }else if (num > 2)
            {
                Console.WriteLine("A lot");
            }
           


            //excercise 21
            //PartyIndicator
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            Console.WriteLine("Please enter the number girls and boys:");
            int girl = int.Parse(Console.ReadLine());
            int boy = int.Parse(Console.ReadLine());
          
            if ((boy == girl) && (boy + girl > 20))
            {
                Console.WriteLine("The party is excellent");
            }else if ((boy + girl > 20) && (boy != girl))
            {
                Console.WriteLine("Quite cool party");
                
            }else if ((boy + girl) < 20)
            {
                Console.WriteLine("Average party");
                
            }else if (girl == 0)
            {
                Console.WriteLine("Sausage party");
            }

            //excercise 36
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");

            // Get the first number:
            double number1 = double.Parse(Console.ReadLine());
   
            Console.WriteLine("Please provide the second number:");

            // Get the second number:
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");
            double result1 = 0.0;
            // Get the operation from standard input:
            string operation = Console.ReadLine();
            switch(operation)
            {
                case "add":
                    result1=number1+number2;
                    break;
                case "substract":
                    result1=number1-number2;
                    break;
                case "multiply":
                    result1=number1*number2;
                    break;
                case "divide":
                    result1=number1/number2;
                    break;
            }

            // use the `switch` statement and the corresponding calculation
            // store the result of the calculation in the `result` variable

       

            Console.WriteLine($"The result of the calculation is {result1}");





        }
    }
}
