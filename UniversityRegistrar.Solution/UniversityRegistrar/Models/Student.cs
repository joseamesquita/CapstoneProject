namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }

    public string StudentName { get; set; }

    public string DateEnrolled { get; set; }

    public string Major { get; set; }

    public string CurrentTerm { get; set; }

    public int CurrentYear { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; }

  }
}