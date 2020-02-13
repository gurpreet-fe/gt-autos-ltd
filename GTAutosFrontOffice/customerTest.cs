using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void InstanceOK()
        {
            Customer aCustomer = new Customer();
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void FindMethod()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFindCustomerIDFound()
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
        public void CustomerIDPropertyOK()
        {
            Customer aCustomer = new Customer();
            Int32 TestData = 1;
            aCustomer.CustomerID = TestData;
            Assert.AreEqual(aCustomer.CustomerID, TestData);
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
        public void TestActiveFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue = OK;
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
            if (aCustomer.DateAdded != Convert.ToDateTime("12/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
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
        public void CustomerPasswordFound()
        {
            Customer aCustomer = new Customer();
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
            Customer aCustomer = new Customer();
            string TestData = "jimbob.morrison@outlook.com";
            aCustomer.CustomerEmail = TestData;
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerEmailFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerEmail != "testymctester@testemail.com")
            {
                OK = false;
            }
            Assert.IsTrue = OK;
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
        public void CustomerFirstNameFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerFirstName != "Testy")
            {
                OK = false;
            }
            Assert.IsTrue = OK;
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
        public void CustomerLastNameFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerLastName != "McTester")
            {
                OK = false;
            }
            Assert.IsTrue = OK;
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
        public void CustomerPhoneNumberFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerPhoneNumber != "01234 567890")
            {
                OK = false;
            }
            Assert.IsTrue = OK;
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
        public void CustomerDOBFound()
        {
            Customer aCustomer = new Customer();
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
            Customer aCustomer = new Customer();
            Int32 TestData = 1;
            aCustomer.AddressNo = TestData;
            Assert.AreEqual(aCustomer.AddressNo, TestData);
        }

        [TestMethod]
        public void CustomerAddressNoFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.AddressNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue = OK;
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            Customer aCustomer = new Customer();
            Int32 TestData = 1;
            aCustomer.CountyNo = TestData;
            Assert.AreEqual(aCustomer.CountyNo, TestData);
        }

        [TestMethod]
        public void CustomerCountyNoFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CountyNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue = OK;
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "21A";
            aCustomer.HouseNo = TestData;
            Assert.AreEqual(aCustomer.HouseNo, TestData);
        }

        [TestMethod]
        public void CustomerHouseNoFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.HouseNo != "1B")
            {
                OK = false;
            }
            Assert.IsTrue = OK;
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
        public void CustomerPostCodeFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.PostCode != "AA1 1AA")
            {
                OK = false;
            }
            Assert.IsTrue = OK;
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "West Street";
            aCustomer.Street = TestData;
            Assert.AreEqual(aCustomer.Street, TestData);
        }

        public void CustomerPostCodeFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.PostCode != "AA1 1AA")
            {
                OK = false;
            }
            Assert.IsTrue = OK;
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            Customer aCustomer = new Customer();
            string TestData = "Leicester";
            aCustomer.Town = TestData;
            Assert.AreEqual(aCustomer.Town, TestData);
        }

        public void CustomerPostCodeFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Town != "Test Town")
            {
                OK = false;
            }
            Assert.IsTrue = OK;
        }

        [TestMethod]
        public void MarketingOK()
        {
            Customer aCustomer = new Customer();
            Boolean TestData = false;
            aCustomer.Marketing = TestData;
            Assert.AreEqual(aCustomer.Marketing, TestData);
        }

        public void CustomerPostCodeFound()
        {
            Customer aCustomer = new Customer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Town != false)
            {
                OK = false;
            }
            Assert.IsTrue = OK;
        }


    }
}
