using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCount { get; set; }
    // private static List<Pastry> _instances = new List<Pastry>{};
    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
      // _instaces.Add(this);
    }

    public static int GetPastryPrice(int pastryCount)
    {
      int price = 0;
      List<int> pastryList = new List<int>{};
      for(int i = 0; i <= pastryCount; i++)
      {
        pastryList.Add(i);
      }
      foreach(int pastry in pastryList)
      {
        if(pastry % 3 == 0)
        {
          int groupOfThree = pastry / 3;
          price = groupOfThree * 5;
        }
        else
        {
          price +=2;
        }
      }
      return price;
    }
  }
}