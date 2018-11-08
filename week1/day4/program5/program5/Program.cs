using System;
using System.Threading.Tasks.Dataflow;

namespace program5
{
    class Program
    {
        static void Main(string[] args)
        {
            //excercise 9
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;
            Console.WriteLine(massInKg/(heightInM*heightInM));

            //excercise 12
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            double width = 100;
            double height = 100;
            double length = 100;
            double surfaceArea = 2*((width * height) + (width * length) + (length * height));
            double volume = width * height * length;
            Console.WriteLine("surface is: {0}, volume is: {1}",surfaceArea,volume);

            //excercise 16
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            Console.WriteLine("The number of chickens:");
            int chicken = int.Parse(Console.ReadLine());
            Console.WriteLine("The number of bigs:");
            int pig=int.Parse(Console.ReadLine());
            Console.WriteLine("The total legs of anmals':"+(pig*4+chicken*2));


            //excercise 17

            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int sum = 0, average;
            Console.WriteLine("Please enter 5 integers in a row");
            string input = Console.ReadLine();
            string [] allints = input.Split(",");
            foreach (string i in allints)
            {
                sum += int.Parse(i);
            }
           Console.WriteLine("The sum is: "+ sum);
           Console.WriteLine("The average is: "+(sum/allints.Length));

            //excercise 20
            Console.WriteLine("please enter 2 numbers:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int bigger = (number1 > number2) ? number1 : number2;
            Console.WriteLine("The bigger one is:",bigger);

            //excercise 22
            double a = 24;
            int out1 = 0;
            // if a is even increment out by one
            if (a % 2 == 0)
            {
                out1 += 1;
            }
            Console.WriteLine(out1);

            int b = 13;
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "Less!",
            // if more than 20 set out2 to "More!"
            if (b < 10)
            {
                out2 = "Less";
            }else if (b > 20)
            {
                out2 = "More";
            }else if (b >= 10 && b <= 20)
            {
                out2 = "Sweet";
            }
            Console.WriteLine(out2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same
            if (credits >= 50)
            {
                isBonus = false;
                c -= 2;
            }else if (credits < 50)
            {
                isBonus = false;
                c -= 1;
            }else if (isBonus == true)
            {
                c = c;
            }
            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"
            if ((d % 4 == 0) && (time <= 20))
            {
                out3 = "check";
            }else if (time > 200)
            {
                out3 = "Time out";
            }
            else
            {
                out3 = "Run Forest Run";
            }
            Console.WriteLine(out3);

            //
        }
    }
}
