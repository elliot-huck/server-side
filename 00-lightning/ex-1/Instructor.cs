using System.Collections.Generic;

namespace ex_1
{
  public class Instructor : Person
  {
    public Instructor(string first, string last)
    {
      _firstName = first;
      _lastName = last;
    }

    public void Assign(Exercise assignment, Student pupil)
    {
      pupil.AssignedExercises.Add(assignment);
    }

    /*
    pupil.AssignedExercises.Add(new AssignedExercise(assignment, this, DateTime.Now))
     */

  }
}