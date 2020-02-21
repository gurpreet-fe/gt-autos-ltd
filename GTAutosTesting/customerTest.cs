using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class ClsCustomerTest
    {

        [TestMethod]
        public void InstanceOK()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void FindMethod()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFindCustomerIDFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
            ClsCustomer aCustomer = new ClsCustomer();
            Int32 TestData = 1;
            aCustomer.CustomerID = TestData;
            Assert.AreEqual(aCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //new instance of class
            ClsCustomer aCustomer = new ClsCustomer();
            //Test data to assign
            Boolean TestData = true;
            //assign data to property
            aCustomer.Active = TestData;
            //test to see that the data matches
            Assert.AreEqual(aCustomer.Active, TestData);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
            ClsCustomer aCustomer = new ClsCustomer();
            DateTime TestData = DateTime.Now.Date;
            aCustomer.DateAdded = TestData;
            Assert.AreEqual(aCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
            ClsCustomer aCustomer = new ClsCustomer();
            string TestData = "asdfghjkl";
            char PasswordChar = '*';
            aCustomer.CustomerPassword = TestData;
            Assert.AreEqual(aCustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CustomerPasswordFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
            ClsCustomer aCustomer = new ClsCustomer();
            string TestData = "jimbob.morrison@outlook.com";
            aCustomer.CustomerEmail = TestData;
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerEmailFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
            ClsCustomer aCustomer = new ClsCustomer();
            string TestData = "Jimbo";
            aCustomer.CustomerFirstName = TestData;
            Assert.AreEqual(aCustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
            ClsCustomer aCustomer = new ClsCustomer();
            string TestData = "Morrison";
            aCustomer.CustomerLastName = TestData;
            Assert.AreEqual(aCustomer.CustomerLastName, TestData);
        }

        [TestMethod]
        public void CustomerLastNameFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
            ClsCustomer aCustomer = new ClsCustomer();
            string TestData = "07690409231";
            aCustomer.CustomerPhoneNumber = TestData;
            Assert.AreEqual(aCustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumberFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerPhoneNumber != "01234 567890")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerDOBOK()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            DateTime TestData = Convert.ToDateTime("31/01/1900");
            aCustomer.CustomerDOB = TestData;
            Assert.AreEqual(aCustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerDOBFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
        public void AddressNumberPropertyOK()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Int32 TestData = 1;
            aCustomer.AddressNo = TestData;
            Assert.AreEqual(aCustomer.AddressNo, TestData);
        }

        [TestMethod]
        public void CustomerAddressNoFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.AddressNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Int32 TestData = 1;
            aCustomer.CountyNo = TestData;
            Assert.AreEqual(aCustomer.CountyNo, TestData);
        }

        [TestMethod]
        public void CustomerCountyNoFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CountyNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            string TestData = "21A";
            aCustomer.HouseNo = TestData;
            Assert.AreEqual(aCustomer.HouseNo, TestData);
        }

        [TestMethod]
        public void CustomerHouseNoFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.HouseNo != "1B")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            string TestData = "LE1 7PT";
            aCustomer.PostCode = TestData;
            Assert.AreEqual(aCustomer.PostCode, TestData);
        }

        [TestMethod]
        public void CustomerPostCodeFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
        public void StreetPropertyOK()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            string TestData = "West Street";
            aCustomer.Street = TestData;
            Assert.AreEqual(aCustomer.Street, TestData);
        }

        public void CustomerStreetFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Street != "Test Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            string TestData = "Leicester";
            aCustomer.Town = TestData;
            Assert.AreEqual(aCustomer.Town, TestData);
        }

        public void CustomerTownFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Town != "Test Town")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void MarketingOK()
        {
            ClsCustomer aCustomer = new ClsCustomer();
            Boolean TestData = false;
            aCustomer.Marketing = TestData;
            Assert.AreEqual(aCustomer.Marketing, TestData);
        }

        public void MarketingFound()
        {
            ClsCustomer aCustomer = new ClsCustomer();
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
