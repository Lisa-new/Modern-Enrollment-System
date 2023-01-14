using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Enrollment_System
{
    public class Courses
    {
        public Courses (int id, string name)
    {
        Id = id;
        Name = name;
        
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentCourse> StudentCourse { get; set; } = new List<StudentCourse>();
    }
    public class StudentCourse

    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public bool IsTaken { get; set; }
    }
}
