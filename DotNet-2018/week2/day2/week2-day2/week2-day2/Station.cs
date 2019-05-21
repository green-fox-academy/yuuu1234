using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class Station
    {
        public float gasAmount;

        public Station()
        {
            this.gasAmount = 500;
        }

        public void Refill(Car car)
        {
            this.gasAmount -= car.capacity;
            car.gasAmount += car.capacity;
        }

    }
}
