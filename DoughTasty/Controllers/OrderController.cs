using System;
using Microsoft.AspNetCore.Mvc;
using DoughTasty.Models;
using System.Collections.Generic;
namespace DoughTasty.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor currentVendor = Vendor.Find(id);
      return View(currentVendor);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int id, string title, string date, int numBread, int numPastries)
    {
      Order newOrder = new Order(title, numBread, numPastries, date, id);
      //redirects to VendorController's Index route
      return RedirectToAction("Show", "Vendor", id);
    }
  }
}