using System;
using System.Collections.Generic;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            Assert.IsNotNull(AllOrders);

        }

        [TestMethod]
        public void OrderListOK()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            List<ClsOrder> TestList = new List<ClsOrder>();
            ClsOrder TestItem = new ClsOrder();
            TestItem.CustomerID = 2;
            TestItem.CarID = 2;
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.ServiceID = 1;
            TestItem.OrderPrice = 5000;
            TestItem.OrderStatus = "test";
            TestItem.PaymentID = 1;
            TestItem.Completed = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        /*[TestMethod]
        public void CountPropertyOK()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            Int32 SomeCount = 0;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }*/

       [TestMethod]
        public void ThisOrderPropertyOK()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            ClsOrder TestItem = new ClsOrder();
            TestItem.CustomerID = 2;
            TestItem.CarID = 2;
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.ServiceID = 1;
            TestItem.OrderPrice = 5000;
            TestItem.OrderStatus = "Done";
            TestItem.PaymentID = 1;
            TestItem.Completed = true;
            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            List<ClsOrder> TestList = new List<ClsOrder>();
            ClsOrder TestItem = new ClsOrder();
            TestItem.CustomerID = 2;
            TestItem.CarID = 2;
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.ServiceID = 66;
            TestItem.OrderPrice = 5000;
            TestItem.OrderStatus = "test";
            TestItem.PaymentID = 1;
            TestItem.Completed = true;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);
        }*/
        [TestMethod]
        public void AddMethodOK()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            ClsOrder AnOrder = new ClsOrder();
            int PrimaryKey = 0;
            AnOrder.CustomerID = 2;
            AnOrder.CarID = 2;
            AnOrder.DateOfOrder = DateTime.Now.Date;
            AnOrder.ServiceID = 66;
            AnOrder.OrderPrice = 5000;
            AnOrder.OrderStatus = "test";
            AnOrder.PaymentID = 3;
            AnOrder.Completed = true;
            AllOrders.ThisOrder = AnOrder;
            PrimaryKey = AllOrders.Add();
            AnOrder.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, AnOrder);
            AllOrders.Delete(); // This to delete the new record we have just made for consistancey with the rest of the test.
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            ClsOrder AnOrder = new ClsOrder();
            int PrimaryKey = 0;
            AnOrder.CustomerID = 2;
            AnOrder.CarID = 2;
            AnOrder.DateOfOrder = DateTime.Now.Date;
            AnOrder.ServiceID = 66;
            AnOrder.OrderPrice = 50000;
            AnOrder.OrderStatus = "Done";
            AnOrder.PaymentID = 3;
            AnOrder.Completed = true;
            AllOrders.ThisOrder = AnOrder;
            PrimaryKey = AllOrders.Add();
            AnOrder.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            bool Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            ClsOrder AnOrder = new ClsOrder();
            int PrimaryKey = 0;
            AnOrder.CustomerID = 2;
            AnOrder.CarID = 2;
            AnOrder.DateOfOrder = DateTime.Now.Date;
            AnOrder.ServiceID = 66;
            AnOrder.OrderPrice = 50000;
            AnOrder.OrderStatus = "pending";
            AnOrder.PaymentID = 3;
            AnOrder.Completed = false;

            AllOrders.ThisOrder = AnOrder;
            PrimaryKey = AllOrders.Add();
            AnOrder.OrderID = PrimaryKey;

            AnOrder.CustomerID = 2;
            AnOrder.CarID = 2;
            AnOrder.DateOfOrder = DateTime.Now.Date;
            AnOrder.ServiceID = 66;
            AnOrder.OrderPrice = 50000;
            AnOrder.OrderStatus = "completed";
            AnOrder.PaymentID = 3;
            AnOrder.Completed = true;

            AllOrders.ThisOrder = AnOrder;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, AnOrder);
            AllOrders.Delete();
        }

        [TestMethod]
        public void ReportByOrderStatusMethodOK()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            //ClsOrder AnOrder = new ClsOrder();
            ClsOrderCollection FilteredOrders = new ClsOrderCollection();
            FilteredOrders.ReportByOrderStatus("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);  
        }

        [TestMethod]
        public void ReportByOrderStatusNoneFound()
        {
            ClsOrderCollection FilteredOrders = new ClsOrderCollection();
            FilteredOrders.ReportByOrderStatus("XXX");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderStatusTestDataFound()
        {
            ClsOrderCollection FilteredOrders = new ClsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByOrderStatus("completed");
            if (FilteredOrders.Count == 8)
            {
                if (FilteredOrders.OrderList[0].OrderID != 51)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderID != 52)
                {
                    OK = false;
                }
            }
            else 
            {
                OK = false;
            }
            Console.Write(FilteredOrders.Count);
            Assert.IsTrue(OK);
        }
    }
}
