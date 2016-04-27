using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Course
    {
        public string name { get; set; }
        List<Student> students;
        List<Teacher> teachers;
        List<Assignment> assignments;
    }
}
