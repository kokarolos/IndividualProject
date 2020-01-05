using System;
using System.Collections.Generic;
namespace IndividualProject
{
    class DataLoader
    {
        public List<Student> students { get; set; } = new List<Student>();
        public List<Course> courses { get; set; } = new List<Course>();
        public List<Assignment> assignments { get; set; } = new List<Assignment>();
        public List<Trainer> trainers { get; set; } = new List<Trainer>();
        public List<StudentsPerCourse> studentsPerCourse { get; set; } = new List<StudentsPerCourse>();
        public List<TrainersPerCourse> trainersPerCourse { get; set; } = new List<TrainersPerCourse>();
        public List<AssignmentsPerCourse> assigmentPerCourse { get; set; } = new List<AssignmentsPerCourse>();
        public List<CoursesPerStudent> coursesPerStudents { get; set; } = new List<CoursesPerStudent>();

        public DateTime inputDate { get; set; } = new DateTime();

        public DataLoader()
        {
            //new Students
            var s1 = new Student("Karol", "Koniewicz", new DateTime(1994, 2, 1), 2090.04);
            var s2 = new Student("Sara", "Mara", new DateTime(1994, 2, 21), 2190.04);
            var s3 = new Student("John", "Luke", new DateTime(1974, 10, 11), 2652.04);
            var s4 = new Student("Peter", "Parker", new DateTime(2004, 2, 1), 2090.04);
            var s5 = new Student("Tom", "Denis", new DateTime(2002, 1, 2), 2290.04);


            //Student list
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            //new Courses
            var c1 = new Course("CB9", "C#", "Full-Time", new DateTime(2020, 1, 1), new DateTime(2020, 5, 2));
            var c2 = new Course("CB10", "Java", "Full-Time", new DateTime(2020, 5, 2), new DateTime(2020, 6, 2));
            var c3 = new Course("CB11", "C#", "Part-Time", new DateTime(2020, 6, 2), new DateTime(2021, 1, 1));

            //CourseList
            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);

            //Students CourseList
            List<Student> course1Students = new List<Student>() { s1 ,s5 };
            List<Student> course2Students = new List<Student>() { s1, s2, s3 };
            List<Student> course3Students = new List<Student>() { s1, s4 };

            //Relate Students per Courses
            var spc1 = new StudentsPerCourse(c1, course1Students);
            var spc2 = new StudentsPerCourse(c2, course2Students);
            var spc3 = new StudentsPerCourse(c3, course3Students);

            studentsPerCourse.Add(spc1);
            studentsPerCourse.Add(spc2);
            studentsPerCourse.Add(spc3);

            //Courses Per Student responsible for students with more than one course output
            List<Course> student1Courses = new List<Course>() { c1, c2, c3};
            List<Course> student2Courses = new List<Course>() { c2 };
            List<Course> student3Courses = new List<Course>() { c2 };
            List<Course> student4Courses = new List<Course>() { c3 };
            List<Course> student5Courses = new List<Course>() { c1};

            var cps1 = new CoursesPerStudent(s1, student1Courses);
            var cps2 = new CoursesPerStudent(s2, student2Courses);
            var cps3 = new CoursesPerStudent(s3, student3Courses);
            var cps4 = new CoursesPerStudent(s4, student4Courses);
            var cps5 = new CoursesPerStudent(s5, student5Courses);


            coursesPerStudents.Add(cps1);
            coursesPerStudents.Add(cps2);
            coursesPerStudents.Add(cps3);
            coursesPerStudents.Add(cps4);
            coursesPerStudents.Add(cps5);

            //New Trainers
            var t1 = new Trainer("Ben", "Delgado", "OOP");
            var t2 = new Trainer("Thomas", "Zac", "Robust Programming");
            var t3 = new Trainer("Alfred", "Matias", "Design Patterns");
            var t4 = new Trainer("Pepa", "Aniston", "Sql");

            //TrainersList
            trainers.Add(t1);
            trainers.Add(t2);
            trainers.Add(t3);
            trainers.Add(t4);

            //Trainers CourseList
            List<Trainer> course1Trainers = new List<Trainer>() { t1, t2 };
            List<Trainer> course2Trainers = new List<Trainer>() { t4 };
            List<Trainer> course3Trainers = new List<Trainer>() { t4,t3 };

            var tpc1 = new TrainersPerCourse(c1, course1Trainers);
            var tpc2 = new TrainersPerCourse(c2, course2Trainers);
            var tpc3 = new TrainersPerCourse(c3, course3Trainers);

            trainersPerCourse.Add(tpc1);
            trainersPerCourse.Add(tpc2);
            trainersPerCourse.Add(tpc3);

            //New Assigments
            var a1 = new Assignment("Private School", "Do the implementation of private school structure", new DateTime(2020, 1, 10), 50.0f, 100.0f);
            var a2 = new Assignment("Elephant", "Do the implementation of elephant structure", new DateTime(2020, 1, 15), 50.0f, 100.0f);
            var a3 = new Assignment("Dog", "Do the implementation of dog structure", new DateTime(2020, 3, 10), 50.0f, 100.0f);

            assignments.Add(a1);
            assignments.Add(a2);
            assignments.Add(a3);
            
            //Assigments CourseList
            List<Assignment> course1Assigments = new List<Assignment>() { a1};
            List<Assignment> course2Assigments = new List<Assignment>() { a2 };
            List<Assignment> course3Assigments = new List<Assignment>() { a3 };

            //Relate assigments per Course
            var apc1 = new AssignmentsPerCourse(c1, course1Assigments);
            var apc2 = new AssignmentsPerCourse(c2, course2Assigments);
            var apc3 = new AssignmentsPerCourse(c3, course3Assigments);

            assigmentPerCourse.Add(apc1);
            assigmentPerCourse.Add(apc2);
            assigmentPerCourse.Add(apc3);

        }

        public void PrintStudents()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Students");
            Console.WriteLine();
            foreach (var obj in students)
            {
                obj.Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");

        }

        public void PrintCourses()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Courses:");
            Console.WriteLine();
            foreach (var obj in courses)
            {
                obj.Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        public void PrintAssigments()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Assigments:");
            Console.WriteLine();
            foreach (var obj in assignments)
            {
                obj.Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        public void PrintTrainers()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Trainers:");
            Console.WriteLine();
            foreach (var obj in trainers)
            {
                obj.Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        public void PrintCoursesPerStudent()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student Per Course");
            Console.WriteLine();
            foreach (var obj in studentsPerCourse)
            {
                obj.Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        public void PrintTrainersPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Trainer Per Course");
            Console.WriteLine();
            foreach (var obj in trainersPerCourse)
            {
                obj.Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        public void PrintAssigmentsPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Assigment Per Course");
            Console.WriteLine();
            foreach (var obj in assigmentPerCourse)
            {
                obj.Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }

        //method that prints students with more than 1 courses
        public void PrintStudentCountOfCourses()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("List Of Students That Belong To More Than One Course");
            Console.WriteLine();
            foreach (var obj in coursesPerStudents)
            {
                if (obj.IsBelonging())
                {
                    obj.s.SimplePrint();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");

        }
        public void PritAssigmentsPerStudent()
        {
            foreach(var obj in coursesPerStudents)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(obj.s.firstName);
                Console.WriteLine();
                foreach (var item in assigmentPerCourse)
                {
                    if(obj.s.courses.Contains(item.c))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        item.Print();
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        public void CheckDates(DateTime inputDate)
        {
            this.inputDate = inputDate;
            if (inputDate.DayOfWeek == DayOfWeek.Saturday)
            {
                inputDate = inputDate.AddDays(-1);
            }
            if (inputDate.DayOfWeek == DayOfWeek.Sunday)
            {
                inputDate = inputDate.AddDays(-2);
            }
        }
    }
}

