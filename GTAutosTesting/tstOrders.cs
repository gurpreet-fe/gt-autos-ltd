using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GTAutosTesting
{
    [TestClass]
    public class TstOrders
    {
        int OrderID = 7;
        int CustomerID = 2;
        int CarID = 2;
        string DateOfOrder = DateTime.Now.Date.ToString("dd-MM-yy");
        int ServiceID = 2;
        string OrderPrice = "50000";
        string OrderStatus = "completed";
        int PaymentID = 3;

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
            int TestData = 10;
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
            //int TestData = 1;
            ////assigns the data to the property.
            anOrder.CustomerID = CustomerID;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.CustomerID, CustomerID);
        }

        [TestMethod]
        public void CarIDPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //creates some test data that is assigned to a variable.
            //String TestData = "MT04TTX";
            //assigns the data to the property.
            anOrder.CarID = CarID;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.CarID, CarID);
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
            int TestData = 1;
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
        public void AllPropertiesPropertyOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //assigns the data to the property.
            string TestData = "OrderID: " + OrderID + ", CustomerID: " + CustomerID + ", CarID: " + CarID + ", PaymentID: " + PaymentID + ", Date Of Order: " + DateOfOrder + ", ServiceID: " + ServiceID + ", Order Price: " + OrderPrice + ", Order Status:" + OrderStatus + ", Completed: " + false;
            anOrder.OrderID = OrderID;
            anOrder.CustomerID = CustomerID;
            anOrder.CarID = CarID;
            anOrder.PaymentID = PaymentID;
            anOrder.DateOfOrder = DateTime.Now.Date;
            anOrder.ServiceID = ServiceID;
            anOrder.OrderPrice = Convert.ToDouble(OrderPrice);
            anOrder.OrderStatus = OrderStatus;
            anOrder.Completed = false;
            //test to see that the 2 values are the same.
            Assert.AreEqual(anOrder.allProperties, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Creates a new instance of the Order class
            ClsOrder anOrder = new ClsOrder();
            //boolean variable to store the result of the validation.
            Boolean Found = false;
            //creates some test data that is assigned to a variable.
            int OrderID = 7;
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
            int OrderID = 7;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.OrderID != 7) {
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
            int OrderID = 7;
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
            int OrderID = 7;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.CarID != 2)
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
            int OrderID = 7;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.PaymentID != 3)
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
            int OrderID = 7;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.DateOfOrder != Convert.ToDateTime("06/05/2020"))
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
            int OrderID = 7;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (Convert.ToInt32(anOrder.ServiceID) != ServiceID)
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
            int OrderID = 7;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.OrderPrice != 50000)
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
            int OrderID = 7;
            //assigns the data to the property.
            Found = anOrder.Find(OrderID);
            if (anOrder.OrderStatus != "completed")
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
            if (anOrder.Completed != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error;
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        // TESTING Valid properies 

        // Testing ServiceID Property || may not be needed as is a foriegn key.
        //[TestMethod]
        //public void ServiceIDMinLessOne()
        //{
        //    ClsOrder AnOrder = new ClsOrder();
        //    String Error = "";
        //    string ServiceID ="";// this will trigger an error 
        //    Error = AnOrder.Valid(DateOfOrder, ServiceID, OrderPrice, OrderStatus);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void ServiceIDMinBoundary()
        //{
        //    ClsOrder AnOrder = new ClsOrder();
        //    String Error = "";
        //    string ServiceID = "M";// this will Pass.
        //    Error = AnOrder.Valid(DateOfOrder, ServiceID, OrderPrice, OrderStatus);
        //    Assert.AreEqual(Error, "");
        //}
        //[TestMethod]
        //public void ServiceIDMinPlusOne()
        //{
        //    ClsOrder AnOrder = new ClsOrder();
        //    String Error = "";
        //    string ServiceID = "MO";// this will Pass.
        //    Error = AnOrder.Valid(DateOfOrder, ServiceID, OrderPrice, OrderStatus);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void ServiceIDMaxLessOne()
        //{
        //    ClsOrder AnOrder = new ClsOrder();
        //    String Error = "";
        //    string ServiceID = "1234567891234567891234567891234567891234567891234";// this will Pass.
        //    Error = AnOrder.Valid(DateOfOrder, ServiceID, OrderPrice, OrderStatus);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void ServiceIDMaxBoundary()
        //{
        //    ClsOrder AnOrder = new ClsOrder();
        //    String Error = "";
        //    string ServiceID = "12345678912345678912345678912345678912345678912345";// this will Pass.
        //    Error = AnOrder.Valid(DateOfOrder, ServiceID, OrderPrice, OrderStatus);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void ServiceIDMid()
        //{
        //    ClsOrder AnOrder = new ClsOrder();
        //    String Error = "";
        //    string ServiceID = "1234567891234567891234567";// this will Pass.
        //    Error = AnOrder.Valid(DateOfOrder, ServiceID, OrderPrice, OrderStatus);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void ServiceIDMaxPlusOne()
        //{
        //    ClsOrder AnOrder = new ClsOrder();
        //    String Error = "";
        //    string ServiceID = "123456789123456789123456789123456789123456789123456";// this will Fail.
        //    Error = AnOrder.Valid(DateOfOrder, ServiceID, OrderPrice, OrderStatus);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void ServiceIDExtremeMax()
        //{
        //    ClsOrder AnOrder = new ClsOrder();
        //    String Error = "";
        //    string ServiceID = "";
        //    ServiceID = ServiceID.PadRight(700, 'a'); // This should fail
        //    Error = AnOrder.Valid(DateOfOrder, ServiceID, OrderPrice, OrderStatus);
        //    Assert.AreEqual(Error, "");
        //}


        // Testing DateOfOrder property

        [TestMethod]
        public void DateOfOrderExtremeMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfOrder = TestDate.ToString(); // This should fail
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderMinLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateOfOrder = TestDate.ToString(); // This should fail
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderMinBoundary()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfOrder = TestDate.ToString(); // This should pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOfOrder = TestDate.ToString(); // This should pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOfOrder = TestDate.ToString(); // This should fail
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderInvalidData()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string DateOfOrder = "This is not a date";
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        // Testing OrderPrice property

        [TestMethod]
        public void OrderPriceExtremeMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderPrice = "-1000"; // This should fail
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMinLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderPrice = "0";  // This should fail
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMinBoundary()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderPrice = "1";  // This should pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderPrice = "2";  // This should pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderPrice = "700000";  // This should pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceInvalidData()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderPrice = "This is not a int";
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

        // Testing OrderStatus property

        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderStatus = ""; // This should fail
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.IsFalse(Error == "");
        }

        [TestMethod]
        public void OrderStatusMinBoundary()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderStatus = "1"; // This should Pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderStatus = "12"; // This should Pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderStatus = "1234567891234567891234567891234567891234567891234"; // This should Pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMaxBoundary()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderStatus = "12345678912345678912345678912345678912345678912345"; // This should Pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderStatus = "123456789123456789123456789123456789123456789123456"; // This should fail
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderStatusMid()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderStatus = "1234567891234567891234567"; // This should pass
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderStatus = ""; // This should pass
            OrderStatus = OrderStatus.PadRight(700, 'a');
            Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
            Assert.AreNotEqual(Error, "");
        }

       /* [TestMethod]
        public void AddMethodOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Int32 PrimaryKey = 0;
           // AnOrder.OrderID = 1;
            AnOrder.CustomerID = CustomerID;
            AnOrder.NumberPlate = CarID;
            AnOrder.DateOfOrder = DateTime.Now.Date;
            AnOrder.OrderPrice = Convert.ToDouble(OrderPrice);
            AnOrder.OrderStatus = OrderStatus;
            AnOrder.PaymentID = PaymentID;
            AnOrder.Completed = false;
            PrimaryKey = AnOrder.Add();
            AnOrder.Find(PrimaryKey);
            Assert.AreEqual(AnOrder.OrderID, AnOrder.OrderID);
        }*/
    }
}
