using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day4_workshop
{
    class Student:Person
    {
        
        public  string PreviousOrganization { get; set; }

       
        public int SkippedDays { get; set; }

        public Student(string name, int age,string gender,string previous)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.PreviousOrganization = previous;
            this.SkippedDays = 0;
        }

        public Student() : this("Jane Doe", 30, "female", "The School of Life")
        {
            
        }
        public override void GetGoal()
        {
            Console.WriteLine("My goal is:Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {this.Name}  a {this.Age} year old {this.Gender} from {this.PreviousOrganization} " +
                              $"who skipped {this.SkippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            this.SkippedDays += numberOfDays;
        }
    }
}
