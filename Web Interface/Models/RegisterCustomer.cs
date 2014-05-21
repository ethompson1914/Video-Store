using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Model;

namespace Web_Interface.Models
{
    public class RegisterCustomer
    {
        private Customer _customer;

        public Customer Customer
        {
            get { return _customer; }

            set { _customer = value; }
        }

        public RegisterCustomer()
        {
            Customer = new Customer();
        }
        
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; } 
    }
}