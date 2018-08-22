using System;
using System.Collections.Generic;

namespace _02_tuples
{
  class Program
  {
    static void Main(string[] args)
    {
      List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

      (string product, double amount, int quantity) hammer = ("Hammer", 9.99, 1);
      (string product, double amount, int quantity) nail = ("Nails", 0.99, 3);
      (string product, double amount, int quantity) drill = ("Power drill", 49.99, 1);
      (string product, double amount, int quantity) screw = ("Screws", 5.99, 2);
      (string product, double amount, int quantity) glue = ("Glue", 4.99, 6);

      transactions.Add(hammer);
      transactions.Add(nail);
      transactions.Add(drill);
      transactions.Add(screw);
      transactions.Add(glue);

      int TotalProductsSold = 0;
      double TotalRevenue = 0;
      foreach ((string product, double amount, int quantity) t in transactions)
      {
        // Logic goes here to look up quantity and amount in each transaction
				TotalProductsSold += t.quantity;
				TotalRevenue += t.quantity * t.amount;
      }
			Console.WriteLine($"We sold {TotalProductsSold} products for a total revenue of ${TotalRevenue}");
    }
  }
}
