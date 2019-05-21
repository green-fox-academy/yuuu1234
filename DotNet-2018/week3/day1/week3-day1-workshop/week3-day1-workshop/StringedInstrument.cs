using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertHall
{
    abstract class StringedInstrument:Instrument
    {
        protected  int NumberOfStrings;

        
        public abstract void Sound();

    }
}
