using System.Collections.Generic;

namespace ex_1
{
  public class Cohort
  {
    public int Number { get; set; }
    List<Student> StudentList { get; } = new List<Student>();
    List<Instructor> InstructorList { get; } = new List<Instructor>();

  }
}