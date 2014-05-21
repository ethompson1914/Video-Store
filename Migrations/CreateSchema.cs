using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Migrations
{
    [Migration(2)]
    public class CreateSchema : Migration
    {
        public override void Up()
        {
            Create.Schema(Names.Schemas.VideoStore);
        }

        public override void Down()
        {
            Delete.Schema(Names.Schemas.VideoStore);
        }
    }
}
