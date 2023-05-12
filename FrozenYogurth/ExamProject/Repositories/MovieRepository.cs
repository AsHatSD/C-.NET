using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMovie.Models;
using System.Data.Entity;

namespace ExamProject.Repositories
{
    public class MovieRepository : IMovieRepository, IDisposable
    {
        private readonly MovieDBContext db;

        public MovieRepository(MovieDBContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<Movie> GetMovies()
        {
            var movies = from m in db.Movies
                   select m;
            return movies;
        }
        public void Create(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }
        public Movie Find(int id)
        {
            return db.Movies.Find(id);
        }
        public void Edit(Movie movie)
        {
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}