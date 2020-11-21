using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RandoMovie.Model;

namespace RandoMovie.Service
{
    public interface IMovieService
    {
        Movie GetMovie();
    }
}
