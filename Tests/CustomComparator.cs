using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class CustomComparator : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            if (x == null || y == null) return false;

            if (x is DateTime && y is DateTime)
            {
                var xDateTime = (DateTime)x;
                var yDateTime = (DateTime)y;

                return
                    xDateTime.Year == yDateTime.Year &&
                    xDateTime.Month == yDateTime.Month &&
                    xDateTime.Day == yDateTime.Day &&
                    xDateTime.Hour == yDateTime.Hour &&
                    xDateTime.Minute == yDateTime.Minute &&
                    xDateTime.Second == yDateTime.Second;
            }

            return x.Equals(y);
        }

        public int GetHashCode(object obj)
        {
            if (obj != null)
            {
                return obj.GetHashCode();
            }

            return -1;
        }
    }
}
