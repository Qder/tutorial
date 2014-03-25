using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tutorials.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index(string name)
        {
            return "Name = " + name + "Sur= " + Request.QueryString["surename"];
        }

        public string GetDetails(string Id)
        {
            return "GetDetails Invoked " + "Id is: " + Id;
        }
        public ViewResult Listas ()
        {
            ViewBag.Countries = new List<string>()
            {
                "Indija",
                "UK",
                "JAV",
                "AntiJAV",
                "Lithuania"
            };
            return View();
        }
    }
}
