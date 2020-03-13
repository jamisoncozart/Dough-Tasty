using System;
using Microsoft.AspNetCore.Mvc;
using DoughTasty.Models;
using System.Collections.Generic;
namespace DoughTasty.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index() 
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New() { return View(); }
  }
}