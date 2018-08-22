using System;
using System.Collections.Generic;

namespace Lists
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates a list of all the planets
      List<string> planetList = new List<string>() { "Mercury", "Mars" };
      planetList.Add("Jupiter");
      planetList.Add("Saturn");

      List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };
      planetList.AddRange(lastTwoPlanets);
      planetList.Insert(1, "Venus");
      planetList.Insert(2, "Earth");
      planetList.Add("Pluto");

      Console.WriteLine();
      Console.WriteLine("ALL PLANETS");
      foreach (string planet in planetList)
      {
        Console.WriteLine($"  {planet}");
      }

      // Creates a list of the terrestrial planets
      List<string> rockyPlanets = new List<string>();
      rockyPlanets.AddRange(planetList.GetRange(0, 4));

      Console.WriteLine();
      Console.WriteLine("ROCKY PLANETS");
      foreach (string rock in rockyPlanets)
      {
        Console.WriteLine($"  {rock}");
      }
      planetList.Remove("Pluto");

      // These dictionaries represent NASA missions to each of the planets
      Dictionary<string, string> mercury = new Dictionary<string, string>()
      {
        {"Messenger", "Mercury"}
      };
      Dictionary<string, string> venus = new Dictionary<string, string>()
      {
        {"Magellan", "Venus"},
        {"Pioneer", "Venus"}
      };
      Dictionary<string, string> earth = new Dictionary<string, string>()
      {
        {"(none, natch)", "Earth"}
      };
      Dictionary<string, string> mars = new Dictionary<string, string>()
      {
        {"Odyssey", "Mars"},
        {"Phoenix", "Mars"},
        {"Viking", "Mars"}
      };
      Dictionary<string, string> jupiter = new Dictionary<string, string>()
      {
        {"Galileo", "Jupiter"},
        {"Juno", "Jupiter"}
      };
      Dictionary<string, string> saturn = new Dictionary<string, string>()
      {
        {"Cassini", "Saturn"},
      };
      Dictionary<string, string> neptune = new Dictionary<string, string>()
      {
        {"Voyager", "Neptune"}
      };
      Dictionary<string, string> uranus = new Dictionary<string, string>()
      {
        {"Hubble", "Uranus"}
      };

      // Creates a list of dictionaries and adds the missions for each planet to the list
      List<Dictionary<string, string>> spaceProbes = new List<Dictionary<string, string>>();
      spaceProbes.Add(mercury);
      spaceProbes.Add(venus);
      spaceProbes.Add(earth);
      spaceProbes.Add(mars);
      spaceProbes.Add(jupiter);
      spaceProbes.Add(saturn);
      spaceProbes.Add(neptune);
      spaceProbes.Add(uranus);

      Console.WriteLine();
      Console.WriteLine("NASA MISSIONS");
      foreach (string planet in planetList)
      {
        Console.Write($"  {planet}: ");
        foreach (Dictionary<string, string> mission in spaceProbes)
        {
          foreach (KeyValuePair<string, string> probe in mission)
          {
            if (probe.Value == planet)
            {
              Console.Write($"{probe.Key} ");
            }
          }
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }
}
