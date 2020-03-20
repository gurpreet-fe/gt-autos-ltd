using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstService
    {
        //Creating good test data.
        int ServiceID = 1;
        string ServiceName = "MOT";
        string ServiceDesc = "Fix car";
        double ServicePrice = 50;
        //string DataField = ServiceID + " " + "£" + ServicePrice;

        [TestMethod]
        public void InstanceOK()
        {
            //Creates a new instance of the Service class.
            ClsService anService = new ClsService();
            //Test to see if a new instance was made.
            Assert.IsNotNull(anService);
        }

        [TestMethod]
        public void ServiceIDPropertyOK()
        {
            //Creates a new instance of the Service class.
            ClsService anService = new ClsService();
            //assigns the test data to the property.
            anService.ServiceID = ServiceID;
            //test to see if the 2 values are equal.
            Assert.AreEqual(anService.ServiceID, ServiceID);
        }
        [TestMethod]
        public void ServiceNamePropertyOK()
        {
            //Creates a new instance of the Service class.
            ClsService anService = new ClsService();
            //assigns the test data to the property.
            anService.ServiceName = ServiceName;
            //test to see if the 2 values are equal.
            Assert.AreEqual(anService.ServiceName, ServiceName);
        }

        [TestMethod]
        public void ServiceDescriptionPropertyOK()
        {
            //Creates a new instance of the Service class.
            ClsService anService = new ClsService();
            //assigns the test data to the property.
            anService.ServiceDescription = ServiceDesc;
            //test to see if the 2 values are equal.
            Assert.AreEqual(anService.ServiceDescription, ServiceDesc);
        }

        [TestMethod]
        public void ServicePricePropertyOK()
        {
            //Creates a new instance of the Service class.
            ClsService anService = new ClsService();
            //assigns the test data to the property.
            anService.ServicePrice = ServicePrice;
            //test to see if the 2 values are equal.
            Assert.AreEqual(anService.ServicePrice, ServicePrice);
        }

        [TestMethod]
        public void DataFieldPropertyOK()
        {
            //Creates a new instance of the Service class.
            ClsService anService = new ClsService();
            //assigns the test data to the property.
            string TestData = ServiceName + " " + "£" + ServicePrice;
            anService.ServiceName = ServiceName;
            anService.ServicePrice = ServicePrice;
            //test to see if the 2 values are equal.
            Assert.AreEqual(anService.DataField, TestData);
        }
    }
}
