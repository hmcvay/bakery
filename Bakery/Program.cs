using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("----------------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("----------------------------------");
      Console.WriteLine("BREAD: $5 each / buy 2 get 1 FREE");
      Console.WriteLine("PASTRY: $2 each, or 3 for $5");
      Console.WriteLine("----------------------------------");
      Console.WriteLine("Would you like to buy today?");
      Console.WriteLine("Type 'Y' for YES and 'N' for NO");
      Console.WriteLine("----------------------------------");
      string response = Console.ReadLine().ToLower();
      if (response == "y")
      {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("FANTASTIC!");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Please choose PASTRY or BREAD");
        Console.WriteLine("----------------------------------");
        Start();
        static void Start()
        {
          string choice = Console.ReadLine().ToLower();
          if (choice == "bread")
          {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("BREAD: $5 each / buy 2 get 1 FREE");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Please enter how many loaves to order:");
            int breadAmount = Int32.Parse(Console.ReadLine());
            int breadAmountTotal = Bread.GetUnitPrice(breadAmount);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(breadAmount + " loaves of bread = $" + breadAmountTotal);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Would you like add more BREAD or PASTRY to your oder? or are you DONE?");
            Console.WriteLine("----------------------------------");
            Start();
          }
          else if (choice == "pastry")
          {
            Console.WriteLine("PASTRY: $2 each, or 3 for $5");
            Console.WriteLine("Please enter how many pastries to order:");
            int pastryAmount = Int32.Parse(Console.ReadLine());
            int pastryAmountTotal = Pastry.GetPastryPrice(pastryAmount);
            Console.WriteLine("----------------------------------");
            Console.WriteLine(pastryAmount + " pastries = $" + pastryAmountTotal);
            Console.WriteLine("Would you like add more BREAD or PASTRY to your oder? or are you DONE?");
            Console.WriteLine("----------------------------------");
            Start();
          }
          else if (choice == "done")
          {
            // WHY DOESN'T THIS WORK?
            //int pastryAmountTotal = Pastry.GetPastryPrice(pastryAmount);
            // int breadAmountTotal = Bread.GetUnitPrice(breadAmount);
            // int grandTotal = pastryAmountTotal + breadAmountTotal;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Your grand total is: $ + grandTotal");
            Console.WriteLine("----------------------------------");
          }
          else
          {
            Console.WriteLine("please enter valid response. Either: BREAD, PASTRY, or DONE");
            Console.WriteLine("----------------------------------");
            Start();
          }
        }
      }
      else
      {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("You make me sad (｡•́︿•̀｡)");
        Console.WriteLine("See you another time.");
        Console.WriteLine("----------------------------------");
      }
    }
  }
}