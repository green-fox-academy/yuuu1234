using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading;

namespace day5_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //excercise:doubling
        
            Console.WriteLine("please enter the number you want to double:");
            int baseNum=int.Parse(Console.ReadLine());
            Console.WriteLine(Doubling(baseNum));

            //Greeter function
            Console.WriteLine("greeting to:");
            string al = Console.ReadLine();
            Console.WriteLine(Greet(al));

            //append a
            string typo = "Chinchill";
           Console.WriteLine(AppendAFunc(typo));

            //Summing
            Console.WriteLine(Sum(5));

            //Factorial
            Console.WriteLine("find factorial of:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorio(num));

            //Third
            // - Create an array variable named `q`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print the third element of `q`
            Console.ReadLine();
            int[] q = {4, 5, 6, 7};
            Console.WriteLine("The third element of q is"+q[2]);

            //Compare length
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`
            int[] p1={1,2,3};
            int[] p2 = {4, 5};
            bool res = (p2.Length > p1.Length) ? true : false;
            Console.WriteLine("`p2` has more elements than `p1': "+res);

            //sum elements
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element
            int[] r = {54, 23, 66, 12};
            Console.WriteLine("the sum of the second and the third element: "+(r[1]+r[3]));

            //Change element
            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element

            int[] a = {1, 2, 3, 8, 5, 6};
            a[3] = 4;
            Console.WriteLine(a[3]);

            //increment element
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element
            int[] t = {1, 2, 3, 4, 5};
            t[2] += 1;
            Console.WriteLine("the third element after increment: "+t[2]);

            //print element
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`
            int[] numbers = {4, 5, 6, 7};
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Matrix
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            int[,] matrix = new int[4, 4];
            for (int i= 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i == j) ? 1 : 0;
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            //double items
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] numList = {3, 4, 5, 6, 7};
            for (int i = 0; i < numList.Length; i++)
            {
                numList[i] *= 2;
            }

            //color
            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`
            string[][] colors =
            {
                new[] {"lime", "forest green", "olive", "pale green", "spring green"},
                new[] {"orange red", "red", "tomato"},
                new[] {"orchid", "violet", "pink", "hot pink"}
            };


            //Append a
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end
            string[] animals = {"koal", "pand", "zebr"};
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] += "a";
            }

            //swap elements
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = {"first", "second", "third"};
            string temp;
            temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            //sum all
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`

            int[] ai = {3, 4, 5, 6, 7};
            int sum = 0;
            foreach (int i in ai)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            //reverse list
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = {3, 4, 5, 6, 7};
            int[] temp2 = new int[aj.Length];
            aj.CopyTo(temp2,0);
            int count = 0;
            for (int i = temp2.Length - 1; i >= 0; i--)
            {
                
                aj[count] = temp2[i];
                count += 1;

            }

            foreach (int i in aj)
            {
                Console.WriteLine(i);
            }

            //unique
            Console.WriteLine(Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
            //  should print: `[1, 11, 34, 52, 61]`

            //anagram
            Console.WriteLine(anagram("dog","god"));

            //Palinfrome Builder

            Console.WriteLine(Palindrome("123"));

            //Palinfrome searcher
            Console.WriteLine(PalindromeSearcher("dog goat dad duck doodle never"));

            //Bubble and advanced bubble
            //  Example:
           // Console.WriteLine(Bubble(new int[] { 34, 12, 24, 9, 5 }));
            //  should print [5, 9, 12, 24, 34]
           // Console.WriteLine(AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true));
            //  should print [34, 24, 12, 9, 5]

        }

        //excercise:doubling
        // - Create an integer variable named `baseNum` and assign the value `123` to it
        // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
        // - Print the result of `Doubling(baseNum)
        public static int Doubling(int baseNum)
        {
            return (baseNum * 2);
        }

        //Greeter function
        // - Create a string variable named `al` and assign the value `Greenfox` to it
        // - Create a function called `Greet` that greets it's input parameter
        //     - Greeting is printing e.g. `Greetings dear, Greenfox`
        // - Greet `al
        static string Greet(string al)
        {
            return "Greetings dear" + al;
        }

        //append a
        // - Create a string variable named `typo` and assign the value `Chinchill` to it
        // - Write a function called `AppendAFunc` that gets a string as an input,
        //   appends an 'a' character to its end and returns with a string
        // - Print the result of `AppendAFunc(typo)`
        static string AppendAFunc(string typo)
        {
            return typo + "a";
        }

        //summing
        // - Write a function called `Sum` that sums all the numbers
        //   until the given parameter and returns with an integer
        static int Sum(int para)
        {
            int sum = 0;
            for(int i=1;i<=para;i++)
            {
                sum += i;
            }

            return sum;
        }

        //Factorial
        // - Create a function called `Factorio`
        //   that returns it's input's factorial
        static int Factorio(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            int result=1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }

        //unique
        //  Create a method that takes an array of integers as a parameter
        //  Returns an array of integers where every integer occurs only once
        static int[] Unique(int[] integers)
        {
            Array.Sort(integers);
            List<int> ml=new List<int>();
            foreach (int i in integers)
            {
                if (!ml.Contains(i))
                {
                    ml.Add(i);
                }
            }

            int[] result = ml.ToArray();

            return result;
        }

        //anagram
        static bool anagram(string input1, string input2)
        {
            char[] char1 = input1.ToCharArray();
            char[] char2 = input2.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            bool result=(Enumerable.SequenceEqual(char1,char2))?true:false;
            return result;
        }

        //palindrome builder
        static string Palindrome(string pal)
        {
            if (pal == "")
            {
                return "";
            }
            else
            {
          
                char[] palin = pal.ToCharArray();
                Array.Reverse(palin);
                string revertStr=new string(palin);
                return pal + revertStr;
               
            }
        }

        //Palindrome searcher
        static string[] PalindromeSearcher(string pal)
        {
            ArrayList al = new ArrayList();
           
            char[] palchars = pal.ToCharArray();
            for (int i = 3; i < palchars.Length; i++)
            {
                for (int j = 0; j < palchars.Length-i; j++)
                {
                    char[] copy = new char[palchars.Length];
                    palchars.CopyTo(copy,0);
                    copy.Skip(j).Take(i).ToArray();
                    char[] origin=new char[copy.Length];
                    copy.CopyTo(origin, 0);
                    Array.Reverse(copy);
                    if (copy == origin)
                    {
                        string element=new string(origin);
                        al.Add(element);
                    }
                }
            }
            string[] result = al.ToArray(typeof(string)) as string[];
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            return result;
        }

        //sort that list
        //  Create a function that takes a list of numbers as parameter
        //  Returns a list where the elements are sorted in ascending numerical order
        //  Make a second boolean parameter, if it's `true` sort that list descending
        static int[] Bubble(int[] toSort)
        {
            
           Array.Sort(toSort);
            
           return toSort;
        }

        //advanced bubble
        static int[] AdvancedBubble(int[] toSort, bool des)
        {
            if (des == true)
            {
                Array.Sort(toSort);
                toSort.Reverse();
                return toSort;
            }
            else
            {
                Array.Sort(toSort);
                return toSort;
            }
        }
    }

}
