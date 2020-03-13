using System;
using Microsoft.AspNetCore.Mvc;
using DoughTasty.Models;
using System.Collections.Generic;
namespace DoughTasty.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index() { return View(); }
  }
}