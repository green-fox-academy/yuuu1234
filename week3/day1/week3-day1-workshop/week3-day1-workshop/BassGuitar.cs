using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertHall
{
    class BassGuitar:StringedInstrument
    {
        public BassGuitar()
        {
            this.NumberOfStrings = 4;
        }

        public BassGuitar(int str)
        {
            this.NumberOfStrings = str;
        }
        public override void Sound()
        {
            Console.WriteLine("Duum-duum-duum");
        }
        public override void Play()
        {
            Console.Write("bass, the " + this.NumberOfStrings + "-stringed instrument that ");
            this.Sound();
        }

    }
}
