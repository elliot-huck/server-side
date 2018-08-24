
using System;
using System.Collections.Generic;

namespace Classes
{
  public class Company
  {

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public HashSet<Employee> EmployeeRoster { get; set; }

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company(string companyName, DateTime dateFounded)
    {
      Name = companyName;
      CreatedOn = dateFounded;
    }

    public void Hire(Employee applicant)
    {
      this.EmployeeRoster.Add(applicant);
    }

    public void DisplayEmployees()
    {
      foreach(Employee worker in this.EmployeeRoster)
      {
        Console.WriteLine($"{worker.FirstName} {worker.LastName} works for {this.Name} as {worker.Title} since {worker.StartDate} ");
      }
    }

  }
}