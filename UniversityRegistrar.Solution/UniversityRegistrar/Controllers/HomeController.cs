using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UniveristyRegistrar.Models;

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