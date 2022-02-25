using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCount { get; set; }
    private static List<Pastry> _instances = new List<Pastry>{};
    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
      _instaces.Add(this);
    }

    public static int GetPastryPrice(int pastryCount)
    {
      int price = 0;
      return price;
    }
  }
}