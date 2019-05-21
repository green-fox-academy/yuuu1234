using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Tree
    {
        public double WaterAmount { get; set; }
        
        public string Color { get; set; }

        public Tree(string color)
        {
            this.Color = color;
        }

        public void watering(double water)
        {
            this.WaterAmount += (water * 0.4);
        }

        public bool IfNeedWater()
        {
            if (this.WaterAmount < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
