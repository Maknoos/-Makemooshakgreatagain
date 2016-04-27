using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        List<ILookup<string, int>> grades;
        public int year { get; set; }
        public string degree { get; set; }
        public string field { get; set; }
    }
}
