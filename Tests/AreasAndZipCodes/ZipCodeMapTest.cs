using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing;
using Model;
using NUnit.Framework;

namespace Tests.AreasAndZipCodes
{
    public class ZipCodeMapTest : BaseTest
    {
        [Test]
        public void CheckZipCodeMappings()
        {
            new PersistenceSpecification<ZipCode>(Session, new CustomComparator())
                .CheckProperty(x => x.Code, "49464")
                .CheckProperty(x => x.City, "Zeeland")
                .CheckProperty(x => x.State, "MI")
                .VerifyTheMappings();
        }
    }
}
