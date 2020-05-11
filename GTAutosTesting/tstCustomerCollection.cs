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
            testCustomer.Active = true;
            testCustomer.Address = "21 Test Street, Test Town";
            testCustomer.CustomerID = 2;
            testCustomer.CustomerFirstName = "Matt";
            testCustomer.CustomerLastName = "Smart";
            testCustomer.CustomerPhoneNumber = "07696969696";
            testCustomer.CustomerPassword = "asdfghjkl";
            testCustomer.CustomerEmail = "mattsmart@email.com";
            testCustomer.CustomerDOB = Convert.ToDateTime("13/05/1996");
            testCustomer.Marketing = true;
            testCustomer.DateAdded = DateTime.Now.Date;

            //add the test customer to the list
            testCustomerList.Add(testCustomer);

            allCustomers.CustomerList = testCustomerList;

            Assert.AreEqual(allCustomers.CustomerList, testCustomerList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            Int32 SomeCount = 2;
            allCustomers.Count = SomeCount;
            Assert.AreEqual(allCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomerOK()
        {
            //create an instance of a customer collection and a customer
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            clsCustomer testCustomer = new clsCustomer();

            //define the customer's properties
            testCustomer.Active = true;
            testCustomer.Address = "21 Test Street, Test Town";
            testCustomer.CustomerID = 1;
            testCustomer.CustomerFirstName = "Matt";
            testCustomer.CustomerLastName = "Smart";
            testCustomer.CustomerPhoneNumber = "07696969696";
            testCustomer.CustomerPassword = "asdfghjkl";
            testCustomer.CustomerEmail = "mattsmart@email.com";
            testCustomer.CustomerDOB = Convert.ToDateTime("13/05/1996");
            testCustomer.Marketing = true;
            testCustomer.DateAdded = DateTime.Now.Date;

            allCustomers.ThisCustomer = testCustomer;

            Assert.AreEqual(allCustomers.ThisCustomer, testCustomer);
        }

        public void ListAndCountCustomersOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            List<clsCustomer> testCustomerList = new List<clsCustomer>();
            clsCustomer testCustomer = new clsCustomer();

            //define the customer's properties
            testCustomer.Active = true;
            testCustomer.Address = "21 Test Street, Test Town";
            testCustomer.CustomerID = 1;
            testCustomer.CustomerFirstName = "Matt";
            testCustomer.CustomerLastName = "Smart";
            testCustomer.CustomerPhoneNumber = "07696969696";
            testCustomer.CustomerPassword = "asdfghjkl";
            testCustomer.CustomerEmail = "mattsmart@email.com";
            testCustomer.CustomerDOB = Convert.ToDateTime("13/05/1996");
            testCustomer.Marketing = true;
            testCustomer.DateAdded = DateTime.Now.Date;

            testCustomerList.Add(testCustomer);
            allCustomers.CustomerList = testCustomerList;
            Assert.AreEqual(testCustomerList.Count, allCustomers.Count);

        }

    }
}