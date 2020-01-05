using System;
using System.Collections.Generic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For synthetic data press 1 for userinput press 2");
            var userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput == 1)
            {
                var d = new DataLoader();
                //d.PrintCourses();
                //d.PrintStudents();
                //d.PrintAssigments();
                //d.PrintTrainers();
                //d.PrintCoursesPerStudent();
                //d.PrintTrainersPerCourse();
                //d.PrintAssigmentsPerCourse();
                //d.PrintStudentCountOfCourses();
                //d.PritAssigmentsPerStudent();
                DateTime dt = Convert.ToDateTime(Console.ReadLine());
                d.CheckDates(dt);

            }



        }

        public static void MenuOptions()
        {
            Console.WriteLine("1.Create new Course");
            Console.WriteLine("2.Create new Student");
            Console.WriteLine("3.Create new Trainer");
            Console.WriteLine("4.Create new Assigment");
        }
        public static List<Course> FillCourseList()
        {
            List<Course> fillCourse = new List<Course>();
            Console.WriteLine("How many Courses y want to create");
            var countOfCourses = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < countOfCourses; i++)
            {

                Console.WriteLine("Title");
                var title = Console.ReadLine();
                Console.WriteLine("Stream");
                var stream = Console.ReadLine();
                Console.WriteLine("Starting Date");
                var startDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Ending date");
                var endDate = Convert.ToDateTime(Console.ReadLine());
                if (startDate > endDate)
                {
                    throw new Exception("Please insert correct date");

                }
                fillCourse.Add(new Course(title, null, stream, startDate, endDate));
            }
            return fillCourse;
        }
        public static List<Student> FillStudentList()
        {
            List<Student> fillStudent = new List<Student>();

            Console.WriteLine("How many students you want to create ?");
            var countOfStudents = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < countOfStudents; i++)
            {
                Console.WriteLine("Name");
                var firstName = Console.ReadLine();
                Console.WriteLine("Lastname");
                var lastName = Console.ReadLine();
                Console.WriteLine("Date of birth");
                var dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Tution fees");
                var tuitionFees = Convert.ToDouble(Console.ReadLine());
                fillStudent.Add(new Student(firstName, lastName, dateOfBirth, tuitionFees));
            }
            return fillStudent;
        }
    }

}

