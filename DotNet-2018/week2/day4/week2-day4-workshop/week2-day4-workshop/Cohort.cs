using System;
using System.Collections.Generic;
using System.Text;

namespace week2_day4_workshop
{
    class Cohort:Person
    {
        public string Name { get; set; }

        public List<Student> Students { get; set; }
        public List<Mentor> Mentors { get; set; }

        public Cohort(string name)
        {
            this.Name = name;
            this.Mentors=new List<Mentor>();
            this.Students=new List<Student>();

        }

        public void AddStudent(Student s)
        {
            this.Students.Add(s);
        }

        public void AddMentor(Mentor m)
        {
            this.Mentors.Add(m);
        }

        public void Info()
        {
            Console.WriteLine($"The {this.Name} cohort has {this.Students.Count} students and {this.Mentors.Count} mentors");
        }

    }
}
