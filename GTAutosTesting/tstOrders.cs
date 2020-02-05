using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Creates a new instance of the Order class.
            ClsOrder anOrder = new ClsOrder();
            //Test to see if a new instance was made.
            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            int TestData = 0;
            //assigns the data to the property.
            anOrder.OrderID = TestData;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            int TestData = 0;
            //assigns the data to the property.
            anOrder.CustomerID = TestData;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void CarIDPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            int TestData = 0;
            //assigns the data to the property.
            anOrder.CarID = TestData;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.CarID, TestData);
        }

        [TestMethod]
        public void DateOfOrderPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            DateTime TestData = DateTime.Now.Date;
            //assigns the data to the property.
            anOrder.DateOfOrder = TestData;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.DateOfOrder, TestData);
        }

        [TestMethod]
        public void ServiceIDPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            string TestData = "MOT";
            //assigns the data to the property.
            anOrder.ServiceID = TestData;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.ServiceID, TestData);
        }

        [TestMethod]
        public void OrderPricePropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            double TestData = 1.1;
            //assigns the data to the property.
            anOrder.OrderPrice = TestData;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.OrderPrice, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            string TestData = "Pending";
            //assigns the data to the property.
            anOrder.OrderStatus = TestData;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void CompletedPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            Boolean TestData =  true;
            //assigns the data to the property.
            anOrder.Completed = TestData;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.Completed, TestData);
        }
    }
}
