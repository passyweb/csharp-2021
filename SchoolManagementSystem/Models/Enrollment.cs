namespace SchoolManagementSystem.Models
{
    public class Enrollment
    {
        public Enrollment(Student student, 
            Course course)
        {
            Student = student;
            Course = course;
        }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}