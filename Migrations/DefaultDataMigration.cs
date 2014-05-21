using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using FluentMigrator.Builders;
using FluentMigrator.Runner.Extensions;
using NHibernate.Hql.Ast.ANTLR;

namespace Migrations
{
    [Migration(70)]
    public class DefaultDataMigration : Migration
    {
        public override void Up()
        {

            //Inserting Default data for Titles.
            Insert.IntoTable(Names.Tables.TitleValues).InSchema(Names.Schemas.VideoStore).Row(new { Title = "Mr." });
            Insert.IntoTable(Names.Tables.TitleValues).InSchema(Names.Schemas.VideoStore).Row(new { Title = "Mrs." });
            Insert.IntoTable(Names.Tables.TitleValues).InSchema(Names.Schemas.VideoStore).Row(new { Title = "Miss." });
            Insert.IntoTable(Names.Tables.TitleValues).InSchema(Names.Schemas.VideoStore).Row(new { Title = "Rev." });
            Insert.IntoTable(Names.Tables.TitleValues).InSchema(Names.Schemas.VideoStore).Row(new { Title = "Dr." });

            //Inserting Default data for ZipCodes
            Insert.IntoTable(Names.Tables.ZipCode).InSchema(Names.Schemas.VideoStore).Row(new { ZipCode = "49423", City = "Holland", State = "MI" });
            Insert.IntoTable(Names.Tables.ZipCode).InSchema(Names.Schemas.VideoStore).Row(new { ZipCode = "49464", City = "Zeeland", State = "MI" });
            Insert.IntoTable(Names.Tables.ZipCode).InSchema(Names.Schemas.VideoStore).Row(new { ZipCode = "97210", City = "Portland", State = "OR" });

            //Inserting Default data for Employee
            Insert.IntoTable(Names.Tables.Employee).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { EmployeeID = 10000, FirstName = "Employee", LastName = "One", DateOfHire = changeDateTime("2/1/2014"), DateOfBirth = changeDateTime("1/22/1996"), Username = "employee1", Password = "databases" });
            Insert.IntoTable(Names.Tables.Employee).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { EmployeeID = 10001, FirstName = "Employee", LastName = "Two", DateOfHire = changeDateTime("3/20/2014"), DateOfBirth = changeDateTime("2/19/1981"), Username = "employee2", Password = "arecool" });

