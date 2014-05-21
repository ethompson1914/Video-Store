using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CommunicationMethod
    {
        public virtual string Name { get; set; }
        public virtual int Frequency { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (CommunicationMethod) obj;
                return other.Name.Equals(Name);
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
