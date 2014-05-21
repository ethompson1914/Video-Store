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
    public class AreaMap : ClassMap<Area>
    {
        public AreaMap()
        {
            Id(x => x.AreaId, "AreaID");
            Map(x => x.Name);
            HasManyToMany<ZipCode>(x => x.ZipCodes)
                .Cascade.All()
                .Table(Names.Tables.AreaZipCode)
                .ParentKeyColumn("AreaID")
                .ChildKeyColumn("ZipCode");

        }
    }
}
