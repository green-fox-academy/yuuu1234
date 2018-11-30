using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AircraftsCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft aircraft1=new Aircraft("F15");
            aircraft1.Refill(100);
        }
    }
}
