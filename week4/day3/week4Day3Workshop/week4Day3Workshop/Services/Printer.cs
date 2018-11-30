using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week4Day3Workshop.Interfaces;

namespace week4Day3Workshop.Services
{
    public class Printer : IPrinter
    {
        public string Log(string message)
        {
            return " --- " + DateTime.Now + " MY PRINTER SAYS --- " + message;
        }

        
    }
}
