using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Spaceship
    {
        public long SpaceshipId { get; set; }
        public Planet Planet { get; set; }
        public long? PlanetId { get; set; }
        public int Max_capacity { get; set; }
        public int Utilization { get; set; }


    }
}
