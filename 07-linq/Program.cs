using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{

  public class Customer
  {
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
  }

  public class GroupedMillionaires
  {
    public string Bank { get; set; }
    public IEnumerable<string> Millionaires { get; set; }
  }

  public class Bank
  {
    public string Symbol { get; set; }
    public string Name { get; set; }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine();
      // Find the words in the collection that start with the letter 'L'
      List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
      Console.WriteLine("ALL FRUITS");
      foreach (string item in fruits)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

      List<string> Lfruits = (from item in fruits
                              where item.StartsWith("L")
                              select item).ToList();
      Console.WriteLine("L FRUITS");
      foreach (string item in Lfruits)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

      // FILTERING AND RESTRICTING:
      // Which of the following numbers are multiples of 4 or 6
      List<int> numbers = new List<int>()
      {
        15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };
      List<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0).ToList();
      Console.WriteLine("4 6 MULTIPLES");
      foreach (int item in fourSixMultiples)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();


      // ORDERING
      // Order these student names alphabetically, in descending order (Z to A)
      List<string> names = new List<string>()
      {
          "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
          "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
          "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
          "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
          "Francisco", "Tre"
      };
      List<string> descend = names.OrderByDescending(n => n).ToList();
      Console.WriteLine("STUDENTS REVERSE ABC");
      foreach (string item in descend)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

      // Build a collection of these numbers sorted in ascending order
      List<int> numbers2 = new List<int>()
      {
          15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };
      List<int> sortedNumbers2 = numbers2.OrderBy(n => n).ToList();
      Console.WriteLine("MORE NUMBERS SORTED");
      foreach (int item in sortedNumbers2)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();


      // AGGREGATE
      // Output how many numbers are in this list
      List<int> numbers3 = new List<int>()
      {
          15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };
      int numbers3Count = numbers3.Count();
      Console.WriteLine($@"THERE ARE {numbers3Count} NUMBERS IN NUMBERS3
			");

      // How much money have we made?
      List<double> purchases = new List<double>()
      {
          2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
      };
      double revenue = purchases.Sum();
      Console.WriteLine($@"WE MADE ${revenue} TODAY
			");

      // What is our most expensive product?
      List<double> prices = new List<double>()
      {
          879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
      };
      double maxPrice = prices.Max();
      Console.WriteLine($@"OUR MOST EXPENSIVE PRODUCT COSTS ${maxPrice}
			");

      /*
          Store each number in the following List until a perfect square
          is detected.

          Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
      */
      List<int> wheresSquaredo = new List<int>()
      {
          66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
      };
      // Math.Sqrt(n) % 1 == 0
      List<int> beforePerfSquare = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0).ToList();
      Console.WriteLine("ALL NUMBERS BEFORE A PERFECT SQUARE");
      foreach (int item in beforePerfSquare)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();


      // CUSTOM TYPES
      // Build a collection of customers who are millionaires
      List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

      /*
        Given the same customer set, display how many millionaires per bank.
        Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

        Example Output:
        WF 2
        BOA 1
        FTB 1
        CITI 1
      */
      var millionairesPerBank =
        from c in customers
        where c.Balance >= 1000000
        group c by c.Bank into g
        select new { BankName = g.Key, MillCount = g.Count() };
      Console.WriteLine("MILLIONAIRES PER BANK");
      foreach (var bank in millionairesPerBank)
      {
        Console.WriteLine($"{bank.BankName}: {bank.MillCount}");
      }
      Console.WriteLine();
      /*
      var groupedByBank = customers.Where(c => c.Balance >= 1000000).GroupBy(
        p => p.Bank,
        p => p.Name,
        (bank, millionaires) => new GroupedMillionaires()
        {
          Bank = bank,
          Millionaires = millionaires
        }
      )
       */

      /*
      .GroupBy(
        p => p.Bank,
        p => p.Name,
        (bank, millionaires) => new
        {
          Bank = bank,
          Millionaires = millionaires
        }
      ).ToList

       */

      // GROUP JOIN
      /*
          TASK:
          As in the previous exercise, you're going to output the millionaires,
          but you will also display the full name of the bank. You also need
          to sort the millionaires' names, ascending by their LAST name.

          Example output:
              Tina Fey at Citibank
              Joe Landy at Wells Fargo
              Sarah Ng at First Tennessee
              Les Paul at Wells Fargo
              Peg Vale at Bank of America
      */
      // Create some banks and store in a List
      List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

      var millionaireReport =
      from c in customers
      where c.Balance >= 1000000
      join b in banks on c.Bank equals b.Symbol into m
      select new { Name = c.Name, Bank = m.ToList()[0].Name };
      // Needs ToList method so that m (which is originally of type Grouping) can have list methods used on it

      Console.WriteLine("MILLIONAIRES AND THEIR BANKS");
      foreach (var customer in millionaireReport)
      {
        Console.WriteLine($"{customer.Name} at {customer.Bank}");
      }

      /*
			List<Customer> millionaireReport = customers
			.Where(t => t.Balance >= 1000000)
			.Select(c => new Customer()
			{
				Name = c.Name,
				Bank = banks.Find(b => b.Symbol == c.bank).Name
			})
			 */

    }
  }
}
