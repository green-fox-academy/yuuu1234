using BlogApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>()
                .HasOne(p => p.Category)
                .WithMany(c => c.BlogPosts)
                .HasForeignKey(p => p.CId);
        }
    }
}