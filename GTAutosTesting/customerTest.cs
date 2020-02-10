using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void TestFindCustomerIDOK()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFindCustomerNoFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void InstanceOK()
        {
            Customer aCustomer = new Customer();
            Assert.IsNotNull(aCustomer);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //new instance of class
            Customer aCustomer = new Customer();
            //Test data to assign
            Boolean TestData = true;
            //assign data to property
            aCustomer.Active = TestData;
            //test to see that the data matches
            Assert.AreEqual(aCustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            Customer aCustomer = new Customer();
            DateTime TestData = DateTime.Now.Date;
            aCustomer.DateAdded = TestData;
            Assert.AreEqual(aCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.DateAdded != Convert.ToDateTime("31/01/1900"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            Customer aCustomer = new Customer();
            Int32 TestData = 1;
            aCustomer.CustomerID = TestData;
            Assert.AreEqual(aCustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "asdfghjkl";
            char PasswordChar = '*';
            aCustomer.CustomerPassword = TestData;
            Assert.AreEqual(aCustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CustomerEmailOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "jimbob.morrison@outlook.com";
            aCustomer.CustomerEmail = TestData;
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "Jimbo";
            aCustomer.CustomerFirstName = TestData;
            Assert.AreEqual(aCustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastNameOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "Morrison";
            aCustomer.CustomerLastName = TestData;
            Assert.AreEqual(aCustomer.CustomerLastName, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumberOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "07690409231";
            aCustomer.CustomerPhoneNumber = TestData;
            Assert.AreEqual(aCustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void CustomerDOBOK()
        {
            Customer aCustomer = new Customer();
            DateTime TestData = Convert.ToDateTime("31/01/1900");
            aCustomer.CustomerDOB = TestData;
            Assert.AreEqual(aCustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void AddressNumberPropertyOK()
        {
            Customer aCustomer = new Customer();
            Int32 TestData = 1;
            aCustomer.AddressNo = TestData;
            Assert.AreEqual(aCustomer.AddressNo, TestData);
        }

        [TestMethod]
        public void CountyNumberPropertyOK()
        {
            Customer aCustomer = new Customer();
            Int32 TestData = 1;
            aCustomer.CountyNo = TestData;
            Assert.AreEqual(aCustomer.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNumberPropertyOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "21A";
            aCustomer.HouseNo = TestData;
            Assert.AreEqual(aCustomer.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "LE1 7PT";
            aCustomer.PostCode = TestData;
            Assert.AreEqual(aCustomer.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "West Street";
            aCustomer.Street = TestData;
            Assert.AreEqual(aCustomer.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "Leicester";
            aCustomer.Town = TestData;
            Assert.AreEqual(aCustomer.Town, TestData);
        }

        [TestMethod]
        public void MarketingOK()
        {
            Customer aCustomer = new Customer();
            Boolean TestData = false;
            aCustomer.Marketing = TestData;
            Assert.AreEqual(aCustomer.Marketing, TestData);
        }


    }
}
