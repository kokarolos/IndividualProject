using System.Collections.Generic;

namespace IndividualProject
{
    class CoursesPerStudent
    {
        public Student s { get; set; }

        public CoursesPerStudent(Student s , List<Course> studentCourse)
        {
            this.s = s;
            s.courses = studentCourse;
        }
        public bool IsBelonging() => s.courses.Count > 1;
    }
}
