using System.Collections.Generic;
using SchoolManagementSystem.Tools;
using System.Linq;

namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public Student(string name, 
            string postname, string givenname)
        {
            Name = name;
            Postname = postname;
            Givenname = givenname;
            Enrollments = new List<Enrollment>();
        }

        public string Name { get; private set; }
        public string Postname { get; private set; }
        public string Givenname { get; private set; }
        public List<Enrollment> Enrollments { get; private set; }

        public override string ToString() 
            => $"{Name} {Postname} {Givenname}";

        public void UpdateName(string name,
            string postname, 
            string givenname)
        {
            Name = name;
            Postname = postname;
            Givenname = givenname;
        }

        public string EnrollIn(Course course)
        {
            // foreach (var item in Enrollments)
            // {
            //     if(item.Course.Name == course.Name)
            //         return $"Already enrolled in {course.Name}";
            // }

            var first = Enrollments
                .FirstOrDefault(a => a.Course.Name == course.Name);
            if(first != null)
                return $"Already enrolled in {course.Name}";

            var enrollment = 
                new Enrollment(this, course);
            Enrollments.Add(enrollment);
            return "OK";
        }

        public Result<Course> Disenroll(string courseName)
        {
            // foreach (var item in Enrollments)
            // {
            //     if(item.Course.Name == courseName)
            //     {
            //         Enrollments.Remove(item);
            //         return Result
            //             .Success(item.Course);
            //     }
            // }

            var first = Enrollments
                .FirstOrDefault(e => e.Course.Name == courseName);
            if(first != null)
            {
                Enrollments.Remove(first);
                return Result.Success(first.Course);
            }
            return Result
                .Failure<Course>($"Not enrolled in {courseName}");
        }
    }
}
