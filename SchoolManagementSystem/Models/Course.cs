using System.Diagnostics.Contracts;

namespace SchoolManagementSystem.Models
{
    public class Course
    {
        public string Name { get; set; }

        public Course(string name)
        {
            Contract.Requires(string.IsNullOrEmpty(name), "Name is required");
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}