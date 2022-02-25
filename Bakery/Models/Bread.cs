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
  }
}