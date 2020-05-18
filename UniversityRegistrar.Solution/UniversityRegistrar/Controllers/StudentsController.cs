using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UniveristyRegistrar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UniveristyRegistrar.Controllers
{
  public class StudentsController : Controller
  {
    private UniveristyRegistrarContext _db;

    public StudentsController(UniveristyRegistrarContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Student> model = _db.Students.Include(student => student.Course).ToList();
      return View(model);
    }

    public ActionResult Create(Student student)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }

    public ActionResult Delete(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      return View(thisStudent);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
      _db.Students.Remove(thisStudent);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }






    // [HttpGet]
    // public ActionResult<IEnumerable<Student>> Get(string firstName, string lastName, string studentId, string major, string currentTerm, string currentYear)
    // {
    //   var query = _db.Students.AsQueryable();

    //   if (firstName != null)
    //   {
    //     query = query.Where(entry => entry.FirstName == firstName);
    //   }
    //   if (lastName != null)
    //   {
    //     query = query.Where(entry => entry.LastName == lastName);
    //   }
    //   if (studentId != null)
    //   {
    //     query = query.Where(entry => entry.StudentId == studentId);
    //   }
    //   if (major != null)
    //   {
    //     query = query.Where(entry => entry.Major == major);
    //   }
    //   if (currentTerm != null)
    //   {
    //     query = query.Where(entry => entry.CurrentTerm == currentTerm);
    //   }
    //   if (currentYear != null)
    //   {
    //     query = query.Where(entry => entry.CurrentYear == currentYear);
    //   }
    //   return query.ToList();
    // }


    // [HttpPost]
    // public void Post([FromBody] Student student)
    // {
    //   _db.Students.Add(student);
    //   _db.SaveChanges();
    // }
    // // GET api/students/1
    // [HttpGet("{id}")]
    // public ActionResult<Student> Get(int id)
    // {
    //   return _db.Students.FirstOrDefault(entry => entry.StudentId == id);
    // }
    // [HttpPut("{id}")]
    // public void Put(int id, [FromBody] Student student)
    // {
    //   student.StudentId = id;
    //   _db.Entry(student).State = EntityState.Modified;
    //   _db.SaveChanges();
    // }
    // [HttpDelete]
    // public void Delete(int id)
    // {
    //   var studentToDelete = _db.Students.FirstOrDefault(entry => entry.StudentId == id);
    //   _db.Students.Remove(studentToDelete);
    //   _db.SaveChanges();
    // }

  }
}