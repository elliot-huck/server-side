
namespace ex_1
{
    public class Exercise
    {
      public string Name {get; set;}
      public string GitHubURL {get; set;}
      public string Language {get; set;}

      public Exercise(string name, string url, string language)
      {
        Name = name;
        GitHubURL = url;
        Language = language;
      }
    }
}