using System;
using System.Collections.Generic;

namespace ex_1
{
  public class Student
  {
    private string firstName;
    private string lastName;

    public string FullName() => $"{firstName} {lastName}";

    public Student(string first, string last)
    {
      firstName = first;
      lastName = last;
    }

    List<Exercise> Exercises = new List<Exercise>();

  }
}