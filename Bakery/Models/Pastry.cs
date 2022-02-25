using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCount { get; set; }
    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
    }

    public static int GetPastryPrice(int pastryCount)
    {
      int price = 0;
      return price;
    }
  }
}