using System;
using System.Collections.Generic;

namespace _09_nickelback
{
  class Program
  {
    static void Main(string[] args)
    {
      HashSet<(string name, string band)> allSongs = new HashSet<(string name, string band)>(){
      ("Rockstar", "Nickelback"),
      ("Photograph", "Nickelback"),
      ("Stairway to Heaven", "Led Zeppelin"),
      ("The Ocean", "Led Zeppelin"),
      ("Free Will", "Rush"),
      ("Spirit of the Radio", "Rush"),
      ("Money", "Pink Floyd"),
    };

		foreach (var song in allSongs)
		{
				if (song.band == "Nickelback")
				{
						Console.Write("No ");
				}
		}



      List<(string, string)> goodSongs = new List<(string, string)>() { };


    }
  }
}
