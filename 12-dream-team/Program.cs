using System;
using System.Collections.Generic;

namespace dream_team
{
  public interface ITeammate
  {
    string FirstName { get; }
    string LastName { get; }
    string FullName { get; }
    string Specialty { get; set; }
    void Work();
  }
  public class Elliot : ITeammate
  {
    public string FirstName { get; } = "Elliot";
    public string LastName { get; } = "Huck";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "C#";
    public void Work() => Console.WriteLine($"{FirstName} draws out absurdly over-complicated diagrams before he even begins coding in {Specialty}");
  }

  public class Jordan : ITeammate
  {
    public string FirstName { get; } = "Jordan";
    public string LastName { get; } = "Williams";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "CSS";
    public void Work() => Console.WriteLine($"{FirstName} bangs his head on the keyboard as he writes all the {Specialty}");
  }

  public class Seth : ITeammate
  {
    public string FirstName { get; } = "Seth";
    public string LastName { get; } = "Dana";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "React";
    public void Work() => Console.WriteLine($"{FirstName} immediately starts cranking out a really complex tangle of code in {Specialty}");
  }

  public class Brett : ITeammate
  {
    public string FirstName { get; } = "Brett";
    public string LastName { get; } = "Shearin";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "Javascript";
    public void Work() => Console.WriteLine($"{FirstName} meticulously types each individual line of {Specialty} code");
  }

  public class Will : ITeammate
  {
    public string FirstName { get; } = "Will";
    public string LastName { get; } = "Kimball";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "JSON";
    public void Work() => Console.WriteLine($"{FirstName} pastes 73,000 lines of {Specialty} code into his project because YOLO");
  }

  public class Robert : ITeammate
  {
    public string FirstName { get; } = "Robert";
    public string LastName { get; } = "Leedy";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "Javascript";
    public void Work() => Console.WriteLine($"{FirstName} quietly types his {Specialty} code as he pines away for his former seat");
  }

  public class Team
  {
    public HashSet<ITeammate> Roster = new HashSet<ITeammate>();
    public void GetToWork()
    {
      foreach (ITeammate member in Roster)
      {
        member.Work();
      }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {

      Team clientSide = new Team()
      {
        Roster = { new Seth(), new Jordan(), new Brett() },
      };

      Team serverSide = new Team()
      {
        Roster = { new Elliot(), new Will(), new Robert() },
      };

      Console.WriteLine();
      Console.WriteLine("The Client-Side Dream Team:");
      clientSide.GetToWork();

      Console.WriteLine();
      Console.WriteLine("The Server-Side Dream Team:");
      serverSide.GetToWork();

    }
  }
}
