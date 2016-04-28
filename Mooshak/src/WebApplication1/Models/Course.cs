using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Course
    {
        public string name { get; set; }
        public int id { get; set; }
        /*public List<Student> students;
        public List<Teacher> teachers;
        public List<Assignment> assignments;*/
        public string students { get; set; }
        public string teachers { get; set; }
        public string assignments { get; set; }

    }
}
