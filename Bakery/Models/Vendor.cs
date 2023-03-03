using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public int Id { get; }

    public Vendor(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}