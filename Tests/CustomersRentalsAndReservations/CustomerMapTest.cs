using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing;
using Model;
using NUnit.Framework;
using List = NHibernate.Mapping.List;

namespace Tests.CustomersRentalsAndReservations
{
    public class CustomerMapTest : BaseTest
    {
        [Test]
        public void CheckCustomerMappings()
        {
            var store1 = new Store()
            {
                StreetAddress = "1234 Store Street", 
                ZipCode = ZipCode, 
                PhoneNumber = "6165551212"
            };

            var store2 = new Store()
            {
                StreetAddress = "2345 Store Avenue",
                ZipCode = ZipCode,
                PhoneNumber = "6665552121"
            };

            var hoosierVideo = new Video() {Movie = Hoosiers};
            var starWarsVideo = new Video() {Movie = StarWars};
            store1.AddVideo(hoosierVideo);
            store1.AddVideo(starWarsVideo);

            var rentals = new List<Rental>()
            {
                new Rental() {Video = hoosierVideo},
                new Rental() {Video = starWarsVideo}
            };
            
            var newCustomer = new PersistenceSpecification<Customer>(Session, new CustomComparator())
                .CheckProperty(x=>x.FirstName, "Customer")
                .CheckProperty(x=>x.LastName, "Last Name")
                .CheckProperty(x=>x.Password, "Password")
                .CheckProperty(x=>x.StreetAddress, "2345 Customer Dr")
                .CheckProperty(x=>x.EmailAddress, "customer@company.com")
                .CheckReference(x=>x.ZipCode, ZipCode)  
                .CheckInverseList(x=>x.Rentals, rentals, (customer, rental) => customer.AddRental(rental))
                .CheckInverseList(x=>x.PreferredStores, new List<Store>() {store1, store2})
                .CheckInverseList(x=>x.AllowedCommunicationMethods, new List<CommunicationMethod> ()
                {
                    new CommunicationMethod() {Name = "Email", Frequency = 1},
                    new CommunicationMethod() {Name = "Phone", Frequency = 4}
                }
                )
                .VerifyTheMappings();

            Console.WriteLine("New customer ID is {0}", newCustomer.CustomerId);
            store1 = Session.Merge(store1);
            store2 = Session.Merge(store2);

            var secondCustomer = new PersistenceSpecification<Customer>(Session, new CustomComparator())
                .CheckProperty(x => x.FirstName, "Another")
                .CheckProperty(x => x.LastName, "Customer")
                .CheckProperty(x => x.Password, "Wordpass")
                .CheckProperty(x => x.StreetAddress, "3456 Customer Lane")
                .CheckProperty(x => x.EmailAddress, "another@company.com")
                .CheckReference(x => x.ZipCode, new ZipCode() { Code = "12345", City = "City", State = "ST" })
                .CheckList(x => x.PreferredStores, new List<Store>() { store2, store1 })
                .VerifyTheMappings();

            Reservation reservation = newCustomer.AddReservation(SpaceBalls);
            Session.Save(newCustomer);

            Session.Flush();
            Session.Clear();

            newCustomer = Session.Get<Customer>(newCustomer.CustomerId);

            Assert.NotNull(newCustomer.Reservation);
            //Assert.AreEqual(newCustomer.Reservation.Movie, SpaceBalls);

        }
    }
}
