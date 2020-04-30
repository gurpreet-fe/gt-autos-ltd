using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class OfficeTesting
    {

        string AddressLine1 = "Test Street";
        string AddressLine2 = "Test Street 2";
        string City = "Test City";
        string PostCode = "T3S TPC";
        string PhoneNumber = "12345678910";
        string InspectionDate = DateTime.Now.Date.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Assert.IsNotNull(AnOffice);
        }

        [TestMethod]
        public void OfficeCode()
        {
            //create an instance of the class we want to create
            OfficeClasses AnOffice = new OfficeClasses();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOffice.OfficeCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOffice.OfficeCode, TestData);
        }

        [TestMethod]
        public void IsActive()
        {
            //create the instance of the class we want to create
            OfficeClasses AnOffice = new OfficeClasses();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOffice.IsActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOffice.IsActive, TestData);
        }


        //[TestMethod]
        /*public void InspectionDate()
        {
            //create an instance of the class we want to create
            OfficeClasses AnOffice = new OfficeClasses();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOffice.InspectionDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOffice.InspectionDate, TestData);
        }*/

        //[TestMethod]
        /*public void AddressLine1()
        {
            //create an instance of the class we want to create
            OfficeClasses AnOffice = new OfficeClasses();
            //create some test data to assign to the property
            string TestData = "Flat 108, Ben Russell Court";
            //assign the data to the property
            AnOffice.AddressLine1 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOffice.AddressLine1, TestData);
        }*/


        /*[TestMethod]
        public void AddressLine2()
        {
            //create an instance of the class we want to create
            OfficeClasses AnAddress = new OfficeClasses();
            //create some test data to assign to the property
            string TestData = "25 Grasmere Street";
            //assign the data to the property
            AnAddress.AddressLine2 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.AddressLine2, TestData);
        }*/


        /*[TestMethod]
        public void PostCode()
        {
            //create an instance of the class we want to create
            OfficeClasses AnOffice = new OfficeClasses();
            //create some test data to assign to the property
            string TestData = "LE2 7PT";
            //assign the data to the property
            AnOffice.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOffice.PostCode, TestData);
        }*/

        //[TestMethod]
        /*public void City()
        {
            //create an instance of the class we want to create
            OfficeClasses AnOffice = new OfficeClasses();
            //create some test data to assign to the property
            string TestData = "LEICESTER";
            //assign the data to the property
            AnOffice.City = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOffice.City, TestData);
        }*/

        /*[TestMethod]
        public void PhoneNumber()
        {
            //create an instance of the class we want to create
            OfficeClasses AnAddress = new OfficeClasses();
            //create some test data to assign to the property
            string TestData = "12345678910";
            //assign the data to the property
            AnAddress.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PhoneNumber, TestData);
        }*/

        // ------------------------------------------------------------FIND METHOD TESTING-------------------------------------------------------------------------------

        [TestMethod]
        public void FindMethodOK()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Boolean Found = false;
            Int32 OfficeCode = 1;
            Found = AnOffice.Find(OfficeCode);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOfficeCodeFound()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OfficeCode = 1;
            Found = AnOffice.Find(OfficeCode);
            if (AnOffice.OfficeCode != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInspectionDateFound()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OfficeCode = 1;
            Found = AnOffice.Find(OfficeCode);
            if (AnOffice.InspectionDate != Convert.ToDateTime("19/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressLine1Found()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OfficeCode = 1;
            Found = AnOffice.Find(OfficeCode);
            if (AnOffice.AddressLine1 != "Test Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddressLine2Found()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OfficeCode = 1;
            Found = AnOffice.Find(OfficeCode);
            if (AnOffice.AddressLine2 != "Test Street 2")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCityFound()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OfficeCode = 1;
            Found = AnOffice.Find(OfficeCode);
            if (AnOffice.City != "Test City")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OfficeCode = 1;
            Found = AnOffice.Find(OfficeCode);
            if (AnOffice.PostCode != "ABC DEF")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPhoneNumberFound()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OfficeCode = 1;
            Found = AnOffice.Find(OfficeCode);
            if (AnOffice.PhoneNumber != "12345678910")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OfficeCode = 1;
            Found = AnOffice.Find(OfficeCode);
            if (AnOffice.IsActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // ------------------------------------------------------------Validation Testing-------------------------------------------------------------------------------

        [TestMethod]
        public void ValidMethodOK()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            string Error = "";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        // ------------------------------------------------------------Testing Valid Test Cases-------------------------------------------------------------------------------

        //--------------AddressLine1--------------

        [TestMethod]
        public void Address1ValidMinMinus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine1 = ""; //this should trigger an error
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1ValidMinBoundary()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine1 = "T"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address1ValidMinPlus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine1 = "TT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address1ValidMaxMinus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine1 = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address1ValidMax()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine1 = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address1ValidMaxPlus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine1 = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address1ValidMid()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine1 = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address1ValidMaxExtreme()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(500, 'T'); // this should fail
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        //--------------AddressLine2--------------

        [TestMethod]
        public void Address2ValidMinMinus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine2 = ""; //this should trigger an error
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2ValidMinBoundary()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine2 = "T"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address2ValidMinPlus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine2 = "TT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address2ValidMaxMinus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine2 = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address2ValidMax()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine2 = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address2ValidMaxPlus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine2 = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address2ValidMid()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine2 = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address2ValidMaxExtreme()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string AddressLine2 = "";
            AddressLine2 = AddressLine2.PadRight(500, 'T'); // this should fail
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        //--------------InspectionDate--------------

        [TestMethod]
        public void InspectionDateExtremeMin()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-99);
            string InspectionDate = TestDate.ToString();
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InspectionDateMinMinus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string InspectionDate = TestDate.ToString();
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InspectionDateMin()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string InspectionDate = TestDate.ToString();
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InspectionDateMinPlus1()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string InspectionDate = TestDate.ToString();
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InspectionDateExtremeMax()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(99);
            string InspectionDate = TestDate.ToString();
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void InspectionDateInvalidData()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string InspectionDate = "This is not a date!";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");

        }

        //---------PostCode----

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string PostCode = "";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string PostCode = "a";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string PostCode = "aa";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string PostCode = "aaaaaaaa";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string PostCode = "aaaaaaaaa";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string PostCode = "aaaaaaaaaa";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string PostCode = "aaaa";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        // City

        [TestMethod]
        public void CityMinLessOne()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string City = "";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMin()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string City = "a";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string City = "aa";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CityMaxLessOne()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string City = "";
            City = City.PadRight(49, 'a');
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMax()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string City = "";
            City = City.PadRight(50, 'a');
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CitymaxplusOne()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string City = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT"; //this should be ok
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CityMid()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            string City = "";
            City = City.PadRight(25, 'a');
            Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }




    }
}