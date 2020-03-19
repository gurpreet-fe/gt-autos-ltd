using System;
using System.Collections.Generic;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstOrderCollection
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
            TestItem.NumberPlate = "MT04TTX";
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.ServiceID = 1;
            TestItem.OrderPrice = 5000;
            TestItem.OrderStatus = "Done";
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
            TestItem.NumberPlate = "MT04TTX";
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
            TestItem.NumberPlate = "MT04TTX";
            TestItem.DateOfOrder = DateTime.Now.Date;
            TestItem.ServiceID = 1;
            TestItem.OrderPrice = 5000;
            TestItem.OrderStatus = "Done";
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
            AnOrder.NumberPlate = "MP04TTX";
            AnOrder.DateOfOrder = DateTime.Now.Date;
            AnOrder.ServiceID = 1;
            AnOrder.OrderPrice = 5000;
            AnOrder.OrderStatus = "Done";
            AnOrder.PaymentID = 3;
            AnOrder.Completed = true;
            AllOrders.ThisOrder = AnOrder;
            PrimaryKey = AllOrders.Add();
            //AnOrder.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, AnOrder);
        }
    }
}
