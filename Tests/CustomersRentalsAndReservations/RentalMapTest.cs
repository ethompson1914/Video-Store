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
    public class RentalMapTest : BaseTest
    {
        [Test]
        public void CheckRentalMappings()
        {
            var store = new Store()
            {
                StreetAddress = "27 Graves Place",
                PhoneNumber = "6165551212",
                ZipCode = ZipCode
            };

            var video = new Video()
            {
                Movie = Hoosiers
            };

            store.AddVideo(video);

            Session.Save(store);
            //Session.Save(video);

            var customer = new Customer()
            {
                FirstName = "Customer",
                LastName = "One",
                EmailAddress = "one@company.com",
                ZipCode = ZipCode,
                StreetAddress = "12345 Customer Street",
                Password = "password"
            };
            Session.Save(customer);

            var rentalDate = DateTime.Now;
            var dueDate = rentalDate.AddDays(7);
            var returnDate = rentalDate.AddDays(2);

            new PersistenceSpecification<Rental>(Session, new CustomComparator())
                .CheckProperty(x => x.RentalDate, rentalDate)
                .CheckProperty(x => x.DueDate, dueDate)
                .CheckProperty(x => x.ReturnDate, returnDate)
                .CheckReference(x => x.Customer, customer)
                .CheckReference(x => x.Video, video)                
                .VerifyTheMappings();
        }

        [Test]
        public void CheckRatingMapping()
        {
            var store = new Store()
            {
                StreetAddress = "12345 Store Street",
                PhoneNumber = "6167721142",
                ZipCode = ZipCode
            };

            var video = new Video() {Movie = Hoosiers};
            store.AddVideo(video);

            var customer = new Customer()
            {
                FirstName = "Customer",
                LastName = "Last Name",
                ZipCode = ZipCode,
                Password = "Password",
                EmailAddress = "customer@company.com",
                StreetAddress = "1234 Customer Street"
            };

            var rental = customer.AddRental(video);
            

            Session.Save(store);
            Session.Save(customer);

            var rating = new Rating() { Rental = rental, Score = 1, Comment = "Comment" };
            Session.Save(rating);

            Session.Flush();
            Session.Clear();

            rental = Session.Get<Rental>(rental.RentalId);

            Assert.NotNull(rental.Rating);
            Assert.AreEqual(rating, rental.Rating);
        }
    }
}
