using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolio5DbEntities contex = new MyPortfolio5DbEntities();
        public ActionResult SkillList()
        {
            var values = contex.Skill.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(Skill skill)
        {
            contex.Skill.Add(skill);
            contex.SaveChanges();//degisiklikleri kaydet veritabanına yansıt
            return RedirectToAction("SkillList"); // eklmeyi yap ve beni tekrar Yetenek Listesine gonder
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = contex.Skill.Find(id);
            contex.Skill.Remove(value);
            contex.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}