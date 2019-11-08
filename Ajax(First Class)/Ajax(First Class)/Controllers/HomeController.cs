using Ajax_First_Class_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax_First_Class_.Controllers
{
    public class HomeController : Controller
    {
        StudentDBContext db = new StudentDBContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult All()
        {
            List<Student> model = db.Students.ToList();
            return PartialView("_Student", model);
        }

        public PartialViewResult Top3()
        {
            List<Student> model = db.Students.OrderByDescending(x => x.Marks).Take(3).ToList();
            return PartialView("_Student", model);

        }


        public PartialViewResult Bottom3()
        {
            List<Student> model = db.Students.OrderBy(x => x.Marks).Take(3).ToList();
            return PartialView("_Student", model);
        }
    }
}