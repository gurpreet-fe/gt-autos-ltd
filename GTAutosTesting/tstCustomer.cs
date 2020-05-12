using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstCustomer
    {

        string CustomerFirstName = "Jimbo";
        string CustomerLastName = "Testy";
        string CustomerPhoneNumber = "0123456789";
        string Address = "21 Distant Avenue, Northampton";
        string CustomerEmail = "jimbotesty@testemail.com";
        string CustomerPassword = "qwertyuiop";
        string PostCode = "NN1 2AJ";
        string DateOfBirth = "20/12/1989";
        string DateAdded = "06/03/2020";
        string OptInMarketing = "true";


        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
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
            Int32 CustomerID = 2;
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
            Int32 CustomerID = 2;
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
            Int32 CustomerID = 2;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerFirstName != "Jimbo")
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
            String CustomerFirstName = "";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerFirstName = "a";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerFirstName = "aa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerFirstName = "aaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerFirstName = "aaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        public void CustomerFirstNameMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerFirstName = "aaaaaaaaaa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerFirstName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerFirstName = "";
            CustomerFirstName = customerFirstName.PadRight(500, 'a');
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Testy";
            aCustomer.CustomerLastName = TestData;
            Assert.AreEqual(aCustomer.CustomerLastName, TestData);
        }

        [TestMethod]
        public void CustomerLastNameFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerLastName != "Testy")
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
            String CustomerLastName = "";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerLastName = "a";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerLastName = "aa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerLastName = "aaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerLastName = "aaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        public void CustomerLastNameMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerLastName = "aaaaaaaaaa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerLastName = "aaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerFirstName = "";
            CustomerFirstName = CustomerLastName.PadRight(500, 'a');
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TestFindCustomerIDFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Int32 TestData = 2;
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
            Int32 CustomerID = 2;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.DateAdded != Convert.ToDateTime("17/02/2020"))
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
            String DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
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
            String DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

         [TestMethod]
        public void DateAddedMin() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
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
            String DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
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
            String DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String dateAdded = "This is not a date.";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "asdfghjkl";
            aCustomer.CustomerPassword = TestData;
            Assert.AreEqual(aCustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void CustomerPasswordFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
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
            string TestData = "jimbotesty@testemail.com";
            aCustomer.CustomerEmail = TestData;
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerEmailFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerEmail != "jimbotesty@testemail.com")
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
            String CustomerEmail = "";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerEmail = "a@a.com";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerEmail = "aa@a.com";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerEmail = "thisisafortyninecharacteremail@testtestyemail.com";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerEmail = "thisisafiftycharacteremailhahah@testtestyemail.com";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        public void CustomerEmailMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerEmail = "halfieemail@emailhalf.com";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerEmail = "thisisanexccessivelylongemail@testrlystupidemail.com";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerEmail = "stupidpointlessemailtestconditionmustlookforthemaximumlevelofcharacterspossiblethatsomeonewouldselfishlyenter@icantbebotheredtocomeupwithadecentemaildomain.co.uk";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
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
            Int32 CustomerID = 2;
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
            String CustomerPhoneNumber = "";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerPhoneNumber = "0";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPhoneNumberMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerPhoneNumber = "01";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerPhoneNumber = "0123456789";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerPhoneNumber = "01234567890";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        public void CustomerPhoneNumberMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "012345";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String CustomerPhoneNumber = "012345678901";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPhoneNumberExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String customerPhoneNumber = "0123456789001234567890012345678900123456789001234567890012345678900123456789001234567890";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            DateTime TestData = Convert.ToDateTime("20/12/1989");
            aCustomer.CustomerDOB = TestData;
            Assert.AreEqual(aCustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerDOBFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerDOB != Convert.ToDateTime("20/12/1989"))
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
            String DateOfBirth = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
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
            String DateOfBirth = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
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
            String DateOfBirth = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
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
            String DateOfBirth = TestDate.ToString();
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerDOBInvalidData() 
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String DateOfBirth = "This is not a date.";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            String TestData = "21 Distant Avenue, Northampton";
            aCustomer.Address = TestData;
            Assert.AreEqual(aCustomer.Address, TestData);
        }

        [TestMethod]
        public void CustomerAddressFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Address != "21 Distant Avenue, Northampton")
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
            String Address = "";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String Address = "2";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String Address = "21";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String Address = "Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Testin";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String Address = "Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Testing";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        public void CustomerAddressMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String Address = "Flat 21, Test House, Test Road, Test Town, Test County";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String Address = "Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Test Testing";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String Address = "Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Test Testing, Flat 21 Flat 21, Test House Test House, Test Road Test Road, Test Town Test Town, Test County Test Testing";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "NN1 2AJ";
            aCustomer.PostCode = TestData;
            Assert.AreEqual(aCustomer.PostCode, TestData);
        }

        [TestMethod]
        public void CustomerPostCodeFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 2;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.PostCode != "NN1 2AJ")
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
            String PostCode = "";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String PostCode = "N";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPostCodeMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String PostCode = "NN";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxMinusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String PostCode = "NN1 1AJ";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String PostCode = "SE17 4TE";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        public void CustomerPostCodeMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String PostCode = "LE27PT";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String PostCode = "SE16 8TDE";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPostCodeExtremeMad()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            String PostCode = "SEH34 8EDF";
            Error = aCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerPhoneNumber, Address,
            CustomerEmail, CustomerPassword, PostCode, DateOfBirth, Marketing, DateAdded, Active);
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
            Int32 CustomerID = 2;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.Marketing != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
 