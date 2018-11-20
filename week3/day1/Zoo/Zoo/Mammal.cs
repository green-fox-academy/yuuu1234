using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammal : Animal
    {
        public int danger;
        public int hungry;

        public Mammal(string name):base(name)
        {
           
        }
        public override string WantChild()
        {
            return " want a child from uterus";
        }
    }
}
