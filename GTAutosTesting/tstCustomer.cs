using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstCustomer
    {
        string customerPassword = "qwertyuiop";
        string address = "21B Test Address, Test Town";
        string postCode = "AA1 1AA";
        string customerFirstName = "Testy";
        string customerLastName = "McTester";
        string customerPhoneNumber = "01234567890";
        string customerEmail = "testymctester@testemail.com";
        string dateAdded = "06/03/2020";
        string dateOfBirth = "13/05/1996";

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
        }

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
        public void CustomerFirstNameLessThanOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerFirstName = "";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerFirstName = "a";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerFirstName = "aa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
        }

        [TestMethod]
        public void CustomerFirstNameMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerFirstName = "aaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerFirstName = "aaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        public void CustomerFirstNameMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerFirstName = "aaaaaaaaaa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerFirstName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerFirstName = "";
            customerFirstName = customerFirstName.PadRight(500, 'a');
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
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
        public void CustomerLastNameLessThanOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerLastName = "";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerLastName = "a";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerLastName = "aa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerLastName = "aaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerLastName = "aaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        public void CustomerLastNameMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerLastName = "aaaaaaaaaa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerLastName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerFirstName = "";
            customerFirstName = customerLastName.PadRight(500, 'a');
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
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
        public void DateAddedExtremeMin() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String dateAdded = TestDate.ToString();
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            String dateAdded = TestDate.ToString();
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

         [TestMethod]
        public void DateAddedMin() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String dateAdded = TestDate.ToString();
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            String dateAdded = TestDate.ToString();
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String dateAdded = TestDate.ToString();
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String dateAdded = "This is not a date.";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
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
        public void CustomerEmailLessThanOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerEmail = "";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerEmail = "a@a.com";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerEmail = "aa@a.com";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerEmail = "thisisafortyninecharacteremail@testtestyemail.com";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerEmail = "thisisafiftycharacteremailhahah@testtestyemail.com";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        public void CustomerEmailMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerEmail = "halfieemail@emailhalf.com";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerEmail = "thisisanexccessivelylongemail@testrlystupidemail.com";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerEmail = "stupidpointlessemailtestconditionmustlookforthemaximumlevelofcharacterspossiblethatsomeonewouldselfishlyenter@icantbebotheredtocomeupwithadecentemaildomain.co.uk";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "01234567890";
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
        public void CustomerPhoneNumberLessThanOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "0";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "01";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "0123456789";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "01234567890";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        public void CustomerPhoneNumberMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "012345";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "012345678901";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "0123456789001234567890012345678900123456789001234567890012345678900123456789001234567890";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
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
        public void CustomerDOBExtremeMin() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String dateAdded = TestDate.ToString();
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMinLessOne() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-16);
            String dateAdded = TestDate.ToString();
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

         [TestMethod]
        public void CustomerDOBMin() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-17);
            String dateAdded = TestDate.ToString();
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMinPlusOne() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-18);
            String dateAdded = TestDate.ToString();
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDOBInvalidData() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String dateAdded = "This is not a date.";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
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
        public void CustomerAddressLessThanOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String address = "";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String address = "2";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String address = "21";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String address = "Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Testin";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String address = "Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Testing";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        public void CustomerAddressMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String address = "Flat 21, Test House, Test Road, Test Town, Test County";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String address = "Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Test Testing";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String address = "Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Test Testing, Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Test Testing";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
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
        public void CustomerPostCodeLessThanOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String postCode = "";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String postCode = "L";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String postCode = "LE";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String postCode = "LE2 9PT";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String postCode = "SE17 4TE";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        public void CustomerPostCodeMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String postCode = "LE27PT";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String postCode = "SE16 8TDE";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String postCode = "SEH34 8EDF";
            Error = aCustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, dateAdded, dateOfBirth, customerPassword, address, postCode);
            Assert.AreEqual(Error, "");
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
