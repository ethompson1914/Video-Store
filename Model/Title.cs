using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Title
    {
        public virtual string title { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (Title)obj;
                return this.title.Equals(other.title);
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return title.GetHashCode();
        }
    }
}
