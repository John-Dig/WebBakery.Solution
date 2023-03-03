using System.Collections.Generic;

namespace Bakery.Models
{
  public class Order
  {
    public string Name { get; set; }
    // public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string name)
    {
      Name = name;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}