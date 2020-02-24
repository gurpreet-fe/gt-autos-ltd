using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstCustomer
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void FindMethod()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFindCustomerIDFound()
        {
            clsCustomer aCustomer = new clsCustomer();
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
        public void CustomerIDPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Int32 TestData = 1;
            aCustomer.CustomerID = TestData;
            Assert.AreEqual(aCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean TestData = true;
            aCustomer.Active = TestData;
            Assert.AreEqual(aCustomer.Active, TestData);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            aCustomer.DateAdded = TestData;
            Assert.AreEqual(aCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.DateAdded != Convert.ToDateTime("12/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "asdfghjkl";
            char PasswordChar = '*';
            aCustomer.CustomerPassword = TestData;
            Assert.AreEqual(aCustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CustomerPasswordFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerPassword != "qwertyuiop")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void CustomerEmailOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "jimbob.morrison@outlook.com";
            aCustomer.CustomerEmail = TestData;
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerEmailFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerEmail != "testymctester@testemail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Jimbo";
            aCustomer.CustomerFirstName = TestData;
            Assert.AreEqual(aCustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerFirstName != "Testy")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerLastNameOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Morrison";
            aCustomer.CustomerLastName = TestData;
            Assert.AreEqual(aCustomer.CustomerLastName, TestData);
        }

        [TestMethod]
        public void CustomerLastNameFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerLastName != "McTester")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerPhoneNumberOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "07690409231";
            aCustomer.CustomerPhoneNumber = TestData;
            Assert.AreEqual(aCustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumberFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerPhoneNumber != "01234567890")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerDOBOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            DateTime TestData = Convert.ToDateTime("31/01/1900");
            aCustomer.CustomerDOB = TestData;
            Assert.AreEqual(aCustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerDOBFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerDOB != Convert.ToDateTime("12/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            String TestData = "21 Test Street, Test Town";
            aCustomer.Address = TestData;
            Assert.AreEqual(aCustomer.Address, TestData);
        }

        [TestMethod]
        public void CustomerAddressFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Address != "21 Test Street, Test Town")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "LE1 7PT";
            aCustomer.PostCode = TestData;
            Assert.AreEqual(aCustomer.PostCode, TestData);
        }

        [TestMethod]
        public void CustomerPostCodeFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.PostCode != "AA1 1AA")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void MarketingOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean TestData = false;
            aCustomer.Marketing = TestData;
            Assert.AreEqual(aCustomer.Marketing, TestData);
        }

        public void MarketingFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Marketing != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
