using Microsoft.AspNetCore.Mvc;
using UniveristyRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UniveristyRegistrar.Controllers
{
  public class CoursesController : Controller
  {
    private readonly UniveristyRegistrarContext _db;

    public CoursesController(UniveristyRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Course> model = _db.Courses.UniveristyRegistrar();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Details(int id)
    {
      Course thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    public ActionResult Edit(int id)
    {
      Course thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    public ActionResult Delete(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
      _db.Courses.Remove(thisCourse);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}