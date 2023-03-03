using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string name)
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