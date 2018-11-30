using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week4Day3Workshop.Interfaces;

namespace week4Day3Workshop.Services
{
    public class UtilityService : IUtilityService
    {
        public readonly List<string> colors;
        private readonly Random random;
        public string Color { get; set; }
        public UtilityService()
        {
            colors = new List<string>
            {
                "red",
                "blue",
                "lime",
                "orange",
                "magenta"
            };

            random = new Random();
        }

        public string RandomColor()
        {
            this.Color= colors[random.Next(colors.Count)];
            return this.Color;
        }
    }
}
