using Microsoft.EntityFrameworkCore;
using EventTicketing.Models;

namespace EventTicketing.Data
{
    public class ETDbContext : DbContext
    {
        public ETDbContext(DbContextOptions<ETDbContext> options) : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }
        //public DbSet<Exam> Exams { get; set; }
        //public DbSet<Question> Questions { get; set; }
        //public DbSet<Score> Scores { get; set; }
        //public DbSet<Student> Students { get; set; }
    }
}