            //Inserting Default data for Customers
            Insert.IntoTable(Names.Tables.Customer).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { CustomerID = 10000, Title = "Dr.", FirstName = "Ryan", LastName = "McFall", StreetAddress = "1260 Winterwood Ln", EmailAddress = "mcfall@hope.edu", PhoneNumber = "6163957952", ZipCode = 49464, Password = "password1" });
            Insert.IntoTable(Names.Tables.Customer).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { CustomerID = 10001, Title = "Mr.", FirstName = "Richard", LastName = "McFall", StreetAddress = "147 Rose St.", EmailAddress = "dadmcfall@comcast.net", PhoneNumber = "5035551212", ZipCode = 97210, Password = "password2" });
            Insert.IntoTable(Names.Tables.Customer).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { CustomerID = 10002, Title = "Dr.", FirstName = "Charles", LastName = "Cusack", StreetAddress = "555 South Shore Dr.", EmailAddress = "cusack@hope.edu", PhoneNumber = "6163957271", ZipCode = 49423, Password = "password3" });
            Insert.IntoTable(Names.Tables.Customer).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { CustomerID = 10003, Title = "Dr.", FirstName = "Matt", LastName = "DeJongh", StreetAddress = "156 W 12th St.", EmailAddress = "dejongh@hope.edu", PhoneNumber = "6163957517", ZipCode = 49423, Password = "password4" });
            Insert.IntoTable(Names.Tables.Customer).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { CustomerID = 10004, Title = "Dr.", FirstName = "Michael", LastName = "Jipping", StreetAddress = "321 39th St.", EmailAddress = "jipping@hope.edu", PhoneNumber = "6163957509", ZipCode = 49423, Password = "password5" });
        
            //Inserting Default data for Store
            Insert.IntoTable(Names.Tables.Store).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { StoreID = 10000, StreetAddress = "27 Graves Place", PhoneNumber = "6163957510", ZipCode = 49423 });
        
            

            //Inserting Default data for Videos
            Insert.IntoTable(Names.Tables.Video).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { VideoID = 10000, MovieID = 100944, StoreID = 10000, PurchaseDate = changeDateTime("4/1/2014"), NewArrival = true });    /*  Hoosiers  */
            Insert.IntoTable(Names.Tables.Video).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { VideoID = 10001, MovieID = 213716, StoreID = 10000, PurchaseDate = changeDateTime("4/1/2014"), NewArrival = true }); /*  Star Wars  */
            Insert.IntoTable(Names.Tables.Video).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { VideoID = 10002, MovieID = 104696, StoreID = 10000, PurchaseDate = changeDateTime("4/1/2014"), NewArrival = true }); /*  I was a Teenage Zombie */
            Insert.IntoTable(Names.Tables.Video).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { VideoID = 10003, MovieID = 213671, StoreID = 10000, PurchaseDate = changeDateTime("4/1/2014"), NewArrival = true });  /*  Star Trek V: The Final Frontier */
            Insert.IntoTable(Names.Tables.Video).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { VideoID = 10004, MovieID = 230164, StoreID = 10000, PurchaseDate = changeDateTime("4/1/2014"), NewArrival = true }); /*  Toy Story */
            Insert.IntoTable(Names.Tables.Video).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { VideoID = 10005, MovieID = 232350, StoreID = 10000, PurchaseDate = changeDateTime("4/1/2014"), NewArrival = true }); /*  Tron */
            Insert.IntoTable(Names.Tables.Video).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { VideoID = 10006, MovieID = 100089, StoreID = 10000, PurchaseDate = changeDateTime("4/1/2014"), NewArrival = true });  /*  Home Alone */
            
            //Inserting Default data for Rentals
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10000, VideoID = 10000, CustomerID = 10000, RentalDate = changeDateTime("4/17/2014"), DueDate = changeDateTime("4/24/2014"), ReturnDate = changeDateTime("4/23/2014") });
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10001, VideoID = 10001, CustomerID = 10000, RentalDate = changeDateTime("4/17/2014"), DueDate = changeDateTime("4/24/2014"), ReturnDate = changeDateTime("4/22/2014") });
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10002, VideoID = 10004, CustomerID = 10000, RentalDate = changeDateTime("4/21/2014"), DueDate = changeDateTime("4/28/2014"), ReturnDate = new DateTime?() });
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10003, VideoID = 10006, CustomerID = 10000, RentalDate = changeDateTime("4/22/2014"), DueDate = changeDateTime("4/28/2014"), ReturnDate = new DateTime?() });
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10004, VideoID = 10001, CustomerID = 10002, RentalDate = changeDateTime("1/1/2014"), DueDate = changeDateTime("1/8/2014"), ReturnDate = changeDateTime("1/31/2014") });
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10005, VideoID = 10002, CustomerID = 10002, RentalDate = changeDateTime("1/1/2014"), DueDate = changeDateTime("1/8/2014"), ReturnDate = changeDateTime("2/3/2014") });
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10006, VideoID = 10005, CustomerID = 10002, RentalDate = changeDateTime("1/1/2014"), DueDate = changeDateTime("1/8/2014"), ReturnDate = new DateTime?() });
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10007, VideoID = 10004, CustomerID = 10003, RentalDate = changeDateTime("4/1/2000"), DueDate = changeDateTime("4/8/2000"), ReturnDate = changeDateTime("4/4/2000") });
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10008, VideoID = 10006, CustomerID = 10003, RentalDate = changeDateTime("12/24/2003"), DueDate = changeDateTime("1/2/2003"), ReturnDate = changeDateTime("1/3/2003") });
            Insert.IntoTable(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore).WithIdentityInsert().Row(new { RentalID = 10009, VideoID = 10003, CustomerID = 10004, RentalDate = changeDateTime("3/14/2014"), DueDate = changeDateTime("3/21/2014"), ReturnDate = changeDateTime("3/21/2014") });
        }

        public override void Down()
        {
            Execute.Sql("DELETE FROM VideoStore.Rental");
            Execute.Sql("DELETE FROM VideoStore.Title");
            Execute.Sql("DELETE FROM VideoStore.Employee");
            Execute.Sql("DELETE FROM VideoStore.Customer");
            Execute.Sql("DELETE FROM VideoStore.Store");
            Execute.Sql("DELETE FROM VideoStore.Video");
            Execute.Sql("DELETE FROM VideoStore.ZipCode");
          
        }

        
        private static DateTime changeDateTime(string dateString)
        {
                DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo();
                dateTimeFormatInfo.ShortDatePattern = "MM/dd/yyyy";
                dateTimeFormatInfo.DateSeparator = "/";
                return Convert.ToDateTime(dateString, dateTimeFormatInfo);
                
        }
        

        private static DateTime SecondConvertOption(string dateString)
        {
            return DateTime.ParseExact(dateString, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
