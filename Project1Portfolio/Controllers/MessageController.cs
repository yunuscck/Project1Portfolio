using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolio5DbEntities contex = new MyPortfolio5DbEntities();
        public ActionResult Inbox()
        {
            var values = contex.Message.ToList();
            return View(values);
        }
        public ActionResult MessageDetail(int id)
        {
            var value = contex.Message.Where(x=>x.MessageId==id).FirstOrDefault();
            value.IsRead = true;
            contex.SaveChanges();
            return View(value);
        }
        public ActionResult MessageStatusChangeToTrue(int id)
        {
            var value = contex.Message.Where(x => x.MessageId == id).FirstOrDefault();
            value.IsRead = true;
            contex.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public ActionResult MessageStatusChangeToFalse(int id)
        {
            var value = contex.Message.Where(x => x.MessageId == id).FirstOrDefault();
            value.IsRead = false;
            contex.SaveChanges();
            return RedirectToAction("Inbox");
        }
    }
}