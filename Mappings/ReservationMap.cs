using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Model;

namespace Mappings
{
    public class ReservationMap : ClassMap<Reservation>
    {
        public ReservationMap()
        {
            Id(x => x.ReservationId, "ReservationID");
            Map(x => x.ReservationDate);
            References(x => x.Movie, "MovieID");
            References(x => x.Customer, "CustomerID");
        }
    }
}
