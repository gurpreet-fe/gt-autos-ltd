using System;
using System.Collections.Generic;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of a customer collection, a test customer list and a customer
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            List<clsCustomer> testCustomerList = new List<clsCustomer>();
            clsCustomer testCustomer = new clsCustomer();

            //define the customer's properties
            testCustomer.CustomerID = 6;
            testCustomer.CustomerFirstName = "Matt";
            testCustomer.CustomerLastName = "Smart";
            testCustomer.CustomerPhoneNumber = "07123456789";
            testCustomer.Address = "1 Test Street, Leicester";
            testCustomer.CustomerEmail = "mattsmart@email.com";
            testCustomer.CustomerPassword = "asdfghjkl";
            testCustomer.PostCode = "LE2 7PT";
            testCustomer.CustomerDOB = Convert.ToDateTime("13/05/1996");
            testCustomer.Marketing = true;
            testCustomer.DateAdded = DateTime.Now.Date;
            testCustomer.Active = true;
            
            //add the test customer to the list
            testCustomerList.Add(testCustomer);

            allCustomers.CustomerList = testCustomerList;

            Assert.AreEqual(allCustomers.CustomerList, testCustomerList);
        }

        [TestMethod]
        public void ThisCustomerOK()
        {
            //create an instance of a customer collection and a customer
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            clsCustomer testCustomer = new clsCustomer();

            //define the customer's properties
            testCustomer.CustomerID = 6;
            testCustomer.CustomerFirstName = "Matt";
            testCustomer.CustomerLastName = "Smart";
            testCustomer.CustomerPhoneNumber = "07123456789";
            testCustomer.Address = "1 Test Street, Leicester";
            testCustomer.CustomerEmail = "mattsmart@email.com";
            testCustomer.CustomerPassword = "asdfghjkl";
            testCustomer.PostCode = "LE2 7PT";
            testCustomer.CustomerDOB = Convert.ToDateTime("13/05/1996");
            testCustomer.Marketing = true;
            testCustomer.DateAdded = DateTime.Now.Date;
            testCustomer.Active = true;

            allCustomers.ThisCustomer = testCustomer;

            Assert.AreEqual(allCustomers.ThisCustomer, testCustomer);
        }

        public void ListAndCountCustomersOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            List<clsCustomer> testCustomerList = new List<clsCustomer>();
            clsCustomer testCustomer = new clsCustomer();

            //define the customer's properties
            testCustomer.CustomerID = 6;
            testCustomer.CustomerFirstName = "Matt";
            testCustomer.CustomerLastName = "Smart";
            testCustomer.CustomerPhoneNumber = "07123456789";
            testCustomer.Address = "1 Test Street, Leicester";
            testCustomer.CustomerEmail = "mattsmart@email.com";
            testCustomer.CustomerPassword = "asdfghjkl";
            testCustomer.PostCode = "LE2 7PT";
            testCustomer.CustomerDOB = Convert.ToDateTime("13/05/1996");
            testCustomer.Marketing = true;
            testCustomer.DateAdded = DateTime.Now.Date;
            testCustomer.Active = true;

            testCustomerList.Add(testCustomer);
            allCustomers.CustomerList = testCustomerList;
            Assert.AreEqual(testCustomerList.Count, allCustomers.Count);

        }

    }
}