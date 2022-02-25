using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    public int Price { get; }
    public Bread(int amount)
    {
     Amount = amount;
     Price = 5;
    }

    public static int BreadPrice(int amount)
    {
      // int price = Bread.Price;
      int totalPrice = amount * newBread.Price;
      return totalPrice;
    }

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