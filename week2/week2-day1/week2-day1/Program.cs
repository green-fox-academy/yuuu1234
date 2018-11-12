using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace week2_day1
{
    class Program
    {
        static void Main(string[] args)

        {
            
            //simplreplace
            string example = "In a dishwasher far far away";
            example=example.Replace("dishwasher", "galaxy");
            Console.WriteLine(example);

            //url fixer
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!
            url = url.Replace("bots", "odds");
            Console.WriteLine(url);

            //Takes longer
            StringBuilder quote = 
                new StringBuilder("Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.");
            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            quote.Insert(20, " always takes longer than");
            Console.WriteLine(quote);

            //todo print
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:
            todoText=todoText.Insert(0,"my todo:\n");
            todoText += " - Download games\n     - Diablo";
            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(todoText);

            //Reverse
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(reversed));

            //solar system
            List<string> planetList = new List<string>()
                {"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune"};
            


            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

            //Console.WriteLine(PutSaturn(planetList));
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"
            foreach(string i in PutSaturn(planetList))
            {
                Console.WriteLine(i);
            }

            //match making
            var girls = new List<string> { "Eve", "Ashley", "Claire", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Tom", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            foreach (string i in MakingMatches(girls, boys))
            {
                Console.WriteLine(i);
            }


            //append letter
            var far = new List<string> { "bo", "anacond", "koal", "pand", "zebr" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list
            // Expected output: "boa", "anaconda", "koala", "panda", "zebra"
            foreach (var i in AppendA(far)) 
            {
                Console.WriteLine(i);
            }

            //candy sho[
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
            foreach (var i in Sweets(list))
            {
                Console.WriteLine(i);
            }

            //element finder
            var List = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsSeven(List));
            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!

            //is in list
            var list2 = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list2));

            //is in list
            var list3 = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            foreach (string i in QuoteSwap(list3))
            {
                Console.Write(i+" ");
            }
            // Expected output: "What I cannot create I do not understand."

            //Calculator
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations,
            // reate a method named "Calculate()":
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit
            //Calculator();

            //He will never
            string output = "";
            int[] notSoCrypticMessage = { 1, 12, 1, 2, 11, 1, 7, 11, 1, 49, 1, 3, 11, 1, 50, 11 };

            var map = new Dictionary<int, string>();

            map.Add(7, "run around and desert you");
            map.Add(50, "tell a lie and hurt you ");
            map.Add(49, "make you cry, ");
            map.Add(2, "let you down");
            map.Add(12, "give you up, ");
            map.Add(1, "Never gonna ");
            map.Add(11, "\n");
            map.Add(3, "say goodbye ");

            // Things are a little bit messed up
            // Your job is to decode the notSoCrypticMessage by using the hashmap as a look up table
            // Assemble the fragments into the out variable
            foreach (int i in notSoCrypticMessage)
            {
                output += map[i];
            }
            Console.WriteLine(output);

            //student counter
            var map2 = new List<Dictionary<string, object>>();

            // Given this list of hashmaps...

            var row0 = new Dictionary<string, object>();
            row0.Add("name", "Theodor");
            row0.Add("age", 9.5);
            row0.Add("candies", 2);
            map2.Add(row0);

            var row1 = new Dictionary<string, object>();
            row1.Add("name", "Paul");
            row1.Add("age", 10);
            row1.Add("candies", 1);
            map2.Add(row1);

            var row2 = new Dictionary<string, object>();
            row2.Add("name", "Mark");
            row2.Add("age", 7);
            row2.Add("candies", 3);
            map2.Add(row2);

            var row3 = new Dictionary<string, object>();
            row3.Add("name", "Peter");
            row3.Add("age", 12);
            row3.Add("candies", 5);
            map2.Add(row3);

            var row4 = new Dictionary<string, object>();
            row4.Add("name", "Olaf");
            row4.Add("age", 12);
            row4.Add("candies", 7);
            map2.Add(row4);

            var row5 = new Dictionary<string, object>();
            row5.Add("name", "George");
            row5.Add("age", 3);
            row5.Add("candies", 2);
            map2.Add(row5);

            // Display the following things:
            //  - Who has got more candies than 4 candies
            //  - Sum the age of people who have lass than 5 candies
            string people="";
            int sumage=0;
            foreach (var row in map2)
            {
                int candies = Convert.ToInt16(row["candies"]);
                int age = Convert.ToInt16(row["age"]);
                if (candies > 4)
                {
                    people += row["name"]+";";
                }

                if (candies < 5)
                {
                    sumage += age;
                }
            }
            Console.WriteLine("Who has got more candies than 4 candies: "+people);
            Console.WriteLine("Sum the age of people who have lass than 5 candies: " + sumage);

            //find a part of an integer
            //  Create a function that takes a number and a list of numbers as a parameter
            //  Returns the indeces of the numbers in the list where the first number is part of
            //  Returns an empty list if the number is not part any of the numbers in the list

            //  Example:
            Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            //find the substring of a list
            //  Create a function that takes a string and a list of string as a parameter
            //  Returns the index of the string in the list where the first string is part of
            //  Only need to find the first occurence and return the index of that
            //  Returns `-1` if the string is not part any of the strings in the list

            //  Example
            string[] searchArr = { "this", "is", "what", "I'm", "searching", "in" };

            Console.WriteLine(Substrlist("ching", searchArr));
            //  should print: `4`
            Console.WriteLine(Substrlist("not", searchArr));
            //  should print: `-1`

            //jose
            Josephus(41);
            //armstrong
            CheckArmstrong(371);

        }

        static String Reverse(string tore)
        {
            char[] tochar = tore.ToCharArray();
            Array.Reverse(tochar);
            return new string(tochar);
        }

        static List<string> PutSaturn(List<string> a)
        {
            int i = a.IndexOf("Uranus");
            a.Insert(i,"Saturn");
            return a;
        }

        static List<string> MakingMatches(List<string> girls,List<string> boys)
        {
            List<string> mixed=new List<string>(girls);
            int count = 0;
            while (count < boys.Count)
            {
                if (count < girls.Count)
                {
                    mixed.Add(girls[count]);
                }
                mixed.Add(boys[count]);
                count += 1;
            }

            return mixed;

        }

        static List<string> AppendA(List<string> a)
        {
            for(int i=0;i<a.Count;i++)
            {
                a[i] += "a";
            }

            return a;
        }

        static List<object> Sweets(List<object> a)
        {
            int bi = a.IndexOf(false);
            a[bi] = "Ice cream";
            int ni = a.IndexOf(2);
            a[ni] = "Croissant";
            return a;
        }

        static string ContainsSeven(List<int> a)
        {
            if (a.Contains(7))
            {
                return "hoorray";
            }
            else
            {
                return "nooooo";
            }
        }

        static bool CheckNums(List<int> a)
        {
            List<int> allin=new List<int>(){ 4, 8, 12, 16 };
            bool result = true;
            foreach(int i in allin)
            {
                if (!a.Contains(i))
                {
                    return false;
                }
            }

            return result;
        }

        static List<string> QuoteSwap(List<string> a)
        {
            string temp;
            int cannot = a.IndexOf("cannot");
            int doo = a.IndexOf("do");
            a[cannot] = "do";
            a[doo] = "cannot";
            return a;
        }

        static void Calculator()
        {
            Console.WriteLine("Please type in the expression:");
            string s=Console.ReadLine();
            string[] op = s.Split(" ");
            string operation = op[1] + op[0] + op[2];
            DataTable dt = new DataTable();
            Console.WriteLine(dt.Compute(operation,"").ToString());


        }

        static List<int> SubInt(int num,int[] a)
        {
            List< int > result= new List<int>();
            for(int i=0;i<a.Length;i++)
            {
                string s = a[i].ToString();
                string n = num.ToString();
                if (s.Contains(n))
                {
                    result.Add(i);
                }

            }

            return result;

        }

        static int Substrlist(string sub,string[] a)
        {
            int result = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Contains(sub))
                {
                    return i;
                }
            }

            return result;
        }

        static void Guess()
        {
            Console.WriteLine("please enter the upper bound:");
            int upper=int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the lower bound:");
            int lower = int.Parse(Console.ReadLine());
            
            int count = 5;
            Random rd=new Random();
           
            int correct=rd.Next(lower, upper);
           
            int guess;
            Console.WriteLine("he");
            do
            {
                Console.WriteLine("I've the number between {0} - {1}, You have {2}lives",lower,upper, count);
                guess = int.Parse(Console.ReadLine());

                if (guess > correct)
                {
                    count -= 1;
                    Console.WriteLine("Too high, You have {0} lives", count);
                    guess = int.Parse(Console.ReadLine());
                }
                else if (guess < correct)
                {
                    count -= 1;
                    Console.WriteLine("Too low, You have {0} lives", count);
                    guess = int.Parse(Console.ReadLine());
                }

            } while (guess != correct);

            Console.WriteLine("you got it");
        }

        static void Josephus(int num)
        {
            List<int> circle = new List<int>();
            int killer = 0;
            int killed;
            int count =0;
            for (int i = 0; i < num; i++)
            {
                circle.Add(1);
            }

            while (count < (num-1))

            {
                
                killed = circle.IndexOf(1, killer + 1);
                if (killed == -1)
                {
                    killed = circle.IndexOf(1, 0);
                }

             
                circle[killed] = 0;
                count += 1;
                killer = circle.IndexOf(1, killed);
                if (killer == -1)
                {
                    killer = circle.IndexOf(1, 0);

                }

                

            }

            int winner = circle.IndexOf(1)+1;
            Console.WriteLine("the winner is "+winner);

        }

        static void CheckArmstrong(int num)
        {
            char[] tochars = num.ToString().ToCharArray();
            int digit = tochars.Length;
            int compare = 0;
            foreach (char i in tochars)
            {
                int n = i - 0;
                compare+=Convert.ToInt32(Math.Pow(n,digit));
            }

            if (compare == num)
            {
                Console.WriteLine("{0} is an armstrong number",num);
            }
            else
            {
                Console.WriteLine("{0} is an armstrong number", num);
            }

        }


    }
}
