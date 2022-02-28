using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int UnitCount { get; set; }
    private static List<Bread> _instances = new List<Bread>{};
    public Bread(int unitCount)
    {
     UnitCount = unitCount;
     _instances.Add(this);
    }

    public static int GetUnitPrice(int unitCount)
    {
      int unitPrice = 0;
      List<int> unitList = new List<int>{};
      for(int i = 0; i <= unitCount; i++)
      {
        unitList.Add(i);
      }
      foreach(int unit in unitList)
      {
        if(unit % 3 ==0)
        {
          unitPrice += 0;
        }
        else
        {
          unitPrice += 5;
        }
      }
      return unitPrice;       
    }
  }
}