using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Migrations;
using Model;

namespace Mappings
{
    public class MovieMap : ClassMap<Movie>
    {
        public MovieMap()
        {
            Table(Names.Tables.Movies);
            Schema(Names.Schemas.IMDB);

            Id(x => x.MovieId, "MovieID");
            Map(x => x.Year);
            Map(x => x.Title, "MovieTitle");
            Map(x => x.RunningTimeInMinutes, "RunningTime");
            Map(x => x.Language);
            Map(x => x.Rating);
            Map(x => x.PrimaryGenre);

            HasMany<Reservation>(x => x.Reservations)
                .Table(Names.Tables.Reservation)
                .KeyColumn("MovieID")
                .OrderBy("ReservationDate desc")
                .AsBag()
                .Cascade.All();
        }
    }
}
