using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class FleetOfThings
    {
        public static void Main1(string[] args)
        {
            var fleet = new Fleet();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            Thing thing1 =new Thing("Get milk");
            fleet.Add(thing1);
            Thing thing2 = new Thing("Remove the obstacles");
            fleet.Add(thing2);
            Thing thing3 = new Thing("Stand up");
            thing3.Complete();
            fleet.Add(thing3);
            Thing thing4 = new Thing("Eat lunch");
            thing4.Complete();
            fleet.Add(thing4);
            PrintThings(fleet);


        }

        static void PrintThings(Fleet f)
        {
            foreach (Thing i in f.GetThingList())
            {
                if (i.IfComplete())
                {
                    Console.WriteLine("[X] "+i.getName());
                }
                else
                {
                    Console.WriteLine("[ ] "+i.getName());
                }
            }
        }
    }
}
