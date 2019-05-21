using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTests
{
    class Program
    {
        static void Main(string[] args)
        {
            CABGame game=new CABGame();
            foreach (var i in game.Answer)
            {
                Console.Write(i+" ");
            }
            
            game.StartPlay();
        }
    }
}
