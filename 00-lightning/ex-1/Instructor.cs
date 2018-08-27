using System.Collections.Generic;

namespace ex_1
{
  public class Instructor
  {
    private string _firstName;
    private string _lastName;
    public string FullName { get => $"{_firstName} {_lastName}"; }

    public Instructor(string first, string last)
    {
      _firstName = first;
      _lastName = last;
    }

    public void Assign(Exercise assignment, Student pupil)
    {
      pupil.AssignedExercises.Add(assignment);
    }

  }
}