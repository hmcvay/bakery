using System;
using Bakery.Models;

namespace Bakery
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("-⎽__⎽-⎻⎺⎺⎻-⎽__⎽--⎻⎺⎺⎻--⎽__⎽-⎻⎺⎺⎻-⎽");
      Console.WriteLine("Would you like to see our prices?");
      Console.WriteLine("Type 'Y' for YES and 'N' for NO");
      string response = Console.ReadLine().ToLower();
      if (response == "y")
      {
        Console.WriteLine("FANTASTIC!");
        Console.WriteLine("-⎽__⎽-⎻⎺⎺⎻-⎽__⎽--⎻⎺⎺⎻--⎽__⎽-⎻⎺⎺⎻-⎽");
        Console.WriteLine("Here are our prices for BREAD and PASTRY:");
      }
      else
      {
        Console.WriteLine("you make me sad (｡•́︿•̀｡)");
      }
    }
  }
}