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

  public class Brett
  {
    public string FirstName { get; } = "Brett";
    public string LastName { get; } = "Shearin";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "Javascript";
    public void Work() => Console.WriteLine($"{FirstName} meticulously types each individual line of {Specialty} code");
  }

  public class Will
  {
    public string FirstName { get; } = "Will";
    public string LastName { get; } = "Kimball";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "JSON";
    public void Work() => Console.WriteLine($"{FirstName} pastes 73,000 lines of {Specialty} code into his project because YOLO");
  }

  public class Robert
  {
    public string FirstName { get; } = "Robert";
    public string LastName { get; } = "Leedy";
    public string FullName { get => $"{FirstName} {LastName}"; }
    public string Specialty { get; set; } = "Javascript";
    public void Work() => Console.WriteLine($"{FirstName} quietly types his {Specialty} code as he pines away for his former seat");
  }

  class Program
  {
    static void Main(string[] args)
    {
      Elliot elliot = new Elliot();
      Seth seth = new Seth();
      Jordan jordan = new Jordan();
      Brett brett = new Brett();
      Will will = new Will();
      Robert robert = new Robert();

      elliot.Work();
      Console.WriteLine();

      seth.Work();
      Console.WriteLine();

      jordan.Work();
      Console.WriteLine();

      robert.Work();
      Console.WriteLine();

      brett.Work();
      Console.WriteLine();

      will.Work();
      Console.WriteLine();

    }
  }
}
