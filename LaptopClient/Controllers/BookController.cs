using LaptopClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopClient.Controllers
{
    public class BookController : Controller
    {
        BookDal dal = new BookDal();
        // GET: Book
        public ActionResult Index()
        {
            return View(dal.GetBooks());
        }
          public ActionResult SearchBook2s(int Pmin, int Pmax)
        {
            return View("Index", dal.SearchBook2s(Pmin, Pmax));
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book b)
        {
            dal.Create(b);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            dal.Delete(id);
            return RedirectToAction("Index");
        }
    }
}