using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Components
{
    public class PersonForm : ViewComponent
    {
        public IViewComponentResult Invoke(Person c)
        {
            return View(c);
        }
    }
}