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


      //arrange
      //act
      //assert
      //arrange
      //act
      //assert
      //arrange
      //act
      //assert

  }
}
