using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication1.Models;
using System.ComponentModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        public object CourseForm { get; private set; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CourseOverview()
        {
            return View();
        }

        public IActionResult AddCourse()
        {
            Course c = new Course(); // { name = "", teachers = "", students = "", assignments = "" };
            return View(c);
        }

        public IActionResult EditCourse()
        {
            Course c = new Course { name = "GSKI", teachers = "Dabs", students = "johanna", assignments = "hugrænt málskipunartré" };
            return View(c);
        }

        public IActionResult DeleteCourse()
        {
            return View();
        }

        public IActionResult PersonOverview()
        {
            return View();
        }

        public IActionResult AddPerson()
        {
            Person c = new Person(); // { name = "", teachers = "", students = "", assignments = "" };
            return View(c);
        }

        public IActionResult EditPerson()
        {
            Person c = new Person { name = "Hrabs", ssn = 7, email = "johanna@johanna.is", password = "hugrænt málskipunartré" };
            return View(c);
        }

        public IActionResult DeletePerson()
        {
            return View();
        }
    }
}
