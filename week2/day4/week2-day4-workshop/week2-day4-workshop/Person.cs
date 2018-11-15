using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace week2_day4_workshop
{
     class Person
    {
        
        public string Name { get; set; }
        
        public int Age { get; set; }
        
        public  string Gender { get; set; }

        public Person(string name, int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Person():this("Jane Doe",33,"Female")
        {

        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {this.Name}, a {this.Age} years old {this.Gender}");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

    }

}
