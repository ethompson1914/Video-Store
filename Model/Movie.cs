using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Movie
    {
        public virtual int MovieId { get; set; }
        public virtual int Year { get; set; }
        public virtual string Title { get; set; }
        public virtual int RunningTimeInMinutes { get; set; }
        public virtual string Director { get; set; }
        public virtual string Language { get; set; }
        public virtual string Rating { get; set; }
        public virtual string PrimaryGenre { get; set; }

        public virtual IList<Reservation> Reservations { get; set; }

        public Movie()
        {
            Reservations = new List<Reservation>();
        }

        public virtual Reservation AddReservation(Customer customer)
        {
            var reservation = new Reservation()
            {
                Customer = customer,
                Movie = this,
                ReservationDate = DateTime.Now
            };
            customer.Reservation = reservation;
            Reservations.Add(reservation);
            return reservation;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (Movie) obj;
                return MovieId == other.MovieId;
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return MovieId;
        }
    }
}
