using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Model;

namespace Mappings
{
    public class TitleMap : ClassMap<Title>
    {
        public TitleMap()
        {
             Id(x => x.title, "Title").GeneratedBy.Assigned();
        }
        
    }
}
