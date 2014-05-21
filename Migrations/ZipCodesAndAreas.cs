using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Migrations
{
    [Migration(10)]
    public class ZipCodesAndAreas : Migration
    {
        public override void Up()
        {
            Create.Table(Names.Tables.ZipCode)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("ZipCode").AsString(5).PrimaryKey()
                .WithColumn("City").AsString(50).NotNullable()
                .WithColumn("State").AsString(50).NotNullable();

            Create.Table(Names.Tables.Area)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("AreaID").AsInt64().Identity().PrimaryKey()
                .WithColumn("Name").AsString(100).NotNullable();

            Create.Table(Names.Tables.AreaZipCode)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("AreaID").AsInt64().NotNullable()
                .WithColumn("ZipCode").AsString(5).NotNullable();

            Create.PrimaryKey(Names.Tables.AreaZipCode + "PK")
                .OnTable(Names.Tables.AreaZipCode)
                .WithSchema(Names.Schemas.VideoStore)
                .Columns(new string[] {"AreaID", "ZipCode"});

            Create.ForeignKey("AreaZipCodeToZipCode")
                .FromTable(Names.Tables.AreaZipCode)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("ZipCode")
                .ToTable(Names.Tables.ZipCode)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("ZipCode");

            Create.ForeignKey("AreaZipCodeToArea")
                .FromTable(Names.Tables.AreaZipCode)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("AreaID")
                .ToTable(Names.Tables.Area)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("AreaID");
        }

        public override void Down()
        {
            Delete.ForeignKey("AreaZipCodeToArea")
                .OnTable(Names.Tables.AreaZipCode)
                .InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("AreaZipCodeToZipCode")
                .OnTable(Names.Tables.AreaZipCode)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.AreaZipCode).InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.ZipCode).InSchema(Names.Schemas.VideoStore);
            Delete.Table(Names.Tables.Area).InSchema(Names.Schemas.VideoStore);
        }
    }
}
