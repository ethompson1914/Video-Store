using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using Model;
using Newtonsoft.Json;
using NHibernate.Loader.Custom.Sql;
using NHibernate.Util;

namespace Web_Interface.Services
{
    public class AlbumArtService
    {
        public const string Unavailable = "UNAVAILABLE";
        public const string Timeout = "TIMEDOUT";

        public class ITunesResponse
        {
            public class MediaItem
            {
                public string ArtworkUrl100 { get; set; }    
                public DateTime ReleaseDate { get; set; }
            }

            public int ResultCount { get; set; }
            public List<MediaItem> Results { get; set; }            
        }

        public static string GetAlbumArt(Movie movie)
        {
            Task<ITunesResponse> lookupTask = LookupAlbumArt(movie.Title);
            var matches = lookupTask.Result;

            if (matches.ResultCount == 0)
            {
                return Unavailable;
            }
            else
            {
                //  Assume the first hit is the match
                var matchingMovie = matches.Results[0];

                //  Try to find a match by release year
                var query = from result in matches.Results
                    where result.ReleaseDate.Year == movie.Year
                    select result;
                var mediaItems = query as IList<ITunesResponse.MediaItem> ?? query.ToList();
                
                if (mediaItems.Count() == 1)
                {
                    matchingMovie = mediaItems.First();                    
                }

                //  Increase the size of the cover art being used
                return matchingMovie.ArtworkUrl100.Replace("100x100", "300x300");                                                                 
            }
            
        }

        private static async Task<ITunesResponse> LookupAlbumArt(string title)
        {
            using (var client = new HttpClient())
            {                
                var encodedTitle = HttpContext.Current.Server.UrlEncode(title);
                var url = "http://itunes.apple.com/search?term=" + encodedTitle + "&media=movie";
                
                string response= await client.GetStringAsync(url).ConfigureAwait(false);

                return JsonConvert.DeserializeObject<ITunesResponse>(response);
            }
        }
    }
}