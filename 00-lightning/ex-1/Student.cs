using System;
using System.Collections.Generic;

namespace ex_1
{
  public class Student
  {
    private string _firstName;
    private string _lastName;

    public string FullName { get => $"{_firstName} {_lastName}";}

    public Student(string first, string last)
    {
      _firstName = first;
      _lastName = last;
    }

    List<Exercise> Exercises = new List<Exercise>();

  }
}