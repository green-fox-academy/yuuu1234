using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Spaceship
    {
        public long Id { get; set; }
        public string Planet { get; set; }
        public int Max_capacity { get; set; }
        public int Utilization { get; set; }
    }
}
