using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAndLinq
{
    class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Fox(string name,string type,string color)
        {
            this.Name = name;
            this.Type = type;
            this.Color = color;
        }
    }
}
