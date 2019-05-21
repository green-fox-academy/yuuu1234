using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public List<Thing> GetThingList()
        {
            return Things;
        }
    }
}
