using JobFormApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobFormApi.Data
{
    public class JobDbContext : DbContext
    {
        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Field> Fields { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>()
                .HasMany(job => job.Sections)
                .WithOne(section => section.Job)
                .HasForeignKey(section => section.JobId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Section>()
                .HasMany(section => section.Fields)
                .WithOne(field => field.Section)
                .HasForeignKey(field => field.SectionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}