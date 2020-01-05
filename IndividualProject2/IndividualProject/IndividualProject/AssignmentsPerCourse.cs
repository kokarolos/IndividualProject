using System;
using System.Collections.Generic;

namespace IndividualProject
{
    class AssignmentsPerCourse
    {
        public Course c { get; set; }
        public AssignmentsPerCourse(Course c, List<Assignment> assigmentCourse)
        {
            this.c = c;
            c.courseAssigments = assigmentCourse;
        }
        public void Print()
        {
            foreach (var obj in c.courseAssigments)
            {
                Console.WriteLine("\t"+c.title);
                obj.SimplePrint();
            }
        }
    }
}

