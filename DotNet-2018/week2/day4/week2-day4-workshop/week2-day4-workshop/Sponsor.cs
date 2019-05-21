using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day4_workshop
{
    class Sponsor:Person
    {
    public string Company { get; set; }
    public  int HiredStudents { get; set; }

        public Sponsor(string name,int age,string gender, string company)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Company = company;
            this.HiredStudents = 0;
        }

        public Sponsor():base("Jane Doe",33,"Female")
        {
            this.Company = "Google";
            this.HiredStudents = 0;
        }

        public void Hire()
        {
            this.HiredStudents++;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {this.Name}, a {this.Age} year old {this.Gender} who represents {this.Company} and hired {this.HiredStudents} students so far.");
        }
    }
}
