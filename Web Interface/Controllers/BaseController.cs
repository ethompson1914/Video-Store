using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mappings;
using NHibernate;

namespace Web_Interface.Controllers
{
    public abstract class BaseController : Controller
    {
        private static ISessionFactory _sessionFactory;

        protected BaseController()
        {
        }

        public ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = Mappings.SessionFactory.CreateSessionFactory();
                }
                return _sessionFactory;
            }
        }
    }
}