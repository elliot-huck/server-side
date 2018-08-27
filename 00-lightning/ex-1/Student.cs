using System.Collections.Generic;

namespace ex_1
{
  public class Student
  {
    private string _firstName;
    private string _lastName;
    public string FullName { get => $"{_firstName} {_lastName}"; }
    List<Exercise> AssignedExercises { get; } = new List<Exercise>();

    public Student(string first, string last)
    {
      _firstName = first;
      _lastName = last;
    }


  }
}