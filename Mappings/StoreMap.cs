using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Migrations;
using Model;

namespace Mappings
{
    public class StoreMap : ClassMap<Store>
    {
        public StoreMap()
        {
            Id(x => x.StoreId, "StoreID");
            Map(x => x.StreetAddress);
            Map(x => x.PhoneNumber);
            References<ZipCode>(x => x.ZipCode, "ZipCode");
            HasMany<Video>(x => x.Videos).KeyColumn("StoreID").Inverse().Cascade.All();
            HasManyToMany<Employee>(x => x.Managers)
                .Table(Names.Tables.Manages)
                .ParentKeyColumn("StoreID")
                .ChildKeyColumn("EmployeeID");
        }
    }
}
