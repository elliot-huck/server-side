using System;
using System.Collections.Generic;

namespace _08_family_dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

      myFamily.Add("cousin", new Dictionary<string, string>()
      {
        {"name", "Tabitha"},
        {"age", "25"}
      });

			myFamily.Add("brother", new Dictionary<string, string>()
      {
        {"name", "Joel"},
        {"age", "21"}
      });

			myFamily.Add("father", new Dictionary<string, string>()
      {
        {"name", "Wayne"},
        {"age", "55"}
      });

foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
{
	string relationship = familyMember.Key;
	string name = familyMember.Value["name"];
	string age = familyMember.Value["age"];
	Console.WriteLine($"{name} is my {relationship} and is {age} years old");
}


    }
  }
}
