using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class EducationController : Controller
    {
        MyPortfolio5DbEntities context=new MyPortfolio5DbEntities();
        // GET: Education
        public ActionResult EducationList()
        {
            var values = context.Education.ToList();
            return View(values);
        }
        public ActionResult CreateEducation()
        {
            return View();
        }
    }
}