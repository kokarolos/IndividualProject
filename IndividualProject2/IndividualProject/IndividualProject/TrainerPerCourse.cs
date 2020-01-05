using System;
using System.Collections.Generic;

namespace IndividualProject
{
    class TrainersPerCourse
    {
        public Course c { get; set; }
        public TrainersPerCourse(Course c, List<Trainer> trainerList)
        {
            this.c = c;
            c.courseTrainers = trainerList;
        }
        public void Print()
        {
            Console.WriteLine(c.title);
            foreach (var obj in c.courseTrainers)
            {
                Console.Write("\t");
                obj.Print();
            }
        }
    }
}

