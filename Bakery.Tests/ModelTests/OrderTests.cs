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

    [TestMethod] //o3
    public void GetDescriptionGetPriceGetDate_ReturnsDescriptionPriceAndDate_StringIntDateTime()
    {
      //arrange
      string title = "Monday's Muffins";
      string description = "like 100 Muffins";
      int price = 150;
      var date = new DateTime(2023, 3, 6);

      //act
      Order newOrder = new Order(title, description, price, date);
      string resultDesc = newOrder.Description;
      int resultP = newOrder.Price;
      DateTime resultD = newOrder.Date;
      //assert


      Assert.AreEqual(description, resultDesc);
      Assert.AreEqual(price, resultP);
      Assert.AreEqual(date, resultD);
    }
    [TestMethod] //o4
    public void SetAllProperties_SetsAllProperties_StringStringIntDateTime()
    {
      //arrange
      string title = "Monday's Muffins";
      string description = "like 100 Muffins";
      int price = 150;
      var date = new DateTime(2023, 3, 6);
      Order newOrder = new Order(title, description, price, date);

      //act      
      string updatedTitle = "Tuesday's Trash";
      string updatedDesc = "like a bunch of stale Muffins";
      int updatedPrice = 33;
      var updatedDate = new DateTime(2023, 3, 7);
      newOrder.Title = updatedTitle;
      newOrder.Description = updatedDesc;
      newOrder.Price = updatedPrice;
      newOrder.Date = updatedDate;
      string resultTitle = newOrder.Title;
      string resultDesc = newOrder.Description;
      int resultPrice = newOrder.Price;
      var resultDate = newOrder.Date;
      //assert

      Assert.AreEqual(updatedTitle, resultTitle);
      Assert.AreEqual(updatedDesc, resultDesc);
      Assert.AreEqual(updatedPrice, resultPrice);
      Assert.AreEqual(updatedDate, resultDate);
    }
    [TestMethod] //o5
    public void Find_FindsInstanceOfOrder_Order()
    {
      //arrange
      Order newOrder1 = new Order("test Order1", "weekly order1", 150, new DateTime(2023, 3, 6));
      Order newOrder2 = new Order("test Order2", "weekly order2", 159, new DateTime(2023, 3, 7));
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //act
      Order result = Order.Find(2);

      //assert
      Assert.AreEqual(newOrder2, result);
    }
    [TestMethod] //o6
    public void GetAll_GetsAllInstancesOfOrder_OrderList()
    {
      //arrange
      Order newOrder1 = new Order("test Order1", "weekly order1", 150, new DateTime(2023, 3, 6));
      Order newOrder2 = new Order("test Order2", "weekly order2", 159, new DateTime(2023, 3, 7));
    List<Order> newList = new List<Order> { newOrder1, newOrder2};

    //act
    List<Order> result = Order.GetAll();

    //assert
    CollectionAssert.AreEqual(newList, result);
  }
}
}

