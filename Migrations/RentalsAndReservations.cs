using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace Migrations
{
    [Migration(40)]
    public class RentalsAndReservations : Migration
    {
        public override void Up()
        {
            CreateVideoTable();
            CreateRentalTable();
            CreateRatingTable();
            CreateReservationTable();
        }

        private void CreateReservationTable()
        {
            Create.Table(Names.Tables.Reservation)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("ReservationID").AsInt64().Identity().NotNullable().PrimaryKey()
                .WithColumn("CustomerID").AsInt64().NotNullable()
                .WithColumn("MovieID").AsInt32().NotNullable()
                .WithColumn("ReservationDate").AsDateTime().Nullable();

            Create.UniqueConstraint()
                .OnTable(Names.Tables.Reservation)
                .WithSchema(Names.Schemas.VideoStore)
                .Column("CustomerID");

            Create.ForeignKey("ReservationToCustomer")
                .FromTable(Names.Tables.Reservation)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("CustomerID")
                .ToTable(Names.Tables.Customer)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("CustomerID");

            Create.ForeignKey("ReservationToMovie")
                .FromTable(Names.Tables.Reservation)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("MovieID")
                .ToTable(Names.Tables.Movies)
                .InSchema(Names.Schemas.IMDB)
                .PrimaryColumn("MovieID");

            Create.ForeignKey("CustomerToReservation")
                .FromTable(Names.Tables.Customer)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("ReservationID")
                .ToTable(Names.Tables.Reservation)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("ReservationID");
        }

        private void CreateRatingTable()
        {
            Create.Table(Names.Tables.Rating)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("RatingID").AsInt64().Identity().PrimaryKey()
                .WithColumn("RentalID").AsInt64().NotNullable()
                .WithColumn("Score").AsByte().NotNullable()
                .WithColumn("Comment").AsString(4096).Nullable();

            Create.ForeignKey("RatingToRental")
                .FromTable(Names.Tables.Rating)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("RentalID")
                .ToTable(Names.Tables.Rental)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("RentalID");
        }

        private void CreateRentalTable()
        {
            Create.Table(Names.Tables.Rental)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("RentalID").AsInt64().NotNullable().Identity().PrimaryKey()
                .WithColumn("VideoID").AsInt64().NotNullable()
                .WithColumn("CustomerID").AsInt64().NotNullable()
                .WithColumn("RentalDate").AsDateTime().NotNullable()
                .WithColumn("DueDate").AsDateTime().NotNullable()
                .WithColumn("ReturnDate").AsDateTime().Nullable();

            Create.UniqueConstraint()
                .OnTable(Names.Tables.Rental)
                .WithSchema(Names.Schemas.VideoStore)
                .Columns(new[] {"VideoID", "CustomerID"});

            Create.ForeignKey("RentalToCustomer")
                .FromTable(Names.Tables.Rental)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("CustomerID")
                .ToTable(Names.Tables.Customer)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("CustomerID");

            Create.ForeignKey("RentalToVideo")
                .FromTable(Names.Tables.Rental)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("VideoID")
                .ToTable(Names.Tables.Video)
                .InSchema(Names.Schemas.VideoStore)
                .PrimaryColumn("VideoID");
        }

        private void CreateVideoTable()
        {
            Create.Table(Names.Tables.Video)
                .InSchema(Names.Schemas.VideoStore)
                .WithColumn("VideoID").AsInt64().Identity().PrimaryKey()
                .WithColumn("MovieID").AsInt32().NotNullable()
                .WithColumn("StoreID").AsInt64().NotNullable()
                .WithColumn("PurchaseDate").AsDateTime().NotNullable()
                .WithColumn("NewArrival").AsBoolean().NotNullable().WithDefaultValue(true);

            Create.ForeignKey("VideoToMovies")
                .FromTable(Names.Tables.Video)
                .InSchema(Names.Schemas.VideoStore)
                .ForeignColumn("MovieID")
                .ToTable(Names.Tables.Movies)
                .InSchema(Names.Schemas.IMDB)
                .PrimaryColumn("MovieID");
        }

        public override void Down()
        {
            DropReservationTable();
            DropRatingTable();
            DropRentalTable();
            DropVideoTable();
        }

        private void DropReservationTable()
        {
            Delete.ForeignKey("ReservationToCustomer")
                .OnTable(Names.Tables.Reservation)
                .InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("ReservationToMovie")
                .OnTable(Names.Tables.Reservation)
                .InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("CustomerToReservation")
                .OnTable(Names.Tables.Customer)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Reservation).InSchema(Names.Schemas.VideoStore);
        }

        private void DropVideoTable()
        {
            Delete.ForeignKey("VideoToMovies")
                .OnTable(Names.Tables.Video)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Video).InSchema(Names.Schemas.VideoStore);
        }

        private void DropRentalTable()
        {
            Delete.ForeignKey("RentalToCustomer")
                .OnTable(Names.Tables.Rental)
                .InSchema(Names.Schemas.VideoStore);

            Delete.ForeignKey("RentalToVideo")
                .OnTable(Names.Tables.Rental)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Rental).InSchema(Names.Schemas.VideoStore);
        }

        private void DropRatingTable()
        {
            Delete.ForeignKey("RatingToRental")
                .OnTable(Names.Tables.Rating)
                .InSchema(Names.Schemas.VideoStore);

            Delete.Table(Names.Tables.Rating).InSchema(Names.Schemas.VideoStore);
        }
    }
}
