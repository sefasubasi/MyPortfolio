using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortofolioContext db = new MyPortofolioContext();
        public IActionResult Inbox()
        {
            var values = db.Messages.ToList();
            return View(values);
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = db.Messages.Find(id);
            value.IsRead = true;
            db.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = db.Messages.Find(id);
            value.IsRead = false;
            db.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = db.Messages.Find(id);
            if (value.IsRead == false)
            {
                db.Messages.Remove(value);
                db.SaveChanges();
                return RedirectToAction("Inbox", new { mesaj = "basarili" });
            }
            else
            {
                return RedirectToAction("Inbox", new { mesaj = "hata_okunmus" });
            }
        }

        public IActionResult MessageDetail(int id)
        {
            var value = db.Messages.Find(id);
            return View(value);
        }


    }
}
