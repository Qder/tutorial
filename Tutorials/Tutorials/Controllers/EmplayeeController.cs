using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorials.Models;

namespace Tutorials.Controllers
{
    public class EmplayeeController : Controller
    {
        //
        // GET: /Emplayee/

        public ActionResult Details()
        {
            Emplayee employ = new Emplayee()
            {
                EmployeeId = 101,
                Name = "Johan",
                Gender = "Male",
                City = "London"
            };
            return View(employ);
        }

    }
}
