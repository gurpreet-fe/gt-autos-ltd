using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GTAutosClasses;

namespace GTAutosTesting
{
    [TestClass]
    public class TstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            List<ClsStaff> testList = new List<ClsStaff>();
            ClsStaff testItem = new ClsStaff();

            testItem.StaffID = 1;
            testItem.StaffName = "Bill Gates";
            testItem.OfficeCode = 1;
            testItem.PositionID = 1;
            testItem.ContactNumber = "12345678910";
            testItem.Address = "10 Park Road";
            testItem.HireDate = DateTime.Now.Date;
            testItem.IsEmployed = true;

            testList.Add(testItem);
            allStaff.StaffList = testList;
            Assert.AreEqual(allStaff.StaffList, testList);

        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            ClsStaff testStaff = new ClsStaff();

            testStaff.StaffID = 1;
            testStaff.StaffName = "Bill Gates";
            testStaff.OfficeCode = 1;
            testStaff.PositionID = 1;
            testStaff.ContactNumber = "12345678910";
            testStaff.Address = "10 Park Road, Leicester, LE1 2PR";
            testStaff.HireDate = DateTime.Now.Date;
            testStaff.IsEmployed = true;

            allStaff.ThisStaff = testStaff;
            Assert.AreEqual(allStaff.ThisStaff, testStaff);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            List<ClsStaff> testList = new List<ClsStaff>();
            ClsStaff testItem = new ClsStaff();

            testItem.StaffID = 1;
            testItem.StaffName = "Bill Gates";
            testItem.OfficeCode = 1;
            testItem.PositionID = 1;
            testItem.ContactNumber = "12345678910";
            testItem.Address = "10 Park Road, Leicester, LE1 2PR";
            testItem.HireDate = DateTime.Now.Date;
            testItem.IsEmployed = true;

            testList.Add(testItem);
            allStaff.StaffList = testList;
            Assert.AreEqual(allStaff.Count, testList.Count);

        }

        [TestMethod]
        public void CountPropertyOK()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            int someCount = 0;
            allStaff.Count = someCount;
            Assert.AreEqual(allStaff.Count, someCount);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            Assert.AreEqual(allStaff.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            ClsStaff testItem = new ClsStaff();

            int primaryKey = 0;

            testItem.StaffID = 1;
            testItem.StaffName = "Bill Gates";
            testItem.OfficeCode = 1;
            testItem.PositionID = 1;
            testItem.ContactNumber = "12345678910";
            testItem.Address = "10 Park Road, Leicester, LE1 2PR";
            testItem.HireDate = DateTime.Now.Date;
            testItem.IsEmployed = true;

            allStaff.ThisStaff = testItem;
            primaryKey = allStaff.Add();
            testItem.StaffID = primaryKey;
            allStaff.ThisStaff.Find(primaryKey);

            Assert.AreEqual(allStaff.ThisStaff, testItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            ClsStaff testItem = new ClsStaff();

            int primaryKey = 0;

            testItem.StaffID = 1;
            testItem.StaffName = "Bill Gates";
            testItem.OfficeCode = 1;
            testItem.PositionID = 1;
            testItem.ContactNumber = "12345678910";
            testItem.Address = "10 Park Road, Leicester, LE1 2PR";
            testItem.HireDate = DateTime.Now.Date;
            testItem.IsEmployed = true;

            allStaff.ThisStaff = testItem;
            primaryKey = allStaff.Add();
            testItem.StaffID = primaryKey;
            allStaff.ThisStaff.Find(primaryKey);

            allStaff.Delete();
            bool found = allStaff.ThisStaff.Find(primaryKey);

            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            ClsStaff testItem = new ClsStaff();

            int primaryKey = 0;

            testItem.StaffName = "Bill Gates";
            testItem.OfficeCode = 1;
            testItem.PositionID = 1;
            testItem.ContactNumber = "12345678910";
            testItem.Address = "10 Park Road, Leicester, LE1 2PR";
            testItem.HireDate = DateTime.Now.Date;
            testItem.IsEmployed = true;

            allStaff.ThisStaff = testItem;
            primaryKey = allStaff.Add();

            testItem.StaffName = "Steve Ballmer";
            testItem.OfficeCode = 2;
            testItem.PositionID = 3;
            testItem.ContactNumber = "9876543210";
            testItem.Address = "11 Ground Road, Liverpool, LP1 2RP";
            testItem.HireDate = DateTime.Now.Date;
            testItem.IsEmployed = true;

            allStaff.ThisStaff = testItem;
            allStaff.Update();
            allStaff.ThisStaff.Find(primaryKey);

            Assert.AreEqual(allStaff.ThisStaff, testItem);
        }

        [TestMethod]
        public void ReportByContactNumberMethodOK()
        {
            ClsStaffCollection allStaff = new ClsStaffCollection();
            ClsStaffCollection filteredStaff = new ClsStaffCollection();

            filteredStaff.ReportByContactNumber("");

            Assert.AreEqual(allStaff.Count, filteredStaff.Count);
        }

        [TestMethod]
        public void ReportByContactNumberNotFound()
        {
            ClsStaffCollection filteredStaff = new ClsStaffCollection();
            filteredStaff.ReportByContactNumber("xas asdasdfq");

            Assert.AreEqual(0, filteredStaff.Count);
        }

        [TestMethod]
        public void ReportByContactNumberTestDataFound()
        {
            ClsStaffCollection filteredStaff = new ClsStaffCollection();
            bool ok = true;

            filteredStaff.ReportByContactNumber("xxx asdasdfs");

            if (filteredStaff.Count == 2)
            {
                if (filteredStaff.StaffList[0].StaffID != 11)
                {
                    ok = false;
                }
                if (filteredStaff.StaffList[1].StaffID != 13)
                {
                    ok = false;
                }
            } else
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }
    }
}
