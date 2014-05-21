using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rating
    {
        private int _score;
        private const int MinimumRating = 1;
        private const int MaximumRating = 5;

        public virtual int RatingId { get; set; }
        public virtual Rental Rental { get; set; }
        public virtual int Score
        {
            get { return _score; }
            set
            {
                if (value < MinimumRating || value > MaximumRating)
                {
                    throw new ArgumentOutOfRangeException(String.Format("Values of score for a rating must be between {0} and {1}; value passed was {2}", MinimumRating, MaximumRating, value));
                }
                _score = value;
            }
        }

        public virtual string Comment { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (Rating) obj;
                return other.RatingId == RatingId;
            }
            catch (InvalidCastException ex)
            {
                return false;               
            }
        }

        public override int GetHashCode()
        {
            return RatingId;
        }
    }
}
