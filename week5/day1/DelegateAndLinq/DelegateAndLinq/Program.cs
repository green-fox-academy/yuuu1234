using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text.RegularExpressions;
namespace DelegateAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //excercise 1
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var result1 = n1
                .Where(n => n % 2 == 1)
                .Average();
            Console.WriteLine(result1);

            //excercise 2
            //even numbers
            var result2 = n1
                .Where(n => n % 2 == 0);
            foreach (var n in result2)
            {
                Console.WriteLine(n);
            }

            //excercise 3
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            var result3 = n1
                .Where(n => n > 0)
                .Select(n => n * n);
            foreach (var n in result3)
            {
                Console.WriteLine(n);
            }

            //excercise 4
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array

            var result4 = n1
                .Select(n => n * n)
                .Where(n => n > 20);
            foreach (var n in result4)
            {
                Console.WriteLine(n);
            }

            //excercise 5
            //Write a LINQ Expression to find the frequency of numbers in the following array
            int[] n2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var result5 = n2
                .GroupBy(n => n)
                .OrderBy(n => n.Count());

            foreach (var n in result5)
            {
                Console.WriteLine($"the frequncy is {n.Count()}");
                foreach (var g in n)
                {
                    Console.WriteLine(g);
                }
            }

            //excercise 8
            //Write a LINQ Expression to find the uppercase characters in a string.
            string n3 = "Hello It is a Beatutiful Word";

            var result8 = n3
                .Where(n => char.IsUpper(n));
            foreach (var n in result8)
            {
                Console.WriteLine(n);
            }

            //excercise 9 
            //Write a LINQ Expression to convert a char array to a string
            char[] n4 = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var result9 = new string(n4.Select(n => n).ToArray());

            Console.WriteLine(result9);

            //excercise 10
            //Fox
            List<Fox> foxList = new List<Fox>(){new Fox("Max", "pallida","red"),
                new Fox("John","pallida","green"), new Fox("Linda","fennec","gray"),
                new Fox("Alex","pallida","green"),new Fox("Julia","silver","silver")};

            var result10a = foxList
                .Select(n => n)
                .Where(n => n.Color == "green");
            Console.WriteLine("Find the green fox");
            foreach (var fox in result10a)
            {
                Console.WriteLine(fox.Name);
            }

            var result10b = foxList
                .Select(n => n)
                .Where(n => n.Color == "green" && n.Type == "pallida");
            Console.WriteLine("foxes with pallida type and green color");
            foreach (var fox in result10b)
            {
                Console.WriteLine(fox.Name);
            }

            //excercise 11
            string file = "Content.txt";
            List<string> fileContent = new List<string>();
            using (StreamReader reader = new StreamReader(file))
            {
                Regex regex = new Regex(@"\w+");

                string content = "";
                while (content != null)
                {
                    content = reader.ReadLine();
                    if (content == null)
                    {
                        break;
                    }
                    Match match = regex.Match(content);
                    while (match.NextMatch().Success)
                    {
                        fileContent.Add(match.Value);
                        match = match.NextMatch();
                    }


                }
            }

            var result11 = fileContent
                .GroupBy(n => n);
            foreach (var group in result11)
            {
                foreach (var str in group)
                {
                    Console.WriteLine($"{group.Key}: {group.Count()}");
                }
            }

            //excercise 12
            List<SWCharacter> swCharactersList = new List<SWCharacter>();
            using (StreamReader reader = new StreamReader("swcharacters.txt"))
            {
                string content = "";
                while ((content = reader.ReadLine()) != null)
                {
                    string[] character = content.Split(';');
                    swCharactersList.Add(new SWCharacter(character[0], character[1],
                        character[2], character[3], character[4], character[5], character[6],
                        character[7]));

                }
            }

            var heaviest = swCharactersList
                .Where(n => n.Mass != "unknown")
                .OrderByDescending(n => n.Mass)
                .First();

            Console.WriteLine($"the heaviest one is:{heaviest.Name} with mass {heaviest.Mass}");

            var AvgHeightMale = swCharactersList
                .Where(n => n.Gender == "male" && n.Height != "unknown")
                .Average(n => float.Parse(n.Height));
            Console.WriteLine($"the average height of male is {AvgHeightMale}");

            var AvgHeightFemale = swCharactersList
                .Where(n => n.Gender == "female" && n.Height != "unknown")
                .Average(n => float.Parse(n.Height));
            Console.WriteLine($"the average height of female is {AvgHeightFemale}");

            Dictionary<string, Dictionary<string, int>> expected = new Dictionary<string, Dictionary<string, int>>();

            var genderGroup = swCharactersList
                .GroupBy(n => n.Gender);

            foreach (var gender in genderGroup)
            {
                Dictionary<string, int> ageRange = new Dictionary<string, int>();
                string gen=gender.Key;
                var bellow21 = swCharactersList
                    .Select(n => n)
                    .Where(n => n.Gender==gen && n.BirthYear != "unknown" && double.Parse(n.BirthYear.Replace("BBY","")) < 21);
                ageRange.Add("below 21", bellow21.Count());
                var between21And40 = swCharactersList
                    .Select(n => n)
                    .Where(n => n.Gender == gen && n.BirthYear != "unknown" &&
                                double.Parse(n.BirthYear.Replace("BBY", "")) >= 21 && double.Parse(n.BirthYear.Replace("BBY", "")) < 40);
                ageRange.Add("between 21 and 40", between21And40.Count());
                var over40 = swCharactersList
                    .Select(n => n)
                    .Where(n => n.Gender == gen && n.BirthYear != "unknown" && double.Parse(n.BirthYear.Replace("BBY", "")) >= 40);
                ageRange.Add("over 40", over40.Count());

                var unkonwn = swCharactersList
                    .Select(n => n)
                    .Where(n => n.Gender == gen && n.BirthYear == "unknown");
                ageRange.Add("unknown",unkonwn.Count());
                expected.Add(gender.Key,ageRange);

            }

            foreach (var gender in expected)
            {
                Console.WriteLine(gender.Key);
                foreach (var age in gender.Value)
                {
                    Console.WriteLine(age.Key+": "+age.Value);
                }
            }



        }
    }
}
