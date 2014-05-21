using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using NHibernate;
using NHibernate.Linq;

using NHibernate.Hql.Ast.ANTLR;

namespace Web_Interface.Controllers
{
    public class HomeController : BaseController
    {        
        public HomeController()
        {
            
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var session = SessionFactory.GetCurrentSession();
            var query = session.Query<Customer>();

            var customerQuery = from customer in query
                where customer.LastName.Equals("McFall")
                select customer;

            return View(customerQuery.First());
        }
    }
}
