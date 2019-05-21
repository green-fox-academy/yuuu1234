using System;
using System.Collections.Generic;
using System.Text;

namespace Fly
{
    class Helicopter : Vehicle, Flyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public void Land()
        {
            Console.WriteLine("Landing");
        }

        public void TakeOff()
        {
            Console.WriteLine("Taking off");
        }
        
    }
}
