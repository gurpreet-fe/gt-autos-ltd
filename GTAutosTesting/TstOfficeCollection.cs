using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GTAutosTesting
{
    [TestClass]
    public class tstOfficeCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOfficeCollection AllOffices = new clsOfficeCollection();
            Assert.IsNotNull(AllOffices);
        }

        [TestMethod]
        public void OfficeListOK()
        {
            clsOfficeCollection AllOffices = new clsOfficeCollection();
            //create some test data in this case its a list
            List<OfficeClasses> TestList = new List<OfficeClasses>();
            //add items to the list
            OfficeClasses TestItem = new OfficeClasses();
            //set its properties
            TestItem.IsActive = true;
            TestItem.OfficeCode = 1;
            TestItem.InspectionDate = DateTime.Now.Date;
            TestItem.AddressLine1 = "Flat 108, Ben Russell Court";
            TestItem.AddressLine2 = "25 Grasmere Street";
            TestItem.City = "Leicester";
            TestItem.PhoneNumber = "07464074954";
            TestItem.PhoneNumber = "LE2 7PT";
            TestList.Add(TestItem);
            AllOffices.OfficeList = TestList;
            Assert.AreEqual(AllOffices.OfficeList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsOfficeCollection AllOffices = new clsOfficeCollection();
        //    Int32 SomeCount = 2;
        //    AllOffices.Count = SomeCount;
        //    Assert.AreEqual(AllOffices.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisOfficePropertyOK()
        {
            clsOfficeCollection AllOffices = new clsOfficeCollection();
            OfficeClasses TestOffice = new OfficeClasses();
            //set its properties
            TestOffice.IsActive = true;
            TestOffice.OfficeCode = 1;
            TestOffice.InspectionDate = DateTime.Now.Date;
            TestOffice.AddressLine1 = "Flat 108, Ben Russell Court";
            TestOffice.AddressLine2 = "25 Grasmere Street";
            TestOffice.City = "Leicester";
            TestOffice.PhoneNumber = "07464074954";
            TestOffice.PhoneNumber = "LE2 7PT";
            AllOffices.ThisOffice = TestOffice;
            Assert.AreEqual(AllOffices.ThisOffice, TestOffice);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOfficeCollection AllOffices = new clsOfficeCollection();
            List<OfficeClasses> TestList = new List<OfficeClasses>();
            OfficeClasses TestItem = new OfficeClasses();
            //set its properties
            TestItem.IsActive = true;
            TestItem.OfficeCode = 1;
            TestItem.InspectionDate = DateTime.Now.Date;
            TestItem.AddressLine1 = "Flat 108, Ben Russell Court";
            TestItem.AddressLine2 = "25 Grasmere Street";
            TestItem.City = "Leicester";
            TestItem.PhoneNumber = "07464074954";
            TestItem.PhoneNumber = "LE2 7PT";
            TestList.Add(TestItem);
            AllOffices.OfficeList = TestList;
            Assert.AreEqual(AllOffices.Count, TestList.Count);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    clsOfficeCollection AllOffices = new clsOfficeCollection();
        //    Assert.AreEqual(AllOffices.Count, 2);
        //}
        


    }
}
