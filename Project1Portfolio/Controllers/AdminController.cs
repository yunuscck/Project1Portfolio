using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class AdminController : Controller
    {
        MyPortfolio5DbEntities context=new MyPortfolio5DbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSideBar()
        {
            ViewBag.imageUrl=context.About.Select(x=>x.ImageUrl).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }
    }
}