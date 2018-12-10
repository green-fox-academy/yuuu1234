using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week5Day2.Models;

namespace Week5Day2
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
