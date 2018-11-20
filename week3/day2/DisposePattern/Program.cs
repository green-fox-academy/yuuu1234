using System;

namespace DisposePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new FileLogger("log.txt");
            logger.Log("First log message");
            logger.Log("Second log message");
            //logger.Dispose();
        }

       
    }
}
