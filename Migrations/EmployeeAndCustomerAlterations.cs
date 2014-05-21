using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using FluentMigrator.Builders;

namespace Migrations
{
    [Migration(60)]
    public class EmployeeAndCustomerAlterations : Migration
    {
        public override void Up()
        {
            //Employee: adding in Username and Password columns

            Alter.Table(Names.Tables.Employee).InSchema(Names.Schemas.VideoStore)
                .AddColumn("Username").AsString(255).NotNullable()
                .AddColumn("Password").AsString(255).NotNullable();

            //Customer: adding Title and PhoneNumber columns
            Alter.Table(Names.Tables.Customer).InSchema(Names.Schemas.VideoStore)
                .AddColumn("Title").AsString(255).NotNullable()
                .AddColumn("PhoneNumber").AsString(255).NotNullable();

            //  String command =
            //      "CREATE); TABLE VideoStore.TitleValues (Id int NOT NULL, Title varchar(10) CONSTRAINT chk_Title CHECK (Title IN ('Dr.', 'Miss', 'Mr.', 'Mrs.')) )";
            //  Execute.Sql(command);
            
            Create.Table(Names.Tables.TitleValues).InSchema(Names.Schemas.VideoStore)
                .WithColumn("Title").AsString(50).NotNullable().PrimaryKey();

        }

        public override void Down()
        {

            //Employee: delete Username and Password columns
            Delete.Column("Username").Column("Password").FromTable(Names.Tables.Employee).InSchema(Names.Schemas.VideoStore);

            //Customer: delete Title and PhoneNumber columns
            Delete.Column("Title").Column("PhoneNumber").FromTable(Names.Tables.Customer).InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.TitleValues).InSchema(Names.Schemas.VideoStore);
            

        }
    }
}
