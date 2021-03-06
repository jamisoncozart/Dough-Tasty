using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoughTasty.Models;

namespace DoughTasty.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void Vendor_CreateNewInstanceOfVendorWithCorrectProperties_Vendor()
    {
      Vendor epicodus1 = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students");
      Assert.AreEqual("Epicodus", epicodus1.Title);
      Assert.AreEqual("Coding Bootcamp interested in giving free bread to students", epicodus1.Description);
    }

    [TestMethod]
    public void Vendor_CreateUniqueIdForEachNewInstance_VendorId()
    {
      Vendor epicodus1 = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students");
      Vendor epicodus2 = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students");
      Vendor epicodus3 = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students");

      Assert.AreEqual(1, epicodus1.Id);
      Assert.AreEqual(2, epicodus2.Id);
      Assert.AreEqual(3, epicodus3.Id);
    }

    [TestMethod]
    public void Find_FindIndividualVendorByGivenId_Vendor()
    {
      Vendor epicodus1 = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students");
      Vendor searchedVendor = Vendor.Find(1);
      Assert.AreEqual(epicodus1, searchedVendor);
    }

    [TestMethod]
    public void Delete_DeleteIndividualVendorByGivenId_NoVendor()
    {
      Vendor epicodus1 = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students");
      bool isDeleted = Vendor.Delete(1);
      Assert.AreEqual(true, isDeleted);
      Assert.AreEqual(null, Vendor.Find(1));
    }

    [TestMethod]
    public void AddOrder_SuccessfullyAddsNewOrderToVendor_Order()
    {
      Vendor epicodus1 = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students");
      Order newOrder = new Order("Cater", 30, 30, "3/13/2020", epicodus1.Id);
      Assert.AreEqual(newOrder, epicodus1.GetAllOrders()[0]);
    }
  }
}