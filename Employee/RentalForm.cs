using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Mappings;
using Model;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Hql.Ast.ANTLR.Tree;
using NHibernate.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mappings;
using Model;
using NHibernate.Hql.Ast.ANTLR;
using NHibernate.Linq;


namespace Employee
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        public RentalForm(Customer chosenCustomer, bool isAll)
        {
            InitializeComponent();
            var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
            
            if (isAll)
            {
                var query = from rent in session.Query<Model.Rental>()
                    join rentVideo in session.Query<Model.Video>() on rent.Video.VideoId equals rentVideo.VideoId
                    join rentMovie in session.Query<Model.Movie>() on rentVideo.Movie.MovieId equals rentMovie.MovieId
                    where rental.Customer.CustomerId == chosenCustomer.CustomerId
                    select new {rentMovie.Title, rental.RentalDate, rental.DueDate, rental.ReturnDate};
                dGVRentalForm.DataSource = query.ToList();
            }
            else
            {
                var query = from rent in session.Query<Model.Rental>()
                    join rentVideo in session.Query<Model.Video>() on rent.Video.VideoId equals rentVideo.VideoId
                    join rentMovie in session.Query<Model.Movie>() on rentVideo.Movie.MovieId equals rentMovie.MovieId
                    where rental.Customer.CustomerId == chosenCustomer.CustomerId && (rental.ReturnDate == null)
                    select new {rentMovie.Title, rental.RentalDate, rental.DueDate, rental.ReturnDate};
                dGVRentalForm.DataSource = query.ToList();
            }


            dGVRentalForm.Columns[0].HeaderText = "Movie Title";
            dGVRentalForm.Columns[1].HeaderText = "Rental Date";
            dGVRentalForm.Columns[2].HeaderText = "Due Date";
            dGVRentalForm.Columns[3].HeaderText = "Return Date";
        
        }
        

       
        
    }
}
