using System;
using Microsoft.AspNetCore.Mvc;
using DoughTasty.Models;
using System.Collections.Generic;
namespace DoughTasty.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { return View(); }
  }
}