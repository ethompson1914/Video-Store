using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernate.Utils;
using Migrations;
using Model;

namespace Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.CustomerId, "CustomerID");
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.StreetAddress);
            Map(x => x.EmailAddress);
            Map(x => x.Password);
            Map(x => x.PhoneNumber);
            Map(x => x.Title);
            References<ZipCode>(x => x.ZipCode, "ZipCode");
            References<Reservation>(x => x.Reservation, "ReservationID").Cascade.All();
            HasMany<Rental>(x => x.Rentals).KeyColumn("CustomerID").Inverse().Cascade.All();
            HasManyToMany<Store>(x => x.PreferredStores)
                .Table(Names.Tables.Prefers)
                .Cascade.All()
                .ParentKeyColumn("CustomerID")
                .ChildKeyColumn("StoreID")
                .AsList(index => index.Column("StoreOrder"));
            HasManyToMany<CommunicationMethod>(x => x.AllowedCommunicationMethods)
                .Table(Names.Tables.Allows)
                .Cascade.All()
                .ParentKeyColumn("CustomerID")
                .ChildKeyColumn("Name")
                .AsBag();
        }
    }
}
