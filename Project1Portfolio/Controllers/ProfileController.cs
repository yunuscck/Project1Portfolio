using Project1Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Portfolio.Controllers
{
    public class ProfileController : Controller
    {
        MyPortfolio5DbEntities context = new MyPortfolio5DbEntities();
        // GET: Profile
        public ActionResult Index()
        {
            var values = context.Profile.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProfile(Profile profile)
        {
            profile.ImageUrl = $"/Content/Images/{profile.ImageUrl}";
            context.Profile.Add(profile);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProfile(int id)
        {
            var value = context.Profile.Find(id);
            context.Profile.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var value = context.Profile.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProfile(Profile profile)
        {
            var value = context.Profile.Find(profile.ProfileId);
            value.Title = profile.Title;
            value.Description = profile.Description;
            value.Adress = profile.Adress;
            value.Email = profile.Email;
            value.PhoneNumber = profile.PhoneNumber;
            value.Github = profile.Github;
            value.ImageUrl = $"/Content/Images/{profile.ImageUrl}";
            //value.MapLocation = profile.MapLocation;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}