using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public virtual int EmployeeId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime DateHired { get; set; }
        public virtual DateTime DateOfBirth { get; set; }

        public virtual Store StoreManaged { get; set; }
        public virtual Employee Supervisor { get; set; }

        public virtual string Username { get; set; }
        public virtual string Password { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (Employee) obj;
                return other.EmployeeId == EmployeeId;
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return EmployeeId;
        }
    }
}
