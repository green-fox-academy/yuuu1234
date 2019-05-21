using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertHall
{
    class Violin:StringedInstrument
    {
        public Violin()
        {
            this.NumberOfStrings = 4;
        }

        public Violin(int str)
        {
            this.NumberOfStrings = str;
        }
        public override void Sound()
        {
            Console.WriteLine("Screech");
        }
        public override void Play()
        {
            Console.Write("Violin, the " + this.NumberOfStrings + "-stringed instrument that ");
            this.Sound();
        }

    }
}
