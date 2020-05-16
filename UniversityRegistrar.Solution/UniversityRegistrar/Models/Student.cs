using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    [Required]
    public int StudentId { get; set; }

    [Required]
    public string StudentName { get; set; }

    [Required]
    public string DateEnrolled { get; set; }

    [Required]
    public string Major { get; set; }

    [Required]
    public string CurrentTerm { get; set; }

    [Required]
    public int CurrentYear { get; set; }

  }
}