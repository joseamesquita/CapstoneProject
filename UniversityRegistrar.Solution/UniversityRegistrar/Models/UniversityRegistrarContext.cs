using Microsoft.EntityFrameworkCore;

namespace UniversityRegistrar.Models
{
  public class UniversityRegistrarContext : DbContext
  {
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }

    public UniversityRegistrarContext(DbContextOptions options) : base(options) { }


    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //   builder.Entity<Student>()
    //   .HasData(
    //     new Student { StudentId = 1, StudentName = "Jose", DateEnrolled = "September 27, 2016", Major = "Mathematics & Computer Science", CurrentTerm = "Fall", CurrentYear = 2016 }
    //     new Student { StudentId = 2, StudentName = "Anthony", DateEnrolled = "September 27, 2016", Major = "Mathematics", CurrentTerm = "Fall", CurrentYear = 2016 }
    //   );
    // }
  }
}