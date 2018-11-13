using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class Farm
    {
        public List<Animal> animalList=new List<Animal>();
        public int slot;

        public Farm()
        {
            this.slot = 100;
        }

        public void breed(Animal a)
        {
            if (this.slot > 0)
            {
                this.animalList.Add(a);
                slot--;
            }

        }

        public void Slaughter()
        {
            int least =int.MaxValue;
            int remove=0;
            for(int i=0; i<this.animalList.Count;i++)
            {
                if (this.animalList[i].hunger < least)
                {
                    least = this.animalList[i].hunger;
                    remove = i;
                }
            }
            animalList.RemoveAt(remove);
        }
    }
}
