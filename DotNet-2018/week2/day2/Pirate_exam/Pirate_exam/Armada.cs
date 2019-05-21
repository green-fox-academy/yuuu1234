using System;
using System.Collections.Generic;
using System.Text;

namespace Pirate_exam
{
    class Armada
    {
        public List<Ship> armada=new List<Ship>();

        public void FillArmada(Ship ship)
        {
            this.armada.Add(ship);
        }
        public bool War(Armada other)
        {
            bool result=false;
            foreach (Ship ship in this.armada)
            {
                foreach (Ship enemy in other.armada)
                {
                    if (ship.Battle(enemy))
                    {
                        result=true;
                        continue;
                        
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }

                
            }

            return result;
        }

    }
}
