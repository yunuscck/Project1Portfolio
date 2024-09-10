using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult CategoryList()
        {
            return View();
        }
        public ActionResult CreateCategory()
        {
            return View();
        }
        public ActionResult EditCategory()
        {
            return View();
        }
    }
}