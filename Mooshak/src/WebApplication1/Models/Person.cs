using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
        public string name { get; set; }
        public int ssn { get; set; }
        public School schoolName { get; set; }
        public List<Course> courses; //{ get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
