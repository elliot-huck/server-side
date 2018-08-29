using System;

namespace dream_team
{
  public class Elliot
  {
    public string FirstName { get; } = "Elliot";
    public string LastName { get; } = "Huck";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "C#";
    public void Work() => Console.WriteLine($"{FirstName} draws out absurdly over-complicated diagrams before he even begins coding in {Specialty}");
  }

  public class Jordan
  {
    public string FirstName { get; } = "Jordan";
    public string LastName { get; } = "Williams";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "CSS";
    public void Work() => Console.WriteLine($"{FirstName} bangs his head on the keyboard as he writes all the {Specialty}");
  }

  public class Seth
  {
    public string FirstName { get; } = "Seth";
    public string LastName { get; } = "Dana";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "React";
    public void Work() => Console.WriteLine($"{FirstName} immediately starts cranking out a really complex tangle of code in {Specialty}");
  }

  
  class Program
  {
    static void Main(string[] args)
    {
      Elliot elliot = new Elliot();
      elliot.Work();

    }
  }
}
