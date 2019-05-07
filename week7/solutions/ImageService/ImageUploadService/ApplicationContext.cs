using ImageUploadService.Models;
using Microsoft.EntityFrameworkCore;

namespace ImageUploadService
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Image> Images { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Image>()
                .HasOne(i => i.RawImage)
                .WithMany(i => i.ResizedVariants)
                .HasForeignKey("RawImageId");
            base.OnModelCreating(modelBuilder);
        }
    }
}