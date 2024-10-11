using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolio5DbEntities context=new MyPortfolio5DbEntities();
        // GET: Profile
        public ActionResult Index()
        {
            var values = context.About.ToList();
            return View(values);
        }
    }
}