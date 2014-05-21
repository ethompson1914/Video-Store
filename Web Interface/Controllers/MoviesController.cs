using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Model;
using NHibernate.Linq;
using NHibernate.Util;
using Web_Interface.Models;
using Web_Interface.Services;

namespace Web_Interface.Controllers
{
    public class MoviesController : BaseController
    {
        private readonly List<Movie> _movies;

        public MoviesController()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    MovieId = 1,
                    Title = "A Few Good Men",
                    Rating = "R",
                    PrimaryGenre = "Drama",
                    RunningTimeInMinutes = 138,
                    Year = 1997
                },
                new Movie()
                {
                    MovieId = 2,
                    Title = "Sleepless in Seattle",
                    Rating = "PG",
                    PrimaryGenre = "Romance",
                    RunningTimeInMinutes = 105,
                    Year = 1993
                },
                new Movie()
                {
                    MovieId = 3,
                    Title = "Mission Impossible",
                    Rating = "PG-13",
                    PrimaryGenre = "Action",
                    RunningTimeInMinutes = 110,
                    Year = 1998
                }
            };
        }

        public ActionResult NewArrivals()
        {
            return View();
        }

        public ActionResult Genres()
        {
            var albumArtDictionary = new Dictionary<Genre, string>();
            var genreMovieDictionary = new Dictionary<Genre, Movie>();
            var query = GetAvailableGenres();

            foreach (var genre in query)
            {
                var movie = GetRandomMovieInGenre(genre.Name);
                if (movie != null)
                {
                    var albumArtUrl = GetAlbumArtUrlForMovie(movie);
                    albumArtDictionary[genre] = albumArtUrl;
                    genreMovieDictionary[genre] = movie;
                }
            }

            return View(
              new ListGenresViewModel()
              {
                  Genres = query.AsEnumerable(),
                  CoverArt = albumArtDictionary,
                  SampleMovies = genreMovieDictionary
              }
            );
        }

        public ActionResult MovieDetails(int id)
        {
            var session = SessionFactory.GetCurrentSession();
            var query = session.Query<Movie>().Where(x => x.MovieId == id);
            return View(query.FirstOrNull());
        }

        public ActionResult ByGenre(string name)
        {
            var session = SessionFactory.GetCurrentSession();
            var query = from movie in session.Query<Movie>()
                        where movie.PrimaryGenre.Equals(name)
                        orderby movie.Year descending, movie.Title
                        select movie;

            return View(query.Take(50).AsEnumerable());
        }

        private Movie GetRandomMovieInGenre(string genre)
        {
            var query = GetMoviesInGenre(genre).Take(100).ToList();
            if (query.Count > 0)
            {
                var random = new Random();
                int index = random.Next(0, query.Count - 1);
                return query[index];
            }
            else
            {
                return null;
            }
        }

        private IEnumerable<Movie> GetMoviesInGenre(string name)
        {
            var session = SessionFactory.GetCurrentSession();
            var query = from movie in session.Query<Movie>()
                        where movie.PrimaryGenre.Equals(name)
                        orderby movie.Year descending, movie.Title ascending
                        select movie;
            return query;
        }

        private IEnumerable<Genre> GetAvailableGenres()
        {
            var session = SessionFactory.GetCurrentSession();
            var query = from genre in session.Query<Genre>()
                        select genre;
            return query;
        }

        private string GetAlbumArtUrlForMovie(Movie movie)
        {
            return AlbumArtService.GetAlbumArt(movie);                               
        }
    }
}
