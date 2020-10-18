using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheLibrary.Models;

namespace TheLibrary.Controllers
{
    public class HomeController : Controller
    {
        BookContext db;
        public HomeController(BookContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Books.ToList());
        }

        [HttpGet]
        public IActionResult ToBook(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string ToBook(Order order)
        {
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Книга успешно забронирована";
        }
    }
}
