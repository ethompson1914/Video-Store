using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public virtual int CustomerId { get; set; }

        [DisplayName("First Name")]
        public virtual string FirstName { get; set; }

        [DisplayName("Last Name")]
        public virtual string LastName { get; set; }

        [DisplayName("Email Address")]
        public virtual string EmailAddress { get; set; }

        [DisplayName("Street Address")]
        public virtual string StreetAddress { get; set; }   
     
        [DataType("Password")]
        public virtual string Password { get; set; }

        [DisplayName("Zip Code")]
        public virtual ZipCode ZipCode { get; set; }

        public virtual string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public virtual string PhoneNumber { get; set; }
        public virtual string Title { get; set; }

        public virtual Reservation Reservation { get; set; }
        public virtual IList<Rental> Rentals { get; set; }
        public virtual IList<Store> PreferredStores { get; set; }
        public virtual IList<CommunicationMethod> AllowedCommunicationMethods { get; set; }
        public Customer()
        {
            Rentals = new List<Rental>();
            PreferredStores = new List<Store>();
            AllowedCommunicationMethods = new List<CommunicationMethod>();
        }

        public virtual string City
        {
            get { return ZipCode.City; }
        }

        public virtual string State
        {
            get { return ZipCode.State; }
        }

        public virtual string Code
        {
            get { return ZipCode.Code; }
        }

        public virtual Rental AddRental(Video video)
        {
            var rental = new Rental(this, video);
            Rentals.Add(rental);
            return rental;
        }

        public virtual void AddRental (Rental rental)
        {
            rental.Customer = this;
            Rentals.Add(rental);
        }

        public virtual Reservation AddReservation(Movie movie)
        {
            if (Reservation != null)
            {
                var message = String.Format(
                    "Attempt to add reservation for movie {0} to customer {1}, which already has a reservation for movie {2}",
                    movie.MovieId, CustomerId, Reservation.Movie.MovieId
                );
                throw new InvalidOperationException(message);
            }

            Reservation = new Reservation() {Customer = this, Movie = movie, ReservationDate = DateTime.Now};
            return Reservation;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (Customer) obj;
                return other.CustomerId == CustomerId;
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return CustomerId;
        }
    }
}
