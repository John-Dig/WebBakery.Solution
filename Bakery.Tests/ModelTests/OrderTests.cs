using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod] //o1
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Order", "weekly order", 150, new DateTime(2023, 3, 6));
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod] //o2
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Monday's Muffins";
      //Act
      Order newOrder = new Order(title, "weekly order", 150, new DateTime(2023, 3, 6));
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }

    //   [TestMethod] //o
    // public void 
    // {
    //   //arrange

    //   //act

    //   //assert

    // }
    //   [TestMethod] //o
    // public void 
    // {
    //   //arrange

    //   //act

    //   //assert

    // }
  }
}
