using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MvcMovie.Models;
using ExamProject.Models;
using ExamProject.Repositories;

// This project was created by Bogdan Nedelea & Stefan Dimitriu
namespace ExamProject.Controllers
{
    public class MoviesController : Controller
    {
        public IMovieRepository MovieRepository { get; set; }

        public MoviesController()
        {
            MovieRepository = new MovieRepository(new MovieDBContext());
        }

        // GET: Movies
        [Authorize(Roles = "admin")]
        public ActionResult Index(string movieGenre, string searchString)
        {
            var GenreLst = new List<string>();

            var movies = MovieRepository.GetMovies().ToList();

            var GenreQry = from d in movies
                           orderby d.Genre
                           select d.Genre;

            GenreLst.AddRange(GenreQry.Distinct());
            GenreLst.Add("All");

            ViewBag.movieGenre = new SelectList(GenreLst);
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString)).ToList();
            }

            if (!string.IsNullOrEmpty(movieGenre) && !movieGenre.Equals("All"))
            {
                movies = movies.Where(x => x.Genre == movieGenre).ToList();
            }

            return View(movies);
        }


        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            Movie movie =MovieRepository.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            ViewBag.MoviesGenre = MoviesGenre.get();
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,ReleaseDate,Genre,Rating,Description,Picture,Video")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Create(movie);
                return RedirectToAction("Index");
            }
            ViewBag.MoviesGenre = MoviesGenre.get();
            return View(movie);
        }

        // GET: Movies/Edit/5
        [Authorize(Roles = "admin")]
        public ActionResult Edit(int id)
        {
            ViewBag.MoviesGenre = MoviesGenre.get();

            Movie movie = MovieRepository.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ReleaseDate,Genre,Rating,Description,Picture,Video")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                MovieRepository.Edit(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            Movie movie = MovieRepository.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieRepository.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                MovieRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    
    }   
}
