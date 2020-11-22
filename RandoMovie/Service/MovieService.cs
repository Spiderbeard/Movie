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
        private readonly string API_URL = @"http://www.omdbapi.com/?i=tt";
        private readonly string API_KEY = ""; //Your API KEY Here
        private readonly RestClient client = new RestClient();
        public Movie GetMovie()
        {
            
            

                int randomId = RandomKeyGenerator();
                RestRequest request = new RestRequest(API_URL+randomId+API_KEY);
                IRestResponse <Movie> response = client.Get<Movie>(request);
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
            int randomId = random.Next(0000000, 9999999);
            return randomId;
        }
    }
}
