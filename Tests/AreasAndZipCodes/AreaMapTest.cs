using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing;
using Model;
using NUnit.Framework;
using List = NHibernate.Mapping.List;

namespace Tests.AreasAndZipCodes
{
    public class AreaMapTest : BaseTest
    {
        [Test]
        public void ChekAreaMappings()
        {
            new PersistenceSpecification<Area>(Session, new CustomComparator())
                .CheckProperty(x=>x.Name, "Holland")
                .CheckInverseBag(x => x.ZipCodes, new List<ZipCode>()
                {
                    new ZipCode() {Code = "49424", City = "Holland", State = "MI"},
                    new ZipCode() {Code = "49464", City = "Zeeland", State = "MI"},
                    new ZipCode() {Code = "49418", City = "Grandville", State = "MI"}
                }
                )
                .VerifyTheMappings();
        }
    }
}
