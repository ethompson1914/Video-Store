using System;
using System.Collections.Generic;

namespace Model
{
    public class Store
    {
        public virtual int StoreId { get; set; }
        public virtual string StreetAddress { get; set; }
        public virtual ZipCode ZipCode { get; set; }
        public virtual string PhoneNumber { get; set; }

        public virtual IList<Employee>  Managers { get; set; }
        public virtual IList<Video> Videos { get; set; }

        public Store()
        {
            Videos = new List<Video>();
            Managers = new List<Employee>();
        }

        public virtual void AddVideo(Video video)
        {
            video.Store = this;
            Videos.Add(video);
        }

        public virtual void AddManager(Employee employee)
        {
            employee.StoreManaged = this;
            Managers.Add(employee);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            try
            {
                var other = (Store) obj;
                return StoreId == other.StoreId;
            }
            catch (InvalidCastException ex)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return StoreId;
        }
    }
}