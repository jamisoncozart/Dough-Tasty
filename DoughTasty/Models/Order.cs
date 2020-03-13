using System;

namespace DoughTasty.Models
{
  public class Order
  {
    public string Title {get; set;}
    public int NumberOfBread {get; set;}
    public int NumberOfPastry {get; set;}
    public string Date {get; set;}
    public int Price {get; set;}
    public Order(string title, int numBread, int numPastry, string date, int vendorId)
    {
      Title = title;
      NumberOfBread = numBread;
      NumberOfPastry = numPastry;
      Date = date;
      Price = (numBread + numPastry) * 2;
      Vendor.Find(vendorId).AddOrder(this);
    }
  }
}