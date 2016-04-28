using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public int CourseID { get; set; }
        List<string> input;
        List<string> output;

    }
}
