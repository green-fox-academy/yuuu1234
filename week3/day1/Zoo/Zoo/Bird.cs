using System;
using System.Collections.Generic;
using System.Text;
using Fly;
namespace Zoo
{
    class Bird : Animal,IFlyable
    {
        public Bird(string name):base(name)
        {
            
        }

        public override string WantChild()
        {
            return  " want a child from an egg";
        }

        void Land()
        {
            Console.WriteLine("landing");
        }

        void Fly()
        {
            Console.WriteLine("Flying");
        }

        void TakeOff()
        {
            Console.WriteLine("Taking off");
        }


    }
}
