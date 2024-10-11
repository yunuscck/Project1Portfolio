using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolio5DbEntities context=new MyPortfolio5DbEntities();
        // GET: SocialMedia
        public ActionResult SocialMediaList()
        {
            var values = context.SocialMedia.ToList();
            return View(values);
        }
        
        [HttpGet]
        public ActionResult ChangeStatus(int id, bool status) 
        { 
            var value = context.SocialMedia.FirstOrDefault(x=>x.SocialMediaId == id);
            value.Status = status;
            context.SaveChanges();
            return RedirectToAction("SocialMediaList"); 
        }
    }
}