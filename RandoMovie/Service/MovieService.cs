using RandoMovie.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RandoMovie.Service
{
    public class MovieService : IMovieService
    {
        private readonly string API_URL = @"https://api.themoviedb.org/3/discover/movie?";
        private readonly string API_KEY = "api_key=dccfee49b51c9f127385b7350d087118&";
        private readonly string API_SEARCH = "&language=en-US&sort_by=vote_count.desc&page=";
        private readonly RestClient client = new RestClient();
        public Movie GetMovie()
        {
            
            

                int randomId = RandomKeyGenerator();
                RestRequest request = new RestRequest(API_URL+API_KEY+API_SEARCH+randomId);
                IRestResponse<Movie> response = client.Get<Movie>(request);
                if (response.ResponseStatus != ResponseStatus.Completed)
                {
                    throw new HttpRequestException("Could Not Contact Server");
                }
                else if (!response.IsSuccessful)
                {
                    throw new HttpRequestException(response.StatusCode.ToString());
                }
                else
                {
                    return response.Data;
                }
           
            
        }

        private int RandomKeyGenerator()
        { 
            Random random = new Random();
            int randomId = random.Next(0,500);
            return randomId;
        }
    }
}
