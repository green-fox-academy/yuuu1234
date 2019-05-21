using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day4_workshop
{
    class Mentor:Person
    {
        public string Level { get; set; }

        public Mentor(string name,int age,string gender,string level)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Level = level;
        }

        public Mentor():this("Jane Doe",30,"female","intermediate")
        {
            this.Level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {this.Name}, a {this.Age} year old {this.Gender} {this.Level} mentor.");
        }

    }
}
