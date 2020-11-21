using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandoMovie.Model;
using RandoMovie.Service;

namespace RandoMovie.Controller
{
    [ApiController]
    [Route("[controller]")]
   
    public class MovieController :ControllerBase
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService service)
        {
            movieService = service;
        }
        
        [HttpGet]
        public ActionResult<Movie> GetRandomMovie()
        {
            try
            {
                Movie movie = new Movie();

                do
                {

                    movie = movieService.GetMovie();

                }
                while (movie.Type != "movie");
                
                return movie;

            }
            catch(Exception e)
            {
                throw e;
            }
        }

    }
}
