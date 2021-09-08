using SchoolManagementSystem.Models;
using static System.Console;

namespace SchoolManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Course maths = new(null);

            WriteLine(maths is null);

            var student = 
                new Student("Kabila", "Kabange", 
                            "Joseph");

            var courseName = "Design";
            //EnrollStudentInCourse(student, courseName);
            EnrollStudentInCourse(student, "Dessin artistique");

            //DisenrollStudent(student, courseName);
            DisenrollStudent(student, courseName);
        }

        static void EnrollStudentInCourse(
            Student student, 
            string courseName)
        {

            var course = new Course(courseName);
            var message = student.EnrollIn(course);
            AfficheResult(student, message);
        }

        static void DisenrollStudent(Student student, 
            string courseName)
        {
            var result = student.Disenroll(courseName);
            //AfficheResult(student, result);
            if(result.IsFailure)
                WriteLine(result.Error);
            else WriteLine("removed course: " 
                + result.Value);
        }

        static void AfficheResult(Student student,
            string message)
        {
            if(message == "OK")
                WriteLine("Nombre Cours: " 
                    + student.Enrollments.Count);
            else WriteLine(message);
        }

        static void EditStudentName(Student student)
        {
            WriteLine(student);
            student
                .UpdateName("Kabila", "Tshilombo", 
                    "Joseph");
            var name = student.Name;
            WriteLine(student);
            WriteLine(name);
        }
    }
}
