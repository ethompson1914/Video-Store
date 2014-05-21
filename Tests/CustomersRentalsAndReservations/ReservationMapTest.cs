using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing;
using Model;
using NUnit.Framework;

namespace Tests.CustomersRentalsAndReservations
{
    public class ReservationMapTest : BaseTest
    {
        [Test]
        public void CheckReservationMappings()
        {
            var now = DateTime.Now;
            
            new PersistenceSpecification<Reservation>(Session, new CustomComparator())
                .CheckProperty(x => x.ReservationDate, now)
                .CheckReference(x => x.Customer, Customer)
                .CheckReference(x => x.Movie, Hoosiers)
                .VerifyTheMappings();
        }
    }
}
