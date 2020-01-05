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
        //Method responsible for displaying students who need to submit one or more assignments on the same calendar week
        public void PrintDates(DateTime dt)
        {
            //Setting dt to friday if dt day is Saturday or Sunday
            if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                dt = dt.AddDays(-1);
            }
            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                dt = dt.AddDays(-2);
            }
            foreach (var obj in c.courseAssigments)
            {
                //Calculating dates differnce
                var dayDiff = dt-obj.subDateTime;
                var yearDiff = obj.subDateTime.Year - dt.Year;
                var monthDiff = obj.subDateTime.Month - dt.Month;
                if (dayDiff.Days <=4 && yearDiff == 0 && monthDiff == 0) 
                {
                    obj.Print();
                }
            }
        }
    }
}

