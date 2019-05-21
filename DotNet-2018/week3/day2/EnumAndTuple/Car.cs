using System;
using System.Collections.Generic;
using System.Text;

namespace EnumAndTuple
{
    class Car
    {
        public CarType Type { get; set; }
        public CarColor Color{ get; set; }
        public enum CarType
        {
            hatchback,
            sedan,
            suv,
            mpv,
            crossover,
            coupe
        }

        public enum CarColor
        {
            red,
            silver,
            black,
            purple,
            gray,
            pink
        }

        public Car(CarType type,CarColor color)
        {
            this.Type = type;
            this.Color = color;

        }
    }
}
