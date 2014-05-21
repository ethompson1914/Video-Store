using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Testing;
using Model;
using NUnit.Framework;

namespace Tests.Employees
{
    public class TestEmployeeMap : BaseTest
    {
        [Test]
        public void VerifyMappings()
        {
            DateTime dateHired = DateTime.Now;
            DateTime dateOfBirth = dateHired.AddYears(-18);

            //var supervisor = new Employee()
            //{
            //    DateHired = dateHired,
            //    DateOfBirth = dateOfBirth,
            //    FirstName = "Boss",
            //    LastName = "Person",
            //    Supervisor = null
            //};

            //_session.Save(supervisor);

            new PersistenceSpecification<Employee>(Session, new CustomComparator())
                .CheckProperty(c => c.FirstName, "Employee")
                .CheckProperty(c => c.LastName, "One")
                .CheckProperty(c => c.DateHired, dateHired)                
                .CheckProperty(c => c.DateOfBirth, dateOfBirth)
                .CheckReference(c => c.Supervisor, new Employee()
                {
                    DateHired = dateHired,
                    DateOfBirth = dateOfBirth,
                    FirstName = "Boss",
                    LastName = "Person",
                    Supervisor = null
                })
                .VerifyTheMappings();
        }
    }    
}
