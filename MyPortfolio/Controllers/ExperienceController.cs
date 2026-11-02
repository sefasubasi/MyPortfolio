using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortofolioContext db = new MyPortofolioContext();
        public IActionResult ExperienceList()
        {
            var values = db.Experiences.ToList();
            return View(values);
        }

        [HttpGet]//sayfa yüklendiğinde çalışır.
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]//sayfada buton tetiklendikten sonra çalışır.
        public IActionResult CreateExperience(Experience experience)
        {
            db.Experiences.Add(experience);
            db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = db.Experiences.Find(id);
            db.Experiences.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = db.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            db.Experiences.Update(experience);
            db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
