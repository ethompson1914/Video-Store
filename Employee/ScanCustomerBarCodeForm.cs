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
    public partial class ScanCustomerBarCodeForm : Form
    {
        private List<int> customerID { get; set; }
        public Customer SelectedCustomer{ get; set; }

        public ScanCustomerBarCodeForm()
        {
            
            InitializeComponent();
            
            var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
            var query = from cust in session.Query<Model.Customer>()
                        select cust;
            int count = query.Count();
            customerID = new List<int>();
            Array temp = query.ToArray();
            
            foreach (var customer in query.ToArray())
            {
                
                cbxScanCode.Items.Add(customer.FullName);
                customerID.Add(customer.CustomerId);
            }
           
        }

        private void btnScanCustomerBarCodeSelect_Click(object sender, EventArgs e)
        {
            
            
            var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
            var query = from cust in session.Query<Model.Customer>()
                        where cust.CustomerId.Equals(customerID.ElementAt(cbxScanCode.SelectedIndex))
                        select cust
                        ;
            if (query.Any())
            {
                SelectedCustomer = query.Single();
                Close();
            }

        }

        private void btnScanCustomerBarCodeCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
