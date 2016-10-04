using ComicBookGallery.Data;
using ComicBookGallery.Models;
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

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        //? enables to pass nullable types
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            //need to cast because cannot pass nullable type int to method in repo 
            //where it passes an int only
            var comicBook = _comicBookRepository.GetComicBook((int)id);

            //Alternative method: Pass data from controller to view using 'ViewBag'
            //    ViewBag.SeriesTitle = "The Amazing Spider-Man";
            //    ViewBag.IssueNumber = 700;
            //    ViewBag.Description = @"<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, 
            //+ last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            //    ViewBag.Artists = new string[]
            //    {
            //        "Script: Dan Slott",
            //        "Pencils: Humberto Ramos",
            //        "Inks: Victor Olazaba",
            //        "Colors: Edgar Delgado",
            //        "Letters: Chris Eliopoulos"
            //            };

            //return View(comicBook);
            //the in the parameter makes it a strongly typed view
            //exposes the model instance through its model property 
            return View(comicBook);

        }

           
        }
    }
