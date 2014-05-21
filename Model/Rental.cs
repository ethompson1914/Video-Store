using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rental
    {
        public virtual int RentalId { get; set; }
        public virtual Video Video { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual DateTime RentalDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime? ReturnDate { get; set; }

        public virtual Rating Rating { get; set; }
        public Rental()
        {
            RentalDate = DateTime.Now;
            DueDate = RentalDate.AddDays(7);
            ReturnDate = DateTime.Now;
        }

        public Rental(Customer customer, Video video) : this ()
        {
            Customer = customer;
            Video = video;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            try
            {
                var other = (Rental) obj;
                return RentalId == other.RentalId;
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return RentalId;
        }
    }
}
