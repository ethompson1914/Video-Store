using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Migrations
{
    [Migration(1)]
    public class CreateIMDBKeys : Migration
    {
        public override void Up()
        {
            Create.PrimaryKey("MoviesPK").OnTable(Names.Tables.Movies).WithSchema(Names.Schemas.IMDB)
                .Column("MovieID");

            Create.PrimaryKey("MovieGenresPK").OnTable(Names.Tables.MovieGenres).WithSchema(Names.Schemas.IMDB)
                .Columns(new string[] {"MovieID", "Genre"});

            Create.PrimaryKey("ActorsPK").OnTable(Names.Tables.Actors).WithSchema(Names.Schemas.IMDB)
                .Column("ActorID");

            Create.PrimaryKey("RolesPK").OnTable(Names.Tables.Roles).WithSchema(Names.Schemas.IMDB)
                .Column("RoleID");

            Create.PrimaryKey("GenresPK")
                .OnTable(Names.Tables.Genres)
                .WithSchema(Names.Schemas.IMDB)
                .Column("Genre");

            Create.PrimaryKey("MPAARatingsPK")
                .OnTable(Names.Tables.MPAARatings)
                .WithSchema(Names.Schemas.IMDB)
                .Column("Rating");
        }

        public override void Down()
        {
            Delete.PrimaryKey("MoviesPK")
                .FromTable(Names.Tables.Movies)
                .InSchema(Names.Schemas.IMDB);

            Delete.PrimaryKey("MovieGenresPK")
                .FromTable(Names.Tables.MovieGenres)
                .InSchema(Names.Schemas.IMDB);

            Delete.PrimaryKey("ActorsPK")
                .FromTable(Names.Tables.Actors)
                .InSchema(Names.Schemas.IMDB);

            Delete.PrimaryKey("RolesPK")
                .FromTable(Names.Tables.Roles)
                .InSchema(Names.Schemas.IMDB);

            Delete.PrimaryKey("GenresPK")
                .FromTable(Names.Tables.Genres)
                .InSchema(Names.Schemas.IMDB);

            Delete.PrimaryKey("MPAARatingsPK")
                .FromTable(Names.Tables.MPAARatings)
                .InSchema(Names.Schemas.IMDB);
        }
    }
}
