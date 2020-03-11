using System;
using System.Collections.Generic;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstServiceCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            ClsServiceCollection AllServices = new ClsServiceCollection();
            Assert.IsNotNull(AllServices);

        }

        [TestMethod]
        public void OrderListOK()
        {
            ClsServiceCollection AllServices = new ClsServiceCollection();
            List<ClsService> TestList = new List<ClsService>();
            ClsService TestItem = new ClsService();
            TestItem.ServiceID = "MOT";
            TestItem.ServiceDescription = "Fix car";
            TestItem.ServicePrice = 50;
            TestList.Add(TestItem);
            AllServices.ServiceList = TestList;
            Assert.AreEqual(AllServices.ServiceList, TestList);
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
            ClsServiceCollection AllServices = new ClsServiceCollection();
            ClsService TestItem = new ClsService();
            TestItem.ServiceID = "MOT";
            TestItem.ServiceDescription = "Fix car";
            TestItem.ServicePrice = 50;
            AllServices.ThisService = TestItem;
            Assert.AreEqual(AllServices.ThisService, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsServiceCollection AllServices = new ClsServiceCollection();
            List<ClsService> TestList = new List<ClsService>();
            ClsService TestItem = new ClsService();
            TestItem.ServiceID = "MOT";
            TestItem.ServiceDescription = "Fix car";
            TestItem.ServicePrice = 50;
            TestList.Add(TestItem);
            AllServices.ServiceList = TestList;
            Assert.AreEqual(AllServices.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            ClsOrderCollection AllOrders = new ClsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);
        }*/
    }
}
