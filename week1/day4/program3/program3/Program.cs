using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //excercise 23
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("I won't cheat on the exam!");
            }

            //excercise 24
            // Create a program that prints all the even numbers between 0 and 500
            string allEvenNumbers = "";
            for (int i = 0; i < 501; i++)
            {
                if (i % 2 == 0)
                {
                    allEvenNumbers += i.ToString() + "; ";
                }
            }

            Console.WriteLine(allEvenNumbers);


            //excercise 25
            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150
            Console.WriteLine("please enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("multiplicationTable");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + "*" + number + "= " + (i * number));
            }

            //excercise 26
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            Console.WriteLine("Pleasde enter 2 numbers:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            while (n1 > n2)
            {
                Console.WriteLine("The second number should be bigger!");
                Console.WriteLine("Pleasde enter 2 numbers:");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
            }

            for (int i = n1; i < n2; i++)
            {
                Console.WriteLine(i);
            }

            //excercise 27
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            //excercise 28

            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            Console.WriteLine("Please enter the levels of trangle:");
            int level = int.Parse(Console.ReadLine());

            for (int i = 1; i <= level; i++)
            {
                string levelOutput = "";
                for (int j = 1; j <= i; j++)
                {
                    levelOutput += "*";
                }

                Console.WriteLine(levelOutput);
            }

            //excercise 32
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
            Console.WriteLine("pleaseenter the level of the square:");
            int line = int.Parse(Console.ReadLine());
            for(int i = 1; i <= line; i++)
            {
                string row = "";
                if (i == 1 || i == line)
                {
                    for (int n = 1; n <= line; n++)
                    {
                        row += "%";
                    }
                }
                else
                {
                    for (int m= 1; m <= line; m++)
                    {
                        row=(m == 1 || m == i || m == line) ? row += "%" : row += " ";

                    }
                }
                Console.WriteLine(row);
            }

            //excercise 33
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
            Random rd=new Random();
            int randomNumner=rd.Next(0, 11);
            Console.WriteLine("Please enter your guess:");
            int guess = int.Parse(Console.ReadLine());
            do
            {
                if (guess < randomNumner)
                {
                    Console.WriteLine("try higher:");
                    guess = int.Parse(Console.ReadLine());

                }else if (guess > randomNumner)
                {
                    Console.WriteLine("try lower:");
                    guess = int.Parse(Console.ReadLine());
                }
            } while (guess != randomNumner);
            Console.WriteLine("you got it!");

            //excercise 35
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            for (int i = 1; i <= 8; i++)
            {
                string chess = "";
                if (i % 2 == 0)
                {
                    chess = " % % % %";
                }
                else
                {
                    chess = "% % % %";
                }
                Console.WriteLine(chess);
            }

   
        }

    }
}
