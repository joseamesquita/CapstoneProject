using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {

    [Display(Name = "Student ID")]
    public int StudentId { get; set; }

    // [Required]
    [Display(Name = "Student Name")]
    public string StudentName { get; set; }

    [Display(Name = "Date Enrolled")]
    public string DateEnrolled { get; set; }

    [Display(Name = "Programming Language")]
    public string Major { get; set; }

    [Display(Name = "Current Term")]
    public string CurrentTerm { get; set; }

    [Display(Name = "Current Year")]
    public string CurrentYear { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; }
  }
}