using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Model;
using NHibernate;
using NHibernate.Linq;
using Web_Interface.Models;

namespace Web_Interface.Controllers
{
    public class RegisterController : BaseController
    {
        class ZipCodeDisplay
        {
            private ZipCode _zipCode;

            public string ZipCode
            {
                get { return _zipCode.Code; }
                
            }

            private string City
            {
                get { return _zipCode.City; }
            }

            private string State
            {
                get { return _zipCode.State; }
            }

            public string DisplayValue
            {
                get { return String.Format("{0}: {1} {2}", ZipCode, City, State); }
            }

            public ZipCodeDisplay(ZipCode zip)
            {
                _zipCode = zip;
            }
        }

        private readonly Customer _customer;

        public RegisterController()
        {
            _customer = new Customer()
            {
                FirstName = "Ryan",
                LastName = "McFall",
                ZipCode = new ZipCode()
                {
                    Code = "49464",
                    City = "Zeeland",
                    State = "MI"
                },
                EmailAddress = "mcfall@hope.edu",
                Password = "password",
                StreetAddress = "1260 Winterwood Lane"
            };
        }

        //
        // GET: /Register/
        [HttpGet]
        public ActionResult Index()
        {                            
            ViewBag.ZipCodes = new SelectList(GetZipCodes(), "ZipCode", "DisplayValue");
            return View(new Customer());
        }
        
        [HttpPost]
        public ViewResult Index(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (CustomerExists(customer.EmailAddress))
                {
                    return View("DuplicateEmail", customer);
                }
                else
                {
                    SaveCustomer(customer);
                    return View("AccountCreated", customer);
                }                                                
            }
            else
            {
                return View(customer);
            }
            
        }

        //  
        //  Get: /Register/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginInfo credentials)
        {
            var customer = LoginCorrect(credentials);

            if (customer != null)
            {
                FormsAuthentication.SetAuthCookie(credentials.EmailAddress, false);
                Session["Customer"] = customer;
                return Redirect("/");
            }
            else
            {
                ViewBag.LoginError = true;
                return View();
            }
        }

        private bool CustomerExists(string emailAddress)
        {
            var session = SessionFactory.GetCurrentSession();
            var query = session.Query<Customer>();

            var customerQuery = from customer in query
                                where customer.EmailAddress.Equals(emailAddress)
                                select customer;
            //Console.Write(customerQuery.Count() > 0);
            return customerQuery.Any();
        }

        private Customer LoginCorrect(LoginInfo credentials)
        {
            var session = SessionFactory.GetCurrentSession();
            var query = from cust in session.Query<Customer>()
                        where cust.EmailAddress.ToLower().Equals(credentials.EmailAddress)
                        select cust;

            try
            {
                var customer = query.Single();
                return customer.Password.Equals(credentials.Password) ? customer : null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void SaveCustomer(Customer customer)
        {
            var session = SessionFactory.GetCurrentSession();
            //ITransaction transaction = session.BeginTransaction();
            session.Save(customer);
           // transaction.Commit();
            //session.Close();

        }

        private IEnumerable<ZipCodeDisplay> GetZipCodes()
        {
            var session = SessionFactory.GetCurrentSession();
            var query = from zip in session.Query<ZipCode>()
                        orderby zip.State, zip.City
                        select new ZipCodeDisplay(zip);
            return query;
        }
    }
}
