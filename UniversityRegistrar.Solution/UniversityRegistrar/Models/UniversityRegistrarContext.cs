using Microsoft.EntityFrameworkCore;

namespace UniveristyRegistrar.Models
{
  public class UniveristyRegistrarContext : DbContext
  {
    public UniveristyRegistrarContext(DbContextOptions<UniveristyRegistrarContext> options)
      : base(options)
    {

    }

    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Student>()
      .HasData(
        new Student { StudentId = 1, StudentName = "Jose", DateEnrolled = "September 27, 2016", Major = "Mathematics & Computer Science", CurrentTerm = "Fall", CurrentYear = 2016 }
        new Student { StudentId = 2, StudentName = "Anthony", DateEnrolled = "September 27, 2016", Major = "Mathematics", CurrentTerm = "Fall", CurrentYear = 2016 }
      );
    }
  }
}