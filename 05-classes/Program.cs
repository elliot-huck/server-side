using System;

namespace Classes
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create an instance of a company. Name it whatever you like.
      Company myCompany = new Company("Death & Taxis", new DateTime(2018, 8, 20));


      // Create three employees
      Employee elliot = new Employee()
      {
        FirstName = "Elliot",
        LastName = "Huck",
        Title = "CEO",
        StartDate = new DateTime(2018, 8, 20),
      };

      Employee alice = new Employee()
      {
        FirstName = "Alice",
        LastName = "Anderson",
        Title = "Accountant",
        StartDate = new DateTime(2018, 8, 21),
      };

      Employee bob = new Employee()
      {
        FirstName = "Bob",
        LastName = "Brown",
        Title = "Businessman",
        StartDate = new DateTime(2018, 8, 22),
      };

      // Assign the employees to the company
      myCompany.Hire(elliot);
      myCompany.Hire(alice);
      myCompany.Hire(bob);

      // Iterate the company's employee list and generate the simple report shown above
      myCompany.DisplayEmployees();

    }
  }
}
