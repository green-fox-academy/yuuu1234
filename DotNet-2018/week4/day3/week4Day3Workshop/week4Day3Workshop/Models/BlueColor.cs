using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week4Day3Workshop.Interfaces;
namespace week4Day3Workshop.Models
{
    public class BlueColor : IColor
    {
        private string color;

        public BlueColor()
        {
            this.color = "blue";
        }

        public string PrintColor()
        {
            return $"It is {color} in color";
        }
    }
}
