using ComicBookGallery.Models;
using ComicBookGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController() {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ComicBook comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);
        }
    }
}