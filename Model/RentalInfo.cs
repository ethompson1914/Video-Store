using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;
using Migrations;



namespace Model
{
    public class RentalInfo
    {
        public virtual Rental rental { get; set; }
        public virtual string MovieTitle { get; set; }
        public virtual DateTime DateRented { get { return rental.RentalDate; } }
        public virtual DateTime DateDue {get { return rental.DueDate; }}
        public virtual DateTime? DateReturned {get { return rental.ReturnDate; }}

        public RentalInfo(Rental rental)
        {
        //    var session = SessionF.CreateSessionFactory().GetCurrentSession();
        //    var query = from rent in session.Query<Model.Rental>() join rentVideo in session.Query<Model.Video>() on rent.Video
        //                where rent.Customer.CustomerId == chosenCustomer.CustomerId
         //               select new { rent.Name, rent.RentalDate, rent.DueDate, rent.ReturnDate };
        }
    }
}
