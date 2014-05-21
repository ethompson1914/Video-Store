using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        public virtual int ReservationId { get; set; }
        public virtual DateTime ReservationDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }

        public Reservation()
        {
            ReservationDate = DateTime.Now;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            try
            {
                var other = (Reservation) obj;
                return ReservationId == other.ReservationId;
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return ReservationId;
        }
    }
}
