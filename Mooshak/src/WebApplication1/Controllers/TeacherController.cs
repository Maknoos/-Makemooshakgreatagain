using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class TeacherController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProject()
        {
            return View();
        }

        public IActionResult EditProject()
        {
            return View();
        }

        public IActionResult DeleteProject()
        {
            return View();
        }
    }
}
