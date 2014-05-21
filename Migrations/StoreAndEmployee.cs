using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Migrations
{
    [Migration(20)]
    public class StoreAndEmployee : Migration
    {
        public override void Up()
        {
            Create.Table(Names.Tables.Store)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("StoreID").AsInt64().Identity().PrimaryKey()
                .WithColumn("StreetAddress").AsString(255).NotNullable()
                .WithColumn("PhoneNumber").AsString(10).NotNullable()
                .WithColumn("ZipCode").AsString(5).NotNullable();

          

            Create.ForeignKey("StoreToZipCode")
                .FromTable(Names.Tables.Store)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("ZipCode")
                .ToTable(Names.Tables.ZipCode)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("ZipCode");

            Create.Table(Names.Tables.Employee)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("EmployeeID").AsInt64().Identity().PrimaryKey()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("DateOfHire").AsDateTime().NotNullable()
                .WithColumn("DateOfBirth").AsDateTime().NotNullable()
                .WithColumn("SupervisorID").AsInt64().Nullable();

            Create.ForeignKey("EmployeeToEmployeeSupervisor")
                .FromTable(Names.Tables.Employee)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("SupervisorID")
                .ToTable(Names.Tables.Employee)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("EmployeeID");

            Create.Table(Names.Tables.Manages)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("StoreID").AsInt64().NotNullable()
                .WithColumn("EmployeeID").AsInt64().NotNullable();

            Create.ForeignKey("ManagesToStore")
                .FromTable(Names.Tables.Manages)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("StoreID")
                .ToTable(Names.Tables.Store)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("StoreID");

            Create.ForeignKey("ManagesToEmployee")
               .FromTable(Names.Tables.Manages)
               .InSchema(Names.Schemas.VideoStore)
               .ForeignColumn("EmployeeID")
               .ToTable(Names.Tables.Employee)
               .InSchema(Names.Schemas.VideoStore)
               .PrimaryColumn("EmployeeID");             
        }

        public override void Down()
        {
            
            
            Delete.ForeignKey("ManagesToStore")
                .OnTable(Names.Tables.Manages)
                .InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("ManagesToEmployee")
                .OnTable(Names.Tables.Manages)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Manages)
                .InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("StoreToZipCode")
                .OnTable(Names.Tables.Store)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Store)
                .InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("EmployeeToEmployeeSupervisor")
                .OnTable(Names.Tables.Employee)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Employee)
                .InSchema(Names.Schemas.VideoStore);
        }
    }
}
