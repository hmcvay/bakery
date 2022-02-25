using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int UnitCount { get; set; }
    public Bread(int unitCount)
    {
     UnitCount = unitCount;
    }

    // public int BreadPrice(int amount)
    // {
    //   Bread newBread = new Bread(amount);
    //   int totalPrice = amount * newBread.Price;
    //   return totalPrice;
    // }

    // public static int ThirdFree(int amount)
    // {
    //   for (int i = 0; i < amount.length - 1; i++)
    //   {
    //     if (amount[i] % 3 == 0)
    //     {
    //       Bread.Price = 0;
    //     }
    //   }
    // }
  }
}