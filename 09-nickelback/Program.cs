using System;
using System.Collections.Generic;
using System.Linq;

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

      List<(string name, string band)> goodSongs = new List<(string, string)>();

      foreach (var song in allSongs)
      {
        if (song.band != "Nickelback")
        {
          goodSongs.Add(song);
        }
      }

      Console.WriteLine();
      Console.WriteLine("Good Songs:");
      foreach (var goodSong in goodSongs)
      {
        Console.WriteLine($"'{goodSong.name}' by {goodSong.band}");
      }


      List<(string name, string band)> badSongs = allSongs.Except(goodSongs).ToList();

      Console.WriteLine();
      Console.WriteLine("Nickelback Songs:");
      foreach (var badSong in badSongs)
      {
        Console.WriteLine($"'{badSong.name}' by {badSong.band}");
      }
      Console.WriteLine();


    }
  }
}
