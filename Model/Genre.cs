using System;

namespace Model
{
    public class Genre
    {
        public virtual string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (Genre) obj;
                return other.Name.Equals(Name);
            }
            catch (InvalidCastException ex) { return false;}

        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
