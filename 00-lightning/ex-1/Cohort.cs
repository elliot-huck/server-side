using System.Collections.Generic;

namespace ex_1
{
  public class Cohort
  {
    public int Number { get; set; }
    public List<Student> StudentList { get; set; } = new List<Student>();
    public List<Instructor> InstructorList { get; set; } = new List<Instructor>();

  }
}