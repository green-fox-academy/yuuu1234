using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTests
{
    public class MethodCollection
    {
        public int Sum(List<int> elements)
        {
            int result = 0;
            if (elements == null)
            {
                return 0;
            }
            foreach (var i in elements)
            {
                result += i;
            }

            return result;
        }

        public bool Anagram(string a, string b)
        {
            char[] chara = a.ToCharArray();
            
            string reversea = new string(chara.Reverse().ToArray());
            if (reversea.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Dictionary<char, int> CountChars(string s)
        {
            Dictionary<char,int> result=new Dictionary<char, int>();
            char[] chars = s.ToCharArray();
            foreach (var c in chars)
            {
                try
                {
                    result[c] += 1;
                }
                catch
                {
                    result[c] = 1;
                }
            }

            return result;
        }

        public int Fibonacci(int index)
        {
            int result = 0;
            List<int> fib=new List<int>(){1,1};
            if (index < 0)
            {
                throw new Exception("index must greater than 0");
            }else if (index == 0 || index == 1)
            {
                return fib[index];
            }

            while (fib.Count-1<= index-1)
            {
                fib.Add(fib[fib.Count-1]+fib[fib.Count-2]);
                result = fib[fib.Count - 1];
                Console.WriteLine("result"+result);
            }

            return result;
        }


    }
}
