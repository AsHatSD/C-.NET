using ExamProject.Controllers;
using ExamProject.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using MvcMovie.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Test_That_SomeThing()
        {
            var moviesController = new MoviesController();
            moviesController.MovieRepository = new FakeMovieRepo();

            var actionResult = moviesController.Delete(1);
            Assert.IsInstanceOfType(actionResult, typeof(ViewResult));
        }


        [TestMethod]
        public void Test_That_SomeThing_ERROR()
        {
            var moviesController = new MoviesController();
            moviesController.MovieRepository = new FakeMovieRepo();

            var actionResult = moviesController.Delete(0);
            Assert.IsInstanceOfType(actionResult, typeof(HttpNotFoundResult));
        }
    }

    public class FakeMovieRepo : IMovieRepository
    {
        public Movie Find(int id)
        {
            if (id == 0) return null;
            else
            {
                return new Movie
                {
                    ID = 1,
                    Genre = "WHATEVER",
                    Description = "DESCRIPTION",
                    ReleaseDate = DateTime.Now,
                    Title = "HELLO WORLD",
                    Rating = 1
                };
            }
        }

        public IEnumerable<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Edit(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }

    }
}