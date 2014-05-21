using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Model;

namespace Mappings
{
    public class CommunicationMethodMap : ClassMap<CommunicationMethod>
    {
        public CommunicationMethodMap()
        {
            Id(x => x.Name).GeneratedBy.Assigned();
            Map(x => x.Frequency);
        }
    }
}
