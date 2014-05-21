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
    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            Table("Genres");
            Schema(Names.Schemas.IMDB);
            Id(x => x.Name, "Genre").GeneratedBy.Assigned();
        }
    }
}
