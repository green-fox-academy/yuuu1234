using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4Day3Workshop.Models
{
    public class CaesarCode
    {
        public string Caesar(string text, int number)
        {
            if (number < 0)
            {
                number = number + 26;
            }

            string result = "";

            foreach (var character in text)
            {
                var offset = char.IsUpper(character) ? 'A' : 'a';
                result += (char)((character + number - offset) % 26 + offset);
            }

            return result;
        }

    }
}
