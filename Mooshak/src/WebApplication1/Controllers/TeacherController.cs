using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication1.Models;
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

        [HttpGet]
        public IActionResult AddProject()
        {
            Assignment model = new Assignment();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProject(Assignment model)
        {
            if(ModelState.IsValid)
            {

                Assignment newProject = new Assignment();
                newProject.name = model.name;
                newProject.value = model.value;
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditProject(int? projId)
        {
            if (projId.HasValue)
            {
                Assignment assign = new Assignment();
                //assign = GetFromDb where id matches
                if(assign != null)
                {
                    Assignment model = new Assignment();
                    //Copy assign into view model
                    return View(model);
                }            
            }
            return HttpNotFound();
        }

 
        public IActionResult DeleteProject()
        {
            return View();
        }
    }
}
