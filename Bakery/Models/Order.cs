using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Order //Order Class Constructor
  {
    public string Title { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };
    public string Description {get; set;}
    public int Price {get; set;}
    public DateTime Date { get; set; }

    public Order(string title, string description, int price, DateTime date) //Order Object Constructor
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}