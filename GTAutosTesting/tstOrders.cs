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
            int TestData = 1;
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
            int TestData = 1;
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
            String TestData = "MT04TTX";
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
            String TestData = "MOT";
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
            String TestData = "Pending";
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
        [TestMethod]
        public void PaymentIDPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            int TestData = 1;
            //assigns the data to the property.
            anOrder.PaymentID = TestData;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.PaymentID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //creates some test data that is assigned to a variable.
            int OrderID = 10;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creates some test data that is assigned to a variable.
            int OrderID = 10;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.OrderID != 10) {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creates some test data that is assigned to a variable.
            int OrderID = 10;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.CustomerID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarIDFound()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creates some test data that is assigned to a variable.
            int OrderID = 10;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.CarID != "MP04TTX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentIDFound()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creates some test data that is assigned to a variable.
            int OrderID = 10;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.PaymentID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfOrderFound()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creates some test data that is assigned to a variable.
            int OrderID = 10;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.DateOfOrder != Convert.ToDateTime("17/02/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestServiceIDFound()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creates some test data that is assigned to a variable.
            int OrderID = 10;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.ServiceID != "MOT")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderPriceFound()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creates some test data that is assigned to a variable.
            int OrderID = 10;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.OrderPrice != 50)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creates some test data that is assigned to a variable.
            int OrderID = 10;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.OrderStatus != "done")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompletedFound()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //creates some test data that is assigned to a variable.
            int OrderID = 7;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.Completed != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
