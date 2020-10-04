using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student yourself = new Student("yourself", 1, 1, 4.0);
            Student someone = new Student("Larry", 2, 1, 3.5);
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(yourself);
            listOfStudents.Add(someone);
            Teacher teacher = new Teacher("Bob", "Smith", "Science", 1);

            Course course = new Course(teacher, "Science Stuff 101", listOfStudents);

            Console.WriteLine($"Teacher: {course.Teacher.FirstName} {course.Teacher.LastName}");
            Console.WriteLine($"Course : {course.CourseTitle}");
            Console.WriteLine("Students:");
            foreach (Student student in course.Students)
            {
                Console.WriteLine($"{student.Name} ID[{student.StudentId}] Credits[{student.NumberOfCredits}] GPA[{student.Gpa}]");
            }
        }
    }
}
