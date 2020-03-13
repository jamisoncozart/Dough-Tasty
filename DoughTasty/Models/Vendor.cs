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
    private static List<Vendor> _allVendors = new List<Vendor>();
    public Vendor(string title, string description)
    {
      _currentId++;
      Id = _currentId;
      Title = title;
      Description = description;
      _allVendors.Add(this);
    }

    public static void ClearAll()
    {
      _allVendors.Clear();
      _currentId = 0;
    }
  }
}