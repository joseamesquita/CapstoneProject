using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UniveristyRegistrar.Models;
using Microsoft.EntityFrameworkCore;

namespace UniveristyRegistrar.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StudentsController : ControllerBase
  {
    private UniveristyRegistrarContext _db;

    public StudentsController(UniveristyRegistrarContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Student>> Get(string firstName, string lastName, string studentId, string major, string currentTerm, string currentYear)
    {
      var query = _db.Students.AsQueryable();

      if (firstName != null)
      {
        query = query.Where(entry => entry.FirstName == firstName);
      }
      if (lastName != null)
      {
        query = query.Where(entry => entry.LastName == lastName);
      }
      if (studentId != null)
      {
        query = query.Where(entry => entry.StudentId == studentId);
      }
      if (major != null)
      {
        query = query.Where(entry => entry.Major == major);
      }
      if (currentTerm != null)
      {
        query = query.Where(entry => entry.CurrentTerm == currentTerm);
      }
      if (currentYear != null)
      {
        query = query.Where(entry => entry.CurrentYear == currentYear);
      }
      return query.ToList();
    }

  }
}