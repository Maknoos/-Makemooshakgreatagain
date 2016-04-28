using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Services
{
    public class AssignmentService
    {
        private ApplicationDbContext db;
        public AssignmentService()
        {
            db = new ApplicationDbContext();
        }
        public List<AssignmentViewModel> GetAssignmentsInCourse(int courseId)
        {
            return null;
        }

        public AssignmentViewModel GetAssignmentsById(int assignmentID)
        {
            var assignment = db.Assignments.SingleOrDefault(x => x.ID == assignmentID);
            if(assignment == null)
            {
                //TODO kasta
            }

            var milestones = db.Milestones.Where(x => x.AssignmendId == assignmentID).Select(x => new AssignmentMilestoneViewModel
            {
                Title = x.Title
            }).ToList();

            var viewModel = new AssignmentViewModel
            {
                Title = assignment.Title
            };
            return null;
        }
    }
}
