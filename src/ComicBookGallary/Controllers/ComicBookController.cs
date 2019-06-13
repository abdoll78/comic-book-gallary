using ComicBookGallary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallary.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slott", Rule = "Script"},
                    new Artist() {Name = "Humberto Ramos", Rule = "Pencils"},
                    new Artist() {Name = "Victor Olazaba", Rule = "Inks"},
                    new Artist() {Name = "Edgar Delgado", Rule = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos", Rule = "Letters"}
                }
            };
            return View(comicBook);
        }
    }
}