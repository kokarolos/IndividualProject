using System;
using System.Collections.Generic;

namespace IndividualProject
{
    class Course
    {
        public string title { get; set; }
        public string stream { get; set; }
        public string type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<Student> courseStudents { get; set; }
        public List<Trainer> courseTrainers { get; set; }
        public List<Assignment> courseAssigments { get; set; }



        public Course() { }
        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            this.title = title;
            this.stream = stream;
            this.type = type;
            this.startDate = startDate;
            this.endDate = endDate;
        }
        public void Print()
        {
            Console.WriteLine($"Course {title} {stream} {type} starts at: {startDate.ToString("dd/MM/yyy")} and ends : {endDate.ToString("dd/MM/yyy")}");
        }
        public void SimplePrint()
        {
            Console.WriteLine($"Course {title} {stream} {type}");
        }
    }
}
