using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor //Vendor Class Constructor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public int Id { get; }//removed set?
    public List<Order> Orders {get; set;}

    public Vendor(string name) //Vendor Object Constructor
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {} ;
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }
}