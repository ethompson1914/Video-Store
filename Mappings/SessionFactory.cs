using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;

namespace Mappings
{
    public class SessionFactory
    {

        private static ISessionFactory session;

        public static ISessionFactory CreateSessionFactory ()
        {
            if (session == null)
            {
                var builder = new SqlConnectionStringBuilder();
                builder["Data Source"] = ".\\SQLEXPRESS";
                builder["Integrated Security"] = true;
                builder["Initial Catalog"] = "lin";

                session = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2008
                        .ConnectionString(builder.ConnectionString)
                        .DefaultSchema("VideoStore")
                        .ShowSql()
                    )
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeeMap>())
                    .ExposeConfiguration(x => x.CurrentSessionContext<ThreadLocalSessionContext>())
                    .BuildSessionFactory();
                return session;
            }
            else
            {
                return session;
            }
        }
    }
}
