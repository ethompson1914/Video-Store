using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing;
using Model;
using NUnit.Framework;

namespace Tests.MoviesAndVideos
{
    public class VideoMapTest : BaseTest
    {
        [Test]
        public void CheckMappings()
        {
            var purchaseDate = DateTime.UtcNow;
            
            new PersistenceSpecification<Video>(Session, new CustomComparator())
                .CheckProperty(x => x.PurchaseDate, purchaseDate)
                .CheckReference(x => x.Store, new Store()
                {
                    PhoneNumber = "6165551212",
                    StreetAddress = "27 Graves Place",
                    ZipCode = ZipCode
                })
                .CheckReference(x => x.Movie, Hoosiers)
                .VerifyTheMappings();
        }
    }
}
