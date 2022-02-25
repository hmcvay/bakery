using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("-⎽__⎽-⎻⎺⎺⎻-⎽__⎽--⎻⎺⎺⎻--⎽__⎽-⎻⎺⎺⎻-⎽");
      Console.WriteLine("BREAD: $5 each / buy 2 get 1 FREE");
      Console.WriteLine("PASTRY: $2 each, or 3 for $5");
      Console.WriteLine("Would you like to buy today?");
      Console.WriteLine("Type 'Y' for YES and 'N' for NO");
      string response = Console.ReadLine().ToLower();
      if (response == "y")
      {
        Console.WriteLine("FANTASTIC!");
        Console.WriteLine("-⎽__⎽-⎻⎺⎺⎻-⎽__⎽--⎻⎺⎺⎻--⎽__⎽-⎻⎺⎺⎻-⎽");
        Console.WriteLine("Please choose PASTRY or BREAD");
        Start();
        static void Start()
        {
          string choice = Console.ReadLine().ToLower();
          if (choice == "bread")
          {
            Console.WriteLine("BREAD: $5 each / buy 2 get 1 FREE");
            Console.WriteLine("Please enter how many loaves to order:");
            int userInput = Int32.Parse(Console.ReadLine());
            int breadAmountTotal = Bread.GetUnitPrice(userInput);
            Console.WriteLine(userInput + " loaves of bread comes out to $" + breadAmountTotal);
            Console.WriteLine("Would you like add more BREAD or PASTRY to your oder?");
            Start();
          }
          else if (choice == "pastry")
          {

          }
          else if (choice == "done")
          {
            
          }
          else
          {
            Console.WriteLine("please enter valid response. Either BREAD or PASTRY or DONE");
            Start();
          }
        }
      }
      else
      {
        Console.WriteLine("you make me sad (｡•́︿•̀｡)");
      }
    }
  }
}