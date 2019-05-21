using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Planet> planets { get; set; }
        public DbSet<Spaceship> Spaceships { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
    }
}
