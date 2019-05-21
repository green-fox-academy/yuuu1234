using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamProject
{
    public class ExamApplicationContext : DbContext
    {
        //public DbSet<Student> students { get; set; }
        public ExamApplicationContext(DbContextOptions options) : base(options)
        {

        }
    }
}
