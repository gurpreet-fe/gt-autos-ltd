using System;
using System.Collections.Generic;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstServiceCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            ClsServiceCollection AllServices = new ClsServiceCollection();
            Assert.IsNotNull(AllServices);

        }

        [TestMethod]
        public void ServiceListOK()
        {
            ClsServiceCollection AllServices = new ClsServiceCollection();
            List<ClsService> TestList = new List<ClsService>();
            ClsService TestItem = new ClsService();
            TestItem.ServiceID = 1;
            TestItem.ServiceName = "MOT";
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
        public void ThisServicePropertyOK()
        {
            ClsServiceCollection AllServices = new ClsServiceCollection();
            ClsService TestItem = new ClsService();
            TestItem.ServiceID = 1;
            TestItem.ServiceName = "MOT";
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
            TestItem.ServiceID = 1;
            TestItem.ServiceName = "MOT";
            TestItem.ServiceDescription = "Fix car";
            TestItem.ServicePrice = 50;
            TestList.Add(TestItem);
            AllServices.ServiceList = TestList;
            Assert.AreEqual(AllServices.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            ClsServiceCollection AllServices = new ClsServiceCollection();
            ClsService AnService = new ClsService();
            int PrimaryKey = 0;
            AnService.ServiceName = "Vale";
            AnService.ServiceDescription = "sadf";
            AnService.ServicePrice = 40;
            AllServices.ThisService = AnService;
            PrimaryKey = AllServices.Add();
            AnService.ServiceID = PrimaryKey;
            AllServices.ThisService.Find(PrimaryKey);
            Assert.AreEqual(AllServices.ThisService, AnService);
            AllServices.Delete();
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            ClsServiceCollection AllServices = new ClsServiceCollection();
            ClsService AnService = new ClsService();
            int PrimaryKey = 0;
            AnService.ServiceName = "Vale";
            AnService.ServiceDescription = "sadf";
            AnService.ServicePrice = 40;
            AllServices.ThisService = AnService;
            PrimaryKey = AllServices.Add();
            AnService.ServiceID = PrimaryKey;
            AllServices.ThisService.Find(PrimaryKey);
            AllServices.Delete();
            bool Found = AllServices.ThisService.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
    }
}
