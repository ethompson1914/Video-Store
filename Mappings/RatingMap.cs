using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Model;

namespace Mappings
{
    public class RatingMap : ClassMap<Rating>
    {
        public RatingMap()
        {
            Id(x => x.RatingId, "RatingID");
            Map(x => x.Score);
            Map(x => x.Comment);
            References(x => x.Rental).Column("RentalID");
        }
    }
}
