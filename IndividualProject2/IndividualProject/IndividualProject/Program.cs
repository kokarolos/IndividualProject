using System;
using System.Collections.Generic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new DataLoader(); // So data will load first
            Console.WriteLine("For synthetic data press 1 for userinput press 2");
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                SyntheticMenu();
                var menuChoice = Convert.ToInt32(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        Console.SetWindowSize(160, 50);
                        d.PrintStudents();

                        break;
                    case 2:
                        d.PrintCourses();
                        break;
                    case 3:
                        Console.SetWindowSize(160, 50);
                        d.PrintAssigments();
                        break;
                    case 4:
                        d.PrintTrainers();
                        break;
                    case 5:
                        Console.SetWindowSize(160, 50);
                        d.PrintStudentPerCourse();
                        break;
                    case 6:
                        d.PrintTrainersPerCourse();
                        break;
                    case 7:
                        d.PrintAssigmentsPerCourse();
                        break;
                    case 8:
                        d.PrintStudentCountOfCourses();
                        break;
                    case 9:
                        Console.SetWindowSize(160, 50);
                        d.PrintAssigmentsPerStudent();
                        break;
                    default: SyntheticMenu();
                        break;
                }
                Console.WriteLine("Press key backspace to go back or ESC to quit ");
                ConsoleKeyInfo key = Console.ReadKey();
               
                //DateTime dt = new DateTime(2020, 3,11);
                //d.dt = dt;
                //d.CheckDates();

            }
        }

        public static void InputMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1.Create new Course");
            Console.WriteLine("2.Create new Student");
            Console.WriteLine("3.Create new Trainer");
            Console.WriteLine("4.Create new Assigment");
        }
        public static void SyntheticMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.View All Students");
            Console.WriteLine("2.View All Courses");
            Console.WriteLine("3.View All Assigments");
            Console.WriteLine("4.View All Trainers");
            Console.WriteLine("5.View Students Per Course");
            Console.WriteLine("6.View Trainers Per Course");
            Console.WriteLine("7.View Assigments Per Course");
            Console.WriteLine("8.View Students with more than one Course");
            Console.WriteLine("9.View Assigments Per Student");

        }
    }
}

