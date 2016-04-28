using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication1.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class AssignmentController : Controller
    {
        private AssignmentService service = new AssignmentService();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var viewModel = service.GetAssignmentsById(id);
            return View(viewModel);
        }
    }
}
