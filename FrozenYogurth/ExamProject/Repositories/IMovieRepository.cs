using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Repositories
{
    public interface IMovieRepository : IDisposable
    {
        IEnumerable<Movie> GetMovies();
        void Create(Movie movie);
        void Delete(int id);
        Movie Find(int id);
        void Edit(Movie movie);
    }
}
