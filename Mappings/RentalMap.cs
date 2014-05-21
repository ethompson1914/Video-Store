using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Model;

namespace Mappings
{
    public class RentalMap : ClassMap<Rental>
    {
        public RentalMap()
        {
            Id(x => x.RentalId, "RentalID");
            Map(x => x.RentalDate);
            Map(x => x.DueDate);
            Map(x => x.ReturnDate);
            References<Video>(x => x.Video, "VideoID");
            References<Customer>(x => x.Customer, "CustomerID");
            HasOne<Rating>(x => x.Rating).ForeignKey("RentalID").Cascade.All();
        }
    }
}
