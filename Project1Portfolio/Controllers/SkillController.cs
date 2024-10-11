using PagedList;
using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolio5DbEntities context = new MyPortfolio5DbEntities();
        public ActionResult SkillList(int page = 1)
        {
            var values = context.Skill.ToList().ToPagedList(page, 5);
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
            context.Skill.Add(skill);
            context.SaveChanges();//degisiklikleri kaydet veritabanına yansıt
            return RedirectToAction("SkillList"); // eklmeyi yap ve beni tekrar Yetenek Listesine gonder
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = context.Skill.Find(id);
            context.Skill.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = context.Skill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            var value = context.Skill.Find(skill.SkillId);
            value.Title = skill.Title;
            value.Value = skill.Value;
            context.SaveChanges();
            return RedirectToAction(nameof(SkillList));
        }
        public PartialViewResult PartialSkillChart()
        {
            var value = context.Skill.ToList();
            return PartialView("PartialSkillChart",value);
        }
    }
}