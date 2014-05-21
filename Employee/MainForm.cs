using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Mappings;
using Model;
using NHibernate.Hql.Ast.ANTLR.Tree;
using NHibernate.Linq;

namespace Employee
{
    public partial class MainForm : Form
    {
        protected Regex regExNonEmpty;
        protected Regex regExZipCode;
        protected Regex regExPhoneNumber;
        private bool saveZipCode = false;
        private Customer testCustomer;
        private Customer otherCustomer;

        public MainForm()
        {
            InitializeComponent();
            regExNonEmpty = new Regex ("^\\s+$");
            regExZipCode = new Regex("^\\d{5}(-\\d{4})?$");
            regExPhoneNumber = new Regex(@"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$");
            var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
            var query = from title in session.Query<Model.Title>()
                        select title;
            cbxNewCustomerTitle.Items.AddRange(query.ToArray());
        }

        private void updateCheckOutButtonStatus()
        {
            btnOpCheckout.Enabled = cbxOperationsCustomerID.SelectedIndex != -1 && cbxOperationsCheckoutVideoID.SelectedIndex != -1;
        }

        private void updateFindCustomerButtonStatus()
        {
            String firstName = txtSearchFirstName.Text;
            String lastName = txtSearchLastName.Text;

            bool bothEmpty = isEmpty(firstName) && isEmpty(lastName);
            btnSearchCustomer.Enabled = !bothEmpty;
        }

        private void updateCheckAvailabilityButtonStatus()
        {
            btnOperatinsCheckAvailability.Enabled = !isEmpty(txtOperationsMovieTitle.Text) &&
                lstOperationsStoresToSearch.SelectedIndices.Count > 0;
        }

        private void setMoreInfoTextToDefault () {
            infoLabel.Text = "";
        }

        private bool isEmpty(String text)
        {
            if (text == "")
            {
                return true;
            }

            bool matches = regExNonEmpty.Match(text).Success;
            return matches;
        }

        private bool isValidZipCode (String zipCode) 
        {
            return zipCode != "" && regExZipCode.Match(zipCode).Success;
        }

        private bool isValidPhoneNumber(String phoneNumber)
        {
            return phoneNumber != "" && regExPhoneNumber.Match(phoneNumber).Success;
        }
        
        private void comboBox2_MouseEnter(object sender, EventArgs e)
        {
            infoLabel.Text = "Enter the Video ID with the bar code scanner or keyboard";
        }

        private void comboBox2_MouseLeave(object sender, EventArgs e)
        {
            infoLabel.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
            {
                if (cbxVideoUnits.SelectedIndex == -1)
                {
                    cbxVideoUnits.SelectedIndex = 0;
                }
            }
        }

        private void cbxCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCheckOutButtonStatus();
        }

        private void cbxCheckoutVideoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCheckOutButtonStatus();
        }

        private void cbxCheckInVideoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOperationsCheckIn.Enabled = cbxOperationsCheckInVideoID.SelectedIndex != -1;
        }

        private void cbxRemoveVideoVideoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveVideo.Enabled = cbxInventoryRemoveVideoVideoID.SelectedIndex != -1;
        }

        private void txtAddVideoMovieTitle_TextChanged(object sender, EventArgs e)
        {
            Match match = regExNonEmpty.Match(txtInventoryAddVideoMovieTitle.Text);
            btnInventoryAddVideoSearchTitle.Enabled = txtInventoryAddVideoMovieTitle.Text != "" && !match.Success;
        }

        private void txtSearchLastName_TextChanged(object sender, EventArgs e)
        {
            updateFindCustomerButtonStatus();
        }

        private void txtSearchFirstName_TextChanged(object sender, EventArgs e)
        {
            updateFindCustomerButtonStatus();
        }
        /*
        private void cbxFindCustomerCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFindCustomerCustomerID.SelectedIndex != -1)
            {
                pnlCustomerButtons.Enabled = true;          
            }
            else
            {
                pnlCustomerButtons.Enabled = false;
            }
        }
         */

        private void txtReportZipCode_TextChanged(object sender, EventArgs e)
        {
            String zipCode = txtReportsZipCode.Text;
            btnReportsShowCustomersInArea.Enabled = isValidZipCode (txtReportsZipCode.Text);
        }

        private void txtReportZipCode_Enter(object sender, EventArgs e)
        {
            infoLabel.Text = "Enter either a 5 digit or 5+4 digit zip code";
        }

        private void txtReportZipCode_Leave(object sender, EventArgs e)
        { 
            setMoreInfoTextToDefault();
        }

        private void txtOperationsMovieTitle_TextChanged(object sender, EventArgs e)
        {
            updateCheckAvailabilityButtonStatus();
        }

        private void lstStoresToSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCheckAvailabilityButtonStatus();
        }

        private void btnReportShowCustomersInArea_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newCustomerTextField_TextChanged(object sender, EventArgs e)
        {
            bool saveButtonEnabled = true;

            saveButtonEnabled = saveButtonEnabled && !isEmpty(txtCustomersNewFirstName.Text);
            saveButtonEnabled = saveButtonEnabled && !isEmpty(txtCustomersNewLastName.Text);
            saveButtonEnabled = saveButtonEnabled && !isEmpty(txtCustomersNewStreetAddress.Text);
            saveButtonEnabled = saveButtonEnabled && !isEmpty(txtCustomersNewCity.Text);
            saveButtonEnabled = saveButtonEnabled && !isEmpty(cbxCustomersNewState.Text);
            saveButtonEnabled = saveButtonEnabled && isValidZipCode(txtCustomersNewZip.Text);
            saveButtonEnabled = saveButtonEnabled && isValidPhoneNumber(txtCustomersNewPhone.Text);
            saveButtonEnabled = saveButtonEnabled && cbxCustomersNewState.SelectedIndex != -1;
            saveButtonEnabled = saveButtonEnabled && !isEmpty(CreateNewCustomerTitleLabel.Text);
            saveButtonEnabled = saveButtonEnabled && (txtBoxNewCustomersPassword.Text.Length >= 8);
            saveButtonEnabled = saveButtonEnabled && (txtBoxNewCustomerConfirmedPassword.Text.Length >= 8);
            saveButtonEnabled = saveButtonEnabled &&
                                (txtBoxNewCustomersPassword.Text.Equals(txtBoxNewCustomerConfirmedPassword.Text));
            btnCustomersNewCustomerSave.Enabled = saveButtonEnabled;
        }

        private void txtField_Enter(object sender, EventArgs e)
        {
            infoLabel.Text = toolTip.GetToolTip((Control) sender);
        }

        private void txtField_Leave(object sender, EventArgs e)
        {
           /* ((Customer)customerBindingSource.Current).FirstName = txtCustomersNewFirstName.Text;
            ((Customer)customerBindingSource.Current).LastName = txtCustomersNewLastName.Text;
            ((Customer)customerBindingSource.Current).StreetAddress = txtCustomersNewStreetAddress.Text;
            ((Customer)customerBindingSource.Current).PhoneNumber = txtCustomersNewPhone.Text;
            ((Customer)customerBindingSource.Current).Title = cbxNewCustomerTitle.SelectedItem.ToString();
            if (isValidZipCode(txtCustomersNewZip.Text))
            {
                ZipCode zip = new ZipCode(){
                    Code = txtCustomersNewZip.Text,
                    City = txtCustomersNewCity.Text,
                    State = cbxCustomersNewState.SelectedItem.ToString()
                };

                ((Customer) customerBindingSource.Current).ZipCode = zip;
            }
            ((Customer)customerBindingSource.Current).Password = txtBoxNewCustomersPassword.Text;*/
            setMoreInfoTextToDefault();
        }

        private void cbxInventoryAddVideoMovieID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInventoryAddVideo.Enabled = cbxInventoryAddVideoMovieID.SelectedIndex != -1;
        }
      

        private void createNewCustomer(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetDefaultNewCusomterTab();
            grpNewCustomer.Visible = true;
            CreateNewCustomerLinkLabel.Visible = false;
            customerBindingSource.AddNew();

        }

        private void grpNewCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxCustomerZipCode_Leave(object sender, EventArgs e)
        {
            if(isValidZipCode(txtCustomersNewZip.Text))
            {
              

                string zipCodeString = txtCustomersNewZip.Text.ToString();
                var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
                var query = from zip in session.Query<Model.ZipCode>()
                    where zip.Code.Equals(zipCodeString)
                    select zip;


                if (query.Any())
                {
                    var zipCode = query.Single();
                    txtCustomersNewCity.Text = zipCode.City;
                    cbxCustomersNewState.Text = zipCode.State;
                    saveZipCode = false;
                }
                else
                {
                    NewZipCodeForm zipCodeForm = new NewZipCodeForm(txtCustomersNewZip.Text.ToString());
                    zipCodeForm.ShowDialog();
                    txtCustomersNewCity.Text = zipCodeForm.city;
                    cbxCustomersNewState.Text = zipCodeForm.state;
                    saveZipCode = true;
                }
            }

            newCustomerTextField_TextChanged(sender, e);
            txtReportZipCode_Leave(sender, e);
        }

        private void btnCustomerNewCustomerCancel_Click(object sender, EventArgs e)
        {
            customerBindingSource.CancelEdit();
            customerBindingSource.DataSource = typeof (Customer);
            ResetDefaultNewCusomterTab();
            
        }


        private void ResetDefaultNewCusomterTab()
        {
            
            grpNewCustomer.Visible = false;
            grpNewCustomer.Text = "Inserting new customer";
            txtCustomersNewCity.Clear();
            cbxCustomersNewState.SelectedIndex = -1;
            cbxNewCustomerTitle.SelectedIndex =-1;
            txtCustomersNewFirstName.Clear();
            txtCustomersNewLastName.Clear();
            txtCustomersNewStreetAddress.Clear();
            txtCustomersNewZip.Clear();
            txtCustomersNewPhone.Clear();
            txtBoxNewCustomersPassword.Clear();
            txtBoxNewCustomerConfirmedPassword.Clear();
            lnklblCustomersShowAllRentalHistory.Visible = false;
            lnklblCustomersShowCurrentRentals.Visible = false;


            CreateNewCustomerLinkLabel.Visible = true;
        }

        private void scanBarCodeLinkLabel_Click(object sender, EventArgs e)
        {
            ScanCustomerBarCodeForm scanCustomerBarCodeForm = new ScanCustomerBarCodeForm();
            scanCustomerBarCodeForm.ShowDialog();
            if (scanCustomerBarCodeForm.SelectedCustomer != null)
            {
                EditCustomer(scanCustomerBarCodeForm.SelectedCustomer.CustomerId);
            }

        }


        private void EditCustomer(int customerID)
        {
            grpNewCustomer.Visible = true;
            CreateNewCustomerLinkLabel.Visible = false;
                
            var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
            var query = from cust in session.Query<Model.Customer>()
            where cust.CustomerId == customerID 
            select cust;

            if (query.Any())
            {
                var customer = query.Single();
                testCustomer = customer;
                otherCustomer = customer;
                customerBindingSource.DataSource = customer;
                grpNewCustomer.Text = "Editing customer " + customer.FullName;
                /*
                
                txtCustomersNewCity.Text = customer.City;
                cbxCustomersNewState.Text = customer.State;
                cbxNewCustomerTitle.Text = customer.Title;
                txtCustomersNewFirstName.Text = customer.FirstName;
                txtCustomersNewLastName.Text = customer.LastName;
                txtCustomersNewStreetAddress.Text = customer.StreetAddress;
                txtCustomersNewZip.Text = customer.ZipCode.Code;
                txtCustomersNewPhone.Text = customer.PhoneNumber;
                txtBoxNewCustomersPassword.Text = customer.Password;
                txtBoxNewCustomerConfirmedPassword.Text = customer.Password;
                */
            }

        }

        private void lnklblCustomersShowAllRentalHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RentalForm rental = new RentalForm((Customer)customerBindingSource.DataSource,true);
            rental.ShowDialog();

        }

        private void btnSearchCustomerCustomers_Click(object sender, EventArgs e)
        {
            string lastName = txtSearchLastName.Text;
            string firstName = txtSearchFirstName.Text;
            SelectCustomerForm select = new SelectCustomerForm(lastName, firstName);
            select.ShowDialog();
            testCustomer = select.SelectedCustomer;
            otherCustomer = select.SelectedCustomer;
            grpNewCustomer.Visible = true;
            grpNewCustomer.Text = "Editing customer " + testCustomer.FullName;
            CreateNewCustomerLinkLabel.Visible = false;
            customerBindingSource.DataSource = testCustomer;
        }

        private void btnCustomersNewCustomerSave_Click(object sender, EventArgs e)
        {
            ZipCode zip;
            var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
            if (saveZipCode)
            {

                zip = new ZipCode()
                {
                    Code = txtCustomersNewZip.Text,
                    City = txtCustomersNewCity.Text,
                    State = cbxCustomersNewState.SelectedItem.ToString()
                };
                session.Save(zip);
            }
            else
            {
                var query = from zipCode in session.Query<Model.ZipCode>()
                            where zipCode.Code == txtCustomersNewZip.Text
                            select zipCode;
            
                
                    zip = query.Single();
              
            }
            Customer saveCustomer = new Customer()
            {
                Title = cbxNewCustomerTitle.Text,
                FirstName = txtCustomersNewFirstName.Text,
                LastName = txtCustomersNewLastName.Text,
               

                ZipCode = zip,
                //EmailAddress = "mcfall@hope.edu",
                Password = txtBoxNewCustomersPassword.Text,
                StreetAddress = txtCustomersNewStreetAddress.Text,
                PhoneNumber = txtCustomersNewPhone.Text
                
            };
            session.SaveOrUpdate(saveCustomer);
            session.Flush();
            ResetDefaultNewCusomterTab();
        }

        private void lnklblCustomersShowCurrentRentals_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RentalForm rental = new RentalForm((Customer)customerBindingSource.DataSource, false);
            rental.ShowDialog();
        }


    }
}
