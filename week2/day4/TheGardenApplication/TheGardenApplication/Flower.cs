using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TheGardenApplication
{
    class Flower
    {
        public double WaterAmount { get; set; }
        public string Color { get; set; }

        public Flower(string color)
        {
            this.Color = color;
        }
        public void watering(double water)
        {
            this.WaterAmount += (water * 0.75);
        }

        public bool IfNeedWater()
        {
            if (this.WaterAmount < 5)
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
