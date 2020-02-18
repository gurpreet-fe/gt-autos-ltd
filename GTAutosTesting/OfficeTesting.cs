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
            string TestData = "07516231200";
            //assign the data to the property
            AnAddress.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PhoneNumber, TestData);
        }




    }




}

