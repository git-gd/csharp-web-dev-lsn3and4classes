using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string CourseTitle { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        Course(Teacher teacher, string courseTitle, List<Student> students)
        {
            Teacher = teacher;
            CourseTitle = courseTitle;
            Students = students;
        }
    }
}
