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
            TestItem.PostCode = "LE2 7PT";
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
            TestOffice.PostCode = "LE2 7PT";
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
            TestItem.PostCode = "LE2 7PT";
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
        
        [TestMethod]
        public void AddMethodOK()
        {
            clsOfficeCollection AllOffices = new clsOfficeCollection();
            OfficeClasses TestItem = new OfficeClasses();
            Int32 PrimaryKey = 0;
            TestItem.IsActive = true;
            TestItem.OfficeCode = 1;
            TestItem.InspectionDate = DateTime.Now.Date;
            TestItem.AddressLine1 = "123a";
            TestItem.AddressLine2 = "Some Street";
            TestItem.City = "Some City";
            TestItem.PhoneNumber = "07464074954";
            TestItem.PostCode = "LE1 1WE";
            AllOffices.ThisOffice = TestItem;
            PrimaryKey = AllOffices.Add();
            TestItem.OfficeCode = PrimaryKey;
            AllOffices.ThisOffice.Find(PrimaryKey);
            Assert.AreEqual(AllOffices.ThisOffice, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOfficeCollection AllOffices = new clsOfficeCollection();
            OfficeClasses TestItem = new OfficeClasses();
            Int32 PrimaryKey = 0;
            TestItem.IsActive = true;
            TestItem.OfficeCode = 3;
            TestItem.InspectionDate = DateTime.Now.Date;
            TestItem.AddressLine1 = "123a";
            TestItem.AddressLine2 = "Some Street";
            TestItem.City = "Some City";
            TestItem.PhoneNumber = "07464074954";
            TestItem.PostCode = "LE1 1WE";
            AllOffices.ThisOffice = TestItem;
            PrimaryKey = AllOffices.Add();
            TestItem.OfficeCode = PrimaryKey;
            AllOffices.ThisOffice.Find(PrimaryKey);
            AllOffices.Delete();
            Boolean Found = AllOffices.ThisOffice.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOfficeCollection AllOffices = new clsOfficeCollection();
            OfficeClasses TestItem = new OfficeClasses();
            Int32 PrimaryKey = 0;
            TestItem.IsActive = true;
            TestItem.InspectionDate = DateTime.Now.Date;
            TestItem.AddressLine1 = "123a";
            TestItem.AddressLine2 = "Some Street";
            TestItem.City = "Some City";
            TestItem.PhoneNumber = "07464074954";
            TestItem.PostCode = "LE1 1WE";
            AllOffices.ThisOffice = TestItem;
            PrimaryKey = AllOffices.Add();
            TestItem.OfficeCode = PrimaryKey;
            TestItem.IsActive = false;
            TestItem.InspectionDate = DateTime.Now.Date;
            TestItem.AddressLine1 = "123b";
            TestItem.AddressLine2 = "Another Street";
            TestItem.City = "Another City";
            TestItem.PhoneNumber = "07464074954";
            TestItem.PostCode = "LE2 2WE";
            AllOffices.ThisOffice = TestItem;
            AllOffices.Update();
            AllOffices.ThisOffice.Find(PrimaryKey);
            Assert.AreEqual(AllOffices.ThisOffice, TestItem);
        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            clsOfficeCollection AllOffices = new clsOfficeCollection();
            clsOfficeCollection FilteredOffices = new clsOfficeCollection();
            FilteredOffices.ReportByPostCode("");
            Assert.AreEqual(AllOffices.Count, FilteredOffices.Count);
        }

        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            clsOfficeCollection FilteredOffices = new clsOfficeCollection();
            FilteredOffices.ReportByPostCode("xxy xxx");
            Assert.AreEqual(0, FilteredOffices.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            clsOfficeCollection FilteredOffices = new clsOfficeCollection();
            Boolean OK = true;
            FilteredOffices.ReportByPostCode("xxx xxx");
            if (FilteredOffices.Count == 2)
            {
                if (FilteredOffices.OfficeList[0].OfficeCode != 11)
                {
                    OK = false;
                }
                if (FilteredOffices.OfficeList[1].OfficeCode != 13)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }





    }
}
