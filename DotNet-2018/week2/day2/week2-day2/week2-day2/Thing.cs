using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day2
{
    class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }

        public bool IfComplete()
        {
            return Completed;
        }

        public string getName()
        {
            return Name;
        }
    }
}
