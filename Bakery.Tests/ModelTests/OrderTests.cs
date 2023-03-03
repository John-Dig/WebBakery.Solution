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
      Order newOrder = new Order("test Order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
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
