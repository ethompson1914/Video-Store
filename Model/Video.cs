using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Video
    {
        public virtual int VideoId { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual DateTime PurchaseDate { get; set; }
        public virtual bool NewArrival { get; set; }
        public virtual Store Store { get; set; }
        

        public Video()
        {
            PurchaseDate = DateTime.Now;
            NewArrival = true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (Video) obj;
                return other.VideoId == VideoId;
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        

        public override int GetHashCode()
        {
            return VideoId;
        }
    }
}
