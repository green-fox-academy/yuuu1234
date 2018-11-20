using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Animal
    {
        protected string name;
        protected int age;
        protected string gender;
        protected int hungry;

        public Animal()
        {
            
        }
        public Animal(string name)
        {
            this.name=name;
        }

       
        public abstract string WantChild();

        public string GetName()
        {
            return this.name;
        }
    }
}
