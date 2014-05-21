using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Area
    {
        public virtual int AreaId { get; set; }
        public virtual string Name { get; set; }

        public virtual IList<ZipCode> ZipCodes { get; set; }

        public Area()
        {
            ZipCodes = new List<ZipCode>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (Area) obj;
                return AreaId == other.AreaId;
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return AreaId;
        }
    }
}
