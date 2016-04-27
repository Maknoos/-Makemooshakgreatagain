
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Assignment
    {
        public string name { get; set; }
        public int value { get; set; }
        public int parts { get; set; }
        List<string> input;
        List<string> output;

    }
}
