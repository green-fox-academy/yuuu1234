using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4Day3Workshop.Services.Student
{
    public class StudentService
    {
        private readonly List<string> names;

        public StudentService()
        {
            names = new List<string> { "Sanyi", "Lilla", "John" };
        }

        public List<string> FindAll()
        {
            return names;
        }

        public void Save(string student)
        {
            names.Add(student);
        }
    }
}
