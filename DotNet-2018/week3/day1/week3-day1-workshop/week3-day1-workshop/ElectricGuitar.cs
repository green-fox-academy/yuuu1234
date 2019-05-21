using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConcertHall
{
    class ElectricGuitar:StringedInstrument
    {

        public ElectricGuitar()
        {
            this.NumberOfStrings = 6;
        }

        public ElectricGuitar(int str)
        {
            this.NumberOfStrings = str;
        }

        public override void Play()
        {
            Console.Write("Electric Guitar, the "+this.NumberOfStrings+"-stringed instrument that ");
            this.Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("twangs");
        }
    }
}
