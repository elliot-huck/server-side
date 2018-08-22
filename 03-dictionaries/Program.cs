using System;
using System.Collections.Generic;

namespace dictionaries
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> stocks = new Dictionary<string, string>();
      stocks.Add("GM", "General Motors");
      stocks.Add("CAT", "Caterpillar");
      stocks.Add("ABC", "Alphabet Company");
      stocks.Add("XYZ", "American Zipper Manufacturers");
      stocks.Add("NBA", "National Basketball Association");

      List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

      purchases.Add((ticker: "GM", shares: 2, price: 23.21));
      purchases.Add((ticker: "CAT", shares: 4, price: 17.87));
      purchases.Add((ticker: "XYZ", shares: 8, price: 19.02));
      purchases.Add((ticker: "ABC", shares: 16, price: 15.43));
      purchases.Add((ticker: "NBA", shares: 32, price: 18.07));
      purchases.Add((ticker: "CAT", shares: 64, price: 39.62));
      purchases.Add((ticker: "GM", shares: 128, price: 1.09));
      purchases.Add((ticker: "XYZ", shares: 256, price: 5.55));

      Dictionary<string, double> portfolio = new Dictionary<string, double>();

      /*
          Define a new Dictionary to hold the aggregated purchase information.
          - The key should be a string that is the full company name.
          - The value will be the valuation of each stock (price*amount)

          {
              "General Electric": 35900,
              "AAPL": 8445,
              ...
          }
      */

      // Iterate over the purchases and update the valuation for each stock
      foreach ((string ticker, int shares, double price) purchase in purchases)
      {
        // Does the company name key already exist in the report dictionary?
        string companyName = stocks[purchase.ticker];

        if (portfolio.ContainsKey(companyName))
        {
          // If it does, update the total valuation
          portfolio[companyName] += purchase.shares * purchase.price;
        }
        else
        {
          // If not, add the new key and set its value
          portfolio.Add(companyName, (purchase.shares * purchase.price));
        }
      }

      foreach (KeyValuePair<string, double> companyStocks in portfolio)
      {
        Console.WriteLine($"{companyStocks.Key}: {companyStocks.Value}");
      }

    }
  }
}
