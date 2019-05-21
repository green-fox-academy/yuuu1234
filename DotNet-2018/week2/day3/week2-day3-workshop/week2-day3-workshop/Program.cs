using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace week2_day3_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Divide by zero
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            //DivideByZero();

            //// Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt

            string filename ="my-file.txt";
            StreamReader myReader=new StreamReader(filename);
            string line = "";
            try
            {
                while (line != null)
                {
                    line = myReader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
                myReader.Close();
            }

            //Count lines
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
           Console.WriteLine(CountLines("my-file.txt"));

            //Write line
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            StreamWriter mywriter=new StreamWriter(filename);
            string myname = "wang yu";
            try
            {
                mywriter.WriteLine(myname,true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                mywriter.Close();
            }

            //write multiple lines
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.
            WriteMultipleLines(filename,"hello",3);

            //CopyFile
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            CopyFile(filename, "copy.txt");

            //logs
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.

            Console.WriteLine(Ratio("logs.txt"));

            //
            // Write a function that takes a filename as a parameter
            // The file contains an ended Tic-Tac-Toe match
            // We have provided you some example files (draw.txt, win-x.txt, win-o.txt)
            // Return "X", "O" or "Draw" based on the input file

            Console.Write(TicTacResult("win-o.txt"));
            // Should print "O"

            Console.Write(TicTacResult("win-x.txt"));
            // Should print "X"

            Console.Write(TicTacResult("draw.txt"));
            // Should print "Draw"
        }

        static void DivideByZero()
        {
            float n1 = 10;
            Console.WriteLine("Please enter a number");
            float n2 = int.Parse(Console.ReadLine());
            try
            {
                float result = (n1/n2);
                Console.WriteLine("the result is {}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        static int CountLines(string filename)
        {
            
            string line = "";
            int count = 0;
            try
            {
                StreamReader myReader = new StreamReader(filename);
                while (line != null)
                {
                    count++;
                    line = myReader.ReadLine();
                    
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                return 0;
            }

            return count-1;

        }


        static void WriteMultipleLines(String file, string text, int num)
        {
            int count = 0;
            try
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    while (count < num)
                    {
                        writer.WriteLine(text);
                        count++;
                    }
                }
            }
            catch (Exception e)
            {

            }
           

        }

        static bool CopyFile(string origin, string copy)
        {
            bool result = false;
            try
            {
                List<string> content = new List<string>();
                using(StreamReader reader=new StreamReader(origin))
                {
                    string line = "";
                    while (line != null)
                    {
                        line = reader.ReadLine();
                        content.Add(line);
                    }
                }

                using (StreamWriter writer = new StreamWriter(copy))
                {
                    foreach (string l in content)
                    {
                        writer.WriteLine(l);
                    }
                }

                result = true;


            }
            catch (Exception e)
            {
                return result;
            }

            return result;
        }

        static string[] GetUniqueIp(string file)
        {
            
            List<string> distinctIp=new List<string>();
            List<string> ips=new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string[] temp;
                    string line = "";
                    while (line != null)
                    {
                        line = reader.ReadLine();
                        temp = line.Split(" ");
                        ips.Add(temp[8]);
         
                    }

                    foreach (var i in ips)
                    {
                        Console.WriteLine(i);
                    }

                    distinctIp = ips.Distinct().ToList();


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return distinctIp.ToArray();
        }

        static double Ratio(string file)
        {
            double get = 0;
            double post = 0;
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string[] temp;
                    string line = "";
                    while (line != null)
                    {
                        line = reader.ReadLine();
                        temp = line.Split(" ");
                        if (temp[11] == "GET")
                        {
                            get++;
                        }else if (temp[11] == "POST")
                        {
                            post++;
                        }
                    }

                    

                   

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return get / post;

        }

        static string TicTacResult(string file)
        {
            char[][] chars=new char[3][];
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    lin
                }
            }catch(Exception e)

            {

            }
        }

        
    }
    
    
}
