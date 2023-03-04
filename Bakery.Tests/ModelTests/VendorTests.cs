using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]  //v1
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod] //v2
    public void GetName_ReturnsName_String()
    {
      //arrange
      string name = "test vendor";
      Vendor newVendor = new Vendor(name);
      //act
      string result = newVendor.Name;

      //assert
      Assert.AreEqual(name, result);
    }
    [TestMethod] //v3
    public void GetId_ReturnsVendorId_Int()
    {
      //arrange
      string name = "test vendor";
      Vendor newVendor = new Vendor(name);
      //act
      int result = newVendor.Id;
      //assert
      Assert.AreEqual(1, result);
    }

    [TestMethod] //v4
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Suzy's Cafe";
      string name02 = "Mari's Boutique";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod] //v5
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //arrange
      string name01 = "Suzy's Cafe";
      string name02 = "Mari's Boutique";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //act
      Vendor result = Vendor.Find(2);

      //assert
      Assert.AreEqual(newVendor2, result);
    }
    //----------------start here
    // [TestMethod] //v6
    // public void AddOrder_AssociatesOrderWithVendor_OrderList()
    // {
    //   //Arrange
    //   string orderTitle = "Monday's Complete Order.";
    //   Order newOrder = new Order(orderTitle);
    //   List<Order> newList = new List<Order> { newOrder };
    //   string name = "Work";
    //   Vendor newOrder = new Vendor(name);
    //   newOrder.AddOrder(newOrder);

    //   //Act
    //   List<Order> result = newVendor.Orders;

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    //  [TestMethod] //v
    // public void 
    // {
    //   //arrange

    //   //act

    //   //assert

    // }
  }
}
