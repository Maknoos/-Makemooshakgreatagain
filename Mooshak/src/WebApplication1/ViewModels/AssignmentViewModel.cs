
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ViewModels;

namespace WebApplication1.Models
{
    public class AssignmentViewModel
    {
        public string Title { get; set; }
        public int value { get; set; }
        public int parts { get; set; }
        public List<AssignmentMilestoneViewModel> milestones;
        List<string> input;
        List<string> output;

    }
}
