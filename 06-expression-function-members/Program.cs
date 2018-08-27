using System;
using System.Collections.Generic;

namespace _06_expression_function_members
{
  class Program
  {
    public class Bug
    {
      /*
          You can declare a typed public property, make it read-only,
          and initialize it with a default value all on the same
          line of code in C#. Readonly properties can be set in the
          class' constructors, but not by external code.
      */
      public string Name { get; } = "";
      public string Species { get; } = "";
      public ICollection<string> Predators { get; } = new List<string>();
      public ICollection<string> Prey { get; } = new List<string>();

      // Convert this readonly property to an expression member
      public string FormalName
      {
        get => $"{Name} the {Species}";
      }

      // Class constructor
      public Bug(string name, string species, List<string> predators, List<string> prey)
      {
        Name = name;
        Species = species;
        Predators = predators;
        Prey = prey;
      }

      // Convert this method to an expression member
      public string PreyList() => string.Join(", ", Prey);

      // Convert this method to an expression member
      public string PredatorList() => string.Join(", ", Predators);

      // Convert this to expression method (hint: use a C# ternary)
      public string Eat(string food) =>
      (Prey.Contains(food)) ? $"{Name} ate the {food}." : $"{Name} is still hungry.";

    }


    static void Main(string[] args)
    {

      Bug smaug = new Bug("Smaug", "Dragonfly",
      new List<string>(){"frog", "bird"},
      new List<string>(){"mosquito", "gnat", "fly"});
      Console.WriteLine(smaug.FormalName);
			Console.WriteLine();
			Console.Write("Prey: ");
			Console.WriteLine(smaug.PreyList());
			Console.Write("Predators: ");
			Console.WriteLine(smaug.PredatorList());
			Console.WriteLine();
			Console.WriteLine(smaug.Eat("steak"));
			Console.WriteLine(smaug.Eat("mosquito"));

    }
  }
}
