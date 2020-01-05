using System;
using System.Collections.Generic;


namespace IndividualProject
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public double tuitionFees { get; set; }
        public List<Course> courses { get; set; }

        public Student() { }
        public Student(string firstName, string lastName, DateTime dateOfBirth, double tuitionFees)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.tuitionFees = tuitionFees;
        }
        public void Print()
        {
            Console.WriteLine($"Name:{firstName}  LastName:{lastName}  DateOfBirth: {dateOfBirth.ToShortDateString()} TuitionFees:{tuitionFees}");
        }
        public void SimplePrint()
        {
            Console.WriteLine($"\tName:{firstName}  LastName:{lastName}");
        }

    }
}
