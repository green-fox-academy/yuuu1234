using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class Animal
    {
        public int hunger;
        public int thirst;

        public Animal(int hunger, int thirst)
        {
            this.hunger = hunger;
            this.thirst = thirst;
        }
        public Animal():this(50,50)
        {
            
        }

        public void Eat()
        {
            this.hunger --;
        }

        public void Drink()
        {
            this.hunger--;
        }

        public void Play()
        {
            this.hunger ++;
            this.thirst++;
        }

    }
}
