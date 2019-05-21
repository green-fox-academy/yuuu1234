using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;

namespace Frontend.Interfaces
{
    public interface IFrontendService
    {
        long UntilSum(long number);
        long UntilFactor(long number);
        long ArraySum(long[] numbers);
        long ArrayMultiply(long[] numbers);
        long[] ArrayDouble(long[] numbers);
        void ReverseSith(Sith sith);
        void HungarianCamelIzerService(Translation translation);
    }
}
