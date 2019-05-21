using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Interfaces;
using Frontend.Models;

namespace Frontend.Services
{
    public class FrontendService : IFrontendService
    {
        public long[] ArrayDouble(long[] numbers)
        {
            long[] result = new long[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = 2 * numbers[i];
            }

            return result;
        }

        public long ArrayMultiply(long[] numbers)
        {
            long result = 1;
            foreach (var number in numbers)
            {
                result *= number;
            }

            return result;
        }

        public long ArraySum(long[] numbers)
        {
            long result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }

            return result;
        }

        public void HungarianCamelIzerService(Translation translation)
        {
            
        }

        public void ReverseSith(Sith sith)
        {
            string[] reveresedText;
            reveresedText = sith.Text.Split(new char[] { ' ', '.' });
            if (reveresedText.Length % 2 == 0)
            {
                for (int i = 0; i < reveresedText.Length; i++)
                {
                    string temp;
                    temp = reveresedText[i];
                    reveresedText[i] = reveresedText[i + 1];
                    reveresedText[i + 1] = temp;
                    i += 1;
                }
            }

            sith.Text = string.Join(" ", reveresedText) + ". Err..err.err.";

        }

        public long UntilFactor(long number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        public long UntilSum(long number)
        {
            long result = 0;
            for (int i = 1; i <= number; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
