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

    public static int ThirdFree(int amount)
    {
      //need loop through amount... 
      // if amount % 3 == 0, price = 0?
    }
  }
}