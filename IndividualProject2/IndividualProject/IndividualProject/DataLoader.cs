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
        public DateTime dt { get; set; }

        public DataLoader()
        {
            //new Students
            var s1 = new Student("Karol", "Koniewicz", new DateTime(1994, 2, 1), 2090.04);
            var s2 = new Student("Sara", "Mara", new DateTime(1994, 2, 21), 2190.04);
            var s3 = new Student("John", "Luke", new DateTime(1974, 10, 11), 2652.54);
            var s4 = new Student("Peter", "Parker", new DateTime(2004, 2, 1), 2090.24);
            var s5 = new Student("Tom", "Denis", new DateTime(2002, 1, 2), 2290.04);
            var s6 = new Student("John", "Fleet", new DateTime(1995, 2, 2), 2490.24);
            var s7 = new Student("Nick", "Flick", new DateTime(1996, 1, 1), 1690.14);
            var s8 = new Student("Anna", "Peek", new DateTime(2000, 11, 12), 1290.05);
            var s9 = new Student("Dana", "Kay", new DateTime(1992, 12, 22), 2490.02);
            var s10 = new Student("Sofia", "Meek", new DateTime(1995, 2, 12), 2091.02);
            var s11= new Student("Annie", "Bolt", new DateTime(2002, 10, 12), 100.04);
            var s12 = new Student("John", "Harris", new DateTime(1965, 11, 2), 290.04);
            var s13 = new Student("Jay", "Felton", new DateTime(1996, 6, 2), 292.04);
            var s14 = new Student("Pit", "Dalton", new DateTime(1982, 4, 2), 2590.04);


            var c1 = new Course("CB9", "C#", "Full-Time", new DateTime(2020, 1, 1), new DateTime(2020, 5, 2));
            var c2 = new Course("CB10", "Java", "Full-Time", new DateTime(2020, 5, 2), new DateTime(2020, 6, 2));
            var c3 = new Course("CB11", "C#", "Part-Time", new DateTime(2020, 6, 2), new DateTime(2021, 1, 1));

            var t1 = new Trainer("Ben", "Delgado", "OOP");
            var t2 = new Trainer("Thomas", "Zac", "Robust Programming");
            var t3 = new Trainer("Alfred", "Matias", "Design Patterns");
            var t4 = new Trainer("Pepa", "Aniston", "Sql");
            var t5 = new Trainer("Tom", "Hanks", "Algorithms");
            var t6 = new Trainer("Kylian", "Trunks", ".NET");
            var t7 = new Trainer("Steve", "Jobs", "ECDL");
            var t8 = new Trainer("Fray", "Duck", "Reverse Engineering");

            //New Assigments
            var a1 = new Assignment("Private School", "Do the implementation of private school structure", new DateTime(2020, 1, 1), 50.0f, 100.0f);
            var a2 = new Assignment("Elephant", "Do the implementation of elephant structure", new DateTime(2020, 1, 15), 50.0f, 100.0f);
            var a3 = new Assignment("Dog", "Do the implementation of dog structure", new DateTime(2020, 3, 10), 50.0f, 100.0f);

            var a4 = new Assignment("Calculator", "Do the implementation of calculator structure", new DateTime(2020, 4, 11), 50.0f, 100.0f);
            var a5 = new Assignment("Snake Game", "Do the implementation of Snake Game structure", new DateTime(2020, 5, 15), 50.0f, 100.0f);
            var a6 = new Assignment("Tetris", "Do the implementation of Tetris structure", new DateTime(2020, 10, 12), 50.0f, 100.0f);


            //Student list
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);
            students.Add(s11);
            students.Add(s12);
            students.Add(s13);
            students.Add(s14);

            //CourseList
            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);

            //TrainersList
            trainers.Add(t1);
            trainers.Add(t2);
            trainers.Add(t3);
            trainers.Add(t4);
            trainers.Add(t5);
            trainers.Add(t6);
            trainers.Add(t7);
            trainers.Add(t8);

            //AssignmentsList
            assignments.Add(a1);
            assignments.Add(a2);
            assignments.Add(a3);
            assignments.Add(a4);
            assignments.Add(a5);
            assignments.Add(a6);

            //Students CourseList
            List<Student> course1Students = new List<Student>() { s1, s5,s6,s9,s12,s10,s7 };
            List<Student> course2Students = new List<Student>() { s1, s2, s3,s7,s8,s10,s13,s14, };
            List<Student> course3Students = new List<Student>() { s1, s4,s8,s11 ,s14,s7};

            //Relate Students per Courses
            var spc1 = new StudentsPerCourse(c1, course1Students);
            var spc2 = new StudentsPerCourse(c2, course2Students);
            var spc3 = new StudentsPerCourse(c3, course3Students);

            studentsPerCourse.Add(spc1);
            studentsPerCourse.Add(spc2);
            studentsPerCourse.Add(spc3);

            //Courses Per Student responsible for students with more than one course output
            List<Course> student1Courses = new List<Course>() { c1, c2, c3 };
            List<Course> student2Courses = new List<Course>() { c2 };
            List<Course> student3Courses = new List<Course>() { c2 };
            List<Course> student4Courses = new List<Course>() { c3 };
            List<Course> student5Courses = new List<Course>() { c1 };
            List<Course> student6Courses = new List<Course>() { c1 };
            List<Course> student7Courses = new List<Course>() { c1,c2,c3 };
            List<Course> student8Courses = new List<Course>() { c2,c3 };
            List<Course> student9Courses = new List<Course>() { c1};
            List<Course> student10Courses = new List<Course>() { c1,c2 };
            List<Course> student11Courses = new List<Course>() { c3 };
            List<Course> student12Courses = new List<Course>() { c1 };
            List<Course> student13Courses = new List<Course>() { c2 };
            List<Course> student14Courses = new List<Course>() { c2,c3 };

            var cps1 = new CoursesPerStudent(s1, student1Courses);
            var cps2 = new CoursesPerStudent(s2, student2Courses);
            var cps3 = new CoursesPerStudent(s3, student3Courses);
            var cps4 = new CoursesPerStudent(s4, student4Courses);
            var cps5 = new CoursesPerStudent(s5, student5Courses);
            var cps6 = new CoursesPerStudent(s6, student6Courses);
            var cps7 = new CoursesPerStudent(s7, student7Courses);
            var cps8 = new CoursesPerStudent(s8, student8Courses);
            var cps9 = new CoursesPerStudent(s9, student9Courses);
            var cps10 = new CoursesPerStudent(s10, student10Courses);
            var cps11 = new CoursesPerStudent(s11, student11Courses);
            var cps12 = new CoursesPerStudent(s12, student12Courses);
            var cps13 = new CoursesPerStudent(s13, student13Courses);
            var cps14 = new CoursesPerStudent(s14, student14Courses);


            coursesPerStudents.Add(cps1);
            coursesPerStudents.Add(cps2);
            coursesPerStudents.Add(cps3);
            coursesPerStudents.Add(cps4);
            coursesPerStudents.Add(cps5);
            coursesPerStudents.Add(cps6);
            coursesPerStudents.Add(cps7);
            coursesPerStudents.Add(cps8);
            coursesPerStudents.Add(cps9);
            coursesPerStudents.Add(cps10);
            coursesPerStudents.Add(cps11);
            coursesPerStudents.Add(cps12);
            coursesPerStudents.Add(cps13);
            coursesPerStudents.Add(cps14);


            //Trainers CourseList
            List<Trainer> course1Trainers = new List<Trainer>() { t1, t2,t8 };
            List<Trainer> course2Trainers = new List<Trainer>() { t4 ,t5,t6};
            List<Trainer> course3Trainers = new List<Trainer>() { t4, t3 ,t4,t7};
    
            var tpc1 = new TrainersPerCourse(c1, course1Trainers);
            var tpc2 = new TrainersPerCourse(c2, course2Trainers);
            var tpc3 = new TrainersPerCourse(c3, course3Trainers);

            trainersPerCourse.Add(tpc1);
            trainersPerCourse.Add(tpc2);
            trainersPerCourse.Add(tpc3);
           
            //Assigments CourseList
            List<Assignment> course1Assigments = new List<Assignment>() { a1,a4 };
            List<Assignment> course2Assigments = new List<Assignment>() { a2 ,a5};
            List<Assignment> course3Assigments = new List<Assignment>() { a3,a6 };

            //Relate assigments per Course
            var apc1 = new AssignmentsPerCourse(c1, course1Assigments);
            var apc2 = new AssignmentsPerCourse(c2, course2Assigments);
            var apc3 = new AssignmentsPerCourse(c3, course3Assigments);

            assigmentPerCourse.Add(apc1);
            assigmentPerCourse.Add(apc2);
            assigmentPerCourse.Add(apc3);

        }
       
        //method that display all students
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

        //method that display all Courses
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
        //method that display all Assigments
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
        //method that display all Trainers
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
        //method that display Students Per Course
        public void PrintStudentPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students Per Course");
            Console.WriteLine();
            foreach (var obj in studentsPerCourse)
            {
                obj.Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        //method that display Trainers Per Course
        public void PrintTrainersPerCourse()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Trainers Per Course");
            Console.WriteLine();
            foreach (var obj in trainersPerCourse)
            {
                obj.Print();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        //method that display Assigments Per Course
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
        //method that prints Assignments per student
        public void PrintAssigmentsPerStudent()
        {
            foreach (var obj in coursesPerStudents)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(obj.s.firstName);
                Console.WriteLine();
                foreach (var item in assigmentPerCourse)
                {
                    if (obj.s.courses.Contains(item.c))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        item.Print();
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
        //Method that prints 
        public void CheckDates()
        {
            foreach (var obj in coursesPerStudents)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(obj.s.firstName);
                Console.WriteLine();
                foreach (var item in assigmentPerCourse)
                {
                    if (obj.s.courses.Contains(item.c))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        item.PrintDates(dt);
                    }
                }
            }
        }
    }
}

