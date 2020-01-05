using System;
using System.Collections.Generic;

namespace IndividualProject
{
    class StudentsPerCourse
    {
        public Course c { get; set; }
        public StudentsPerCourse(Course c, List<Student> listOfStudents)
        {
            this.c = c;
            c.courseStudents = listOfStudents;
        }
        public void Print()
        {
            Console.WriteLine(c.title);
            foreach (var obj in c.courseStudents)
            {
                Console.Write("\t");
                obj.Print();
            }
        }
    }
}
