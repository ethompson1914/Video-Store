using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    public class Names
    {
        public static class Schemas
        {
            public const string IMDB = "imdb";
            public const string VideoStore = "VideoStore";
        }

        public static class Tables
        {
            public const string Actors = "Actors";
            public const string Movies = "Movies";
            public const string Roles = "Roles";
            public const string MovieGenres = "MovieGenres";
            public const string Genres = "Genres";
            public const string MPAARatings = "MPAARatings";

            public const string ZipCode = "ZipCode";
            public const string Area = "Area";
            public const string AreaZipCode = "AreaZipCode";
            public const string Store = "Store";
            public const string Employee = "Employee";
            public const string Manages = "Manages";
            public const string Customer = "Customer";
            public const string CommunicationMethod = "CommunicationMethod";
            public const string Allows = "Allows";
            public const string Prefers = "Prefers";

            public const string Video = "Video";
            public const string Reservation = "Reservation";
            public const string Rental = "Rental";
            public const string Rating = "Rating";

            public const string TitleValues = "Title";

        }
    }
}
