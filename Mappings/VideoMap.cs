using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Model;

namespace Mappings
{
    public class VideoMap : ClassMap<Video>
    {
        public VideoMap()
        {
            Id(x => x.VideoId);
            Map(x => x.PurchaseDate).CustomType("timestamp");
            Map(x => x.NewArrival);
            References<Movie>(x => x.Movie, "MovieID");
            References<Store>(x => x.Store, "StoreID");
        }
    }
}
