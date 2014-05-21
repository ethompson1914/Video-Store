using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing;
using Model;
using NUnit.Framework;

namespace Tests
{
    public class CommunicationMethodMapTest : BaseTest
    {
        [Test]
        public void CheckCommunicationMethodMappings()
        {
            new PersistenceSpecification<CommunicationMethod>(Session, new CustomComparator())
                .CheckProperty(x => x.Name, "Email")
                .CheckProperty(x => x.Frequency, 1)
                .VerifyTheMappings();
        }
    }
}
