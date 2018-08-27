using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort c26 = new Cohort();
            c26.Number = 26;

            Instructor steve = new Instructor("Steve", "Brownlee");
            Instructor jisie = new Instructor("Jisie", "David");
            Instructor emily = new Instructor("Emily", "Lemmon");
            Instructor jordan = new Instructor("Jordan", "Castelloe");
            c26.InstructorList.Add(steve);
            c26.InstructorList.Add(jisie);
            c26.InstructorList.Add(emily);
            c26.InstructorList.Add(jordan);


            Student elliot = new Student("Elliot", "Huck");
            Student seth = new Student("Seth", "Dana");
            Student michael = new Student("Michael", "Robert");
            Student leah = new Student("Leah", "Gwin");
            Student adelaide = new Student("Adelaide", "Yoder");
            c26.StudentList.Add(elliot);
            c26.StudentList.Add(seth);
            c26.StudentList.Add(michael);
            c26.StudentList.Add(leah);
            c26.StudentList.Add(adelaide);

            Exercise ex1 = new Exercise("Exercise 1", "www.github.com/one", "C#");
            Exercise ex2 = new Exercise("Exercise 2", "www.github.com/two", "C#");
            Exercise ex3 = new Exercise("Exercise 3", "www.github.com/three", "C#");

            steve.Assign(ex1, elliot);

        }
    }
}
