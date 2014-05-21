using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing;
using Mappings;
using Model;
using NUnit.Framework;

namespace Tests.MoviesAndVideos
{
    public class MovieMapTest : BaseTest
    {
        [Test]
        public void CheckMovieMappings()
        {
            
            Assert.AreEqual(Hoosiers.Title, "Hoosiers");
            Assert.AreEqual(Hoosiers.Year, 1986);
            Assert.AreEqual(Hoosiers.RunningTimeInMinutes, 114);

            Session.Save(Customer);
            Session.Refresh(Customer);

            Console.WriteLine("Customer ID is {0}", Customer.CustomerId);
            Hoosiers = Session.Get<Movie>(100944);
            var reservation = Hoosiers.AddReservation(Customer);
            reservation.ReservationDate = DateTime.Now;
            Session.Save(reservation);

            

            Session = _sessionFactory.GetCurrentSession();

            Session.Flush();
            Session.Clear();

            Hoosiers = Session.Get<Movie>(Hoosiers.MovieId);
            Assert.AreEqual(1, Hoosiers.Reservations.Count);
            var reserveCustomer = Hoosiers.Reservations[0].Customer;
            Assert.NotNull(reserveCustomer);
            Assert.AreEqual(Customer, reserveCustomer);


        }
    }
}
