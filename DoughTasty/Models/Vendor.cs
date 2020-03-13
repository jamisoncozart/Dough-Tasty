using System;
using System.Collections.Generic;

namespace DoughTasty.Models
{
  public class Vendor
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public List<Order> Orders {get; set;}
    public int Id {get; set;}
    private static int _currentId = 0;
    public static List<Vendor> AllVendors {get; set;}
    public Vendor(string title, string description)
    {
      //instantiate
    }

    public static void ClearAll()
    {
      AllVendors.Clear();
    }
  }
}