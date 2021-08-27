using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetInfo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetInfo(string ten, double tuoi, double lop)
        {
            ViewBag.HovaTen = ten;
            ViewBag.Tuoi = tuoi;
            ViewBag.Lop = lop;
            return View();
        }
    }
}