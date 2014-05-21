using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace Web_Interface.Models
{
    public class ListGenresViewModel
    {        
        public IEnumerable<Genre> Genres { get; set; }
        public Dictionary<Genre, string> CoverArt { get; set; }
        public Dictionary<Genre, Movie>  SampleMovies { get; set; }
    }
}