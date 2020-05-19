using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UniversityRegistrar.Models;

namespace UniveristyRegistrar.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}