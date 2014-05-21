using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing;
using Model;
using NUnit.Framework;
using List = NHibernate.Mapping.List;

namespace Tests.Stores
{
    public class TestStoreMap : BaseTest
    {
        [Test]
        public void CheckStoreMappings()
        {                        
            var now = DateTime.Now;

            new PersistenceSpecification<Store>(Session, new CustomComparator())
                .CheckProperty(x => x.StreetAddress, "27 Graves Place")
                .CheckProperty(x => x.PhoneNumber, "6165551212")
                .CheckReference(x => x.ZipCode, ZipCode)
                .CheckInverseList(x => x.Videos, new List<Video>()
                {
                    new Video()
                    {
                        Movie = Hoosiers, PurchaseDate = now, NewArrival = true
                    },
                    new Video()
                    {
                        Movie = StarWars, PurchaseDate = now.AddDays(1), NewArrival=false
                    }
                },                
                (store, video) => store.AddVideo(video))
                .CheckList(x => x.Managers, new List<Employee> ()
                {
                    new Employee() {FirstName = "First", LastName = "Last", DateHired = DateTime.Now, DateOfBirth = DateTime.Now.AddYears(-18)}
                }
                ,
                (store, employee) => store.AddManager (employee)
                )
                .VerifyTheMappings();

        }
    }
}
