using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Mappings;
using Migrations;
using Model;
using NHibernate;
using NUnit.Framework;

namespace Tests
{
    public abstract class BaseTest
    {
        protected static ISessionFactory _sessionFactory;
        protected ISession Session;
        protected ZipCode ZipCode;
        protected Movie Hoosiers;
        protected Movie StarWars;
        protected Movie SpaceBalls;

        protected Customer Customer;

        [TestFixtureSetUp]
        public static void CreateSessionFactory()
        {
            _sessionFactory = SessionFactory.CreateSessionFactory();                        
        }

        [SetUp]
        public void CleanUpData()
        {
            Session = _sessionFactory.GetCurrentSession();
            ClearTable(Names.Tables.Rating);
            ClearTable(Names.Tables.Rental);
            ClearTable(Names.Tables.Video);
            ClearTable(Names.Tables.Prefers);
            ClearTable(Names.Tables.Manages);
            ClearTable(Names.Tables.Store);
            ClearTable(Names.Tables.Reservation);
            ClearTable(Names.Tables.Allows);
            ClearTable(Names.Tables.Customer);
            ClearTable(Names.Tables.AreaZipCode);
            ClearTable(Names.Tables.Area);
            ClearTable(Names.Tables.ZipCode);
            ClearTable(Names.Tables.Employee);
            ClearTable(Names.Tables.CommunicationMethod);

            ZipCode = new ZipCode()
            {
                Code = "49423",
                City = "Holland",
                State = "MI"
            };
            Session.Save(ZipCode);

            Hoosiers = Session.Get<Movie>(100944);
            StarWars = Session.Get<Movie>(213716);
            SpaceBalls = Session.Get<Movie>(211385);

            Customer = new Customer()
            {
                FirstName = "A",
                LastName = "Customer",
                Password = "Password",
                StreetAddress = "1234 Some Street",
                ZipCode = ZipCode,
                EmailAddress = "customer@company.com"
            };
        }

        protected void ClearTable(string tableName)
        {
            Session.CreateSQLQuery(String.Format("delete from {0}.{1}", Names.Schemas.VideoStore, tableName)).ExecuteUpdate();

        }
    }
}
