using System.Collections.Generic;

namespace ex_1
{
  public class Student : Person
  {
    public List<Exercise> AssignedExercises { get; } = new List<Exercise>();

    public Student(string first, string last)
    {
      _firstName = first;
      _lastName = last;
    }


  }
}