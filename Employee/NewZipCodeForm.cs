using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class NewZipCodeForm : Form
    {

        public string city { get {return txtNewZipNewCity.Text;}}
        public string state { get {return cbxNewZipNewState.Text;}}
        
        public NewZipCodeForm()
        {
            InitializeComponent();
            
        }

        public NewZipCodeForm(string zip)
        {
            InitializeComponent();
            labelNewZipCode.Text = "Zip Code: "+ zip;
        }

        private void btnNewZipCodeCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewZipCodeOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
