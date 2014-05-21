using System;
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
    public partial class SelectCustomerForm : Form
    {
        public virtual Customer SelectedCustomer { get; set; }

        public SelectCustomerForm()
        {
            InitializeComponent();
        }

        public SelectCustomerForm(string last, string first)
        {
            InitializeComponent();
            var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
            var query = from customer in session.Query<Model.Customer>()
                        join zip in session.Query<Model.ZipCode>() on cust.ZipCode.Code equals zip.Code

                        where SelectedCustomer.FirstName.StartsWith(first) && SelectedCustomer.LastName.StartsWith(last)
                        select new { SelectedCustomer.FirstName, SelectedCustomer.LastName, SelectedCustomer.StreetAddress, zip.State, zip.Code, SelectedCustomer.CustomerId };
        
            
            
            dataGridView.DataSource = query.ToList();

            dataGridView.Columns[0].HeaderText = "First Name";
            dataGridView.Columns[1].HeaderText = "Last Name";
            dataGridView.Columns[2].HeaderText = "Street Address";
            dataGridView.Columns[3].HeaderText = "State";
            dataGridView.Columns[4].HeaderText = "Zip Code";
            dataGridView.Columns[5].Visible = false;
        }

        private void btnSelectCustomerSelect_Click(object sender, EventArgs e)
        {
            var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
            var query = from cust in session.Query<Model.Customer>()
                where customer.CustomerId == Convert.ToInt32(dataGridView.CurrentRow.Cells[5].Value)
                select customer;
            if (query.Any())
            {
            
            SelectedCustomer = (Customer) query.Single();
            Close();
        }
    }

        private void btnSelectCustomerCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

     
        
    }
}
