using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandoMovie.Model
{
    public class Movie
    {
        string title { get; set; }
        string year { get; set; }
        string rating { get; set; }
        string runTime { get; set; }
        string genere { get; set; }
        string poster { get; set; }
        bool response { get; set; } = false;
    }
}
