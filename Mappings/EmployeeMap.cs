using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Model;

namespace Mappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.EmployeeId, "EmployeeID");
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.DateHired, "DateOfHire");
            Map(x => x.DateOfBirth);
            Map(x => x.Username);
            Map(x => x.Password);
            References<Employee>(x => x.Supervisor, "SupervisorId");
            HasOne<Store>(x => x.StoreManaged).ForeignKey("EmployeeID").Cascade.All();
        } 
    }    
}
