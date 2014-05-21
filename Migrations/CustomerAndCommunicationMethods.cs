using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using FluentMigrator.Builders;

namespace Migrations
{
    [Migration(30)]
    public class CustomerAndCommunicationMethods : Migration
    {
        public override void Up()
        {
            Create.Table(Names.Tables.Customer)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("CustomerID").AsInt64().Identity().PrimaryKey()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("StreetAddress").AsString(255).NotNullable()
                .WithColumn("EmailAddress").AsString(100).Nullable()
                .WithColumn("Password").AsString(100).NotNullable()
                .WithColumn("ZipCode").AsString(5).NotNullable()
                .WithColumn("ReservationID").AsInt64().Nullable();
                

            Create.ForeignKey("CustomerToZipCode")
                .FromTable(Names.Tables.Customer)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("ZipCode")
                .ToTable(Names.Tables.ZipCode)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("ZipCode");

            Create.Table(Names.Tables.CommunicationMethod)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("Name").AsString(50).PrimaryKey()
                .WithColumn("Frequency").AsInt16().NotNullable();

            Create.Table(Names.Tables.Allows)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("CustomerID").AsInt64().NotNullable()
                .WithColumn("Name").AsString(50).NotNullable();

            Create.PrimaryKey(Names.Tables.Allows + "PK")
                .OnTable(Names.Tables.Allows)
                .WithSchema(Names.Schemas.VideoStore)
                .Columns(new string[] {"CustomerID", "Name"});

            Create.ForeignKey("AllowsToCustomer")
                .FromTable(Names.Tables.Allows)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("CustomerID")
                .ToTable(Names.Tables.Customer)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("CustomerID");

            Create.ForeignKey("AllowsToCommunicationMethod")
                .FromTable(Names.Tables.Allows)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("Name")
                .ToTable(Names.Tables.CommunicationMethod)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("Name");

            Create.Table(Names.Tables.Prefers)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("CustomerID").AsInt64().NotNullable()
                .WithColumn("StoreID").AsInt64().NotNullable()
                .WithColumn("StoreOrder").AsInt16().NotNullable();

            Create.PrimaryKey(Names.Tables.Prefers + "PK")
                .OnTable(Names.Tables.Prefers)
                .WithSchema(Names.Schemas.VideoStore)
                .Columns(new string[] {"CustomerID", "StoreID"});

            Create.ForeignKey("PrefersToCustomer")
                .FromTable(Names.Tables.Prefers)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("CustomerID")
                .ToTable(Names.Tables.Customer)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("CustomerID");

            Create.ForeignKey("PrefersToStore")
                .FromTable(Names.Tables.Prefers)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("StoreID")
                .ToTable(Names.Tables.Store)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("StoreID");

        }

        public override void Down()
        {
            Delete.ForeignKey("AllowsToCustomer")
                .OnTable(Names.Tables.Allows)
                .InSchema(Names.Schemas.VideoStore);
            
            Delete.ForeignKey("AllowsToCommunicationMethod")
                .OnTable(Names.Tables.Allows)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Allows).InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("CustomerToZipCode")
                .OnTable(Names.Tables.Customer)
                .InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("PrefersToCustomer")
                .OnTable(Names.Tables.Prefers)
                .InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("PrefersToStore")
                .OnTable(Names.Tables.Prefers)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Prefers).InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Customer).InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.CommunicationMethod).InSchema(Names.Schemas.VideoStore);
        }
    }
}
