using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class OfficeTesting
    {

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


        [TestMethod]
        public void InspectionDate()
        {
            //create an instance of the class we want to create
            OfficeClasses AnOffice = new OfficeClasses();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOffice.InspectionDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOffice.InspectionDate, TestData);
        }

        [TestMethod]
        public void AddressLine1()
        {
            //create an instance of the class we want to create
            OfficeClasses AnOffice = new OfficeClasses();
            //create some test data to assign to the property
            string TestData = "Flat 108, Ben Russell Court";
            //assign the data to the property
            AnOffice.AddressLine1 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOffice.AddressLine1, TestData);
        }


        [TestMethod]
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
        }


        [TestMethod]
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
        }

        [TestMethod]
        public void City()
        {
            //create an instance of the class we want to create
            OfficeClasses AnOffice = new OfficeClasses();
            //create some test data to assign to the property
            string TestData = "LEICESTER";
            //assign the data to the property
            AnOffice.City = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOffice.City, TestData);
        }

        [TestMethod]
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
        }

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
            if (AnOffice.PostCode != "XXX XXX")
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

        // ------------------------------------------------------------VALIDATION TESTING-------------------------------------------------------------------------------

        [TestMethod]
        public void ValidMethodOK()
        {
            OfficeClasses AnOffice = new OfficeClasses();
            String Error = "";
            Error = AnOffice.Valid(AddressLine1, AddressLine2, PostCode, PhoneNumber, InspectionDate);
            Assert.AreEqual(Error, "");
        }

        // ------------------------------------------------------------TESTING VALID TEST CASES-------------------------------------------------------------------------------

        





    }
}
