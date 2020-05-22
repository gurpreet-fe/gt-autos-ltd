using Microsoft.VisualStudio.TestTools.UnitTesting;
using GTAutosClasses;
using System.Collections.Generic;
using System;

namespace GTAutosTesting
{
    [TestClass]
    public class TstPositionCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            Assert.IsNotNull(allPosition);
        }

        [TestMethod]
        public void PositionListOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            List<ClsPosition> testList = new List<ClsPosition>();
            ClsPosition testItem = new ClsPosition();

            testItem.PositionID = 1;
            testItem.PositionName = "Software Engineer";
            testItem.Description = "Develop and deploy software.";
            testItem.Salary = 35000.00M;

            testList.Add(testItem);
            allPosition.PositionList = testList;

            Assert.AreEqual(allPosition.PositionList, testList);
        }

        [TestMethod]
        public void ThisPositionPropertyOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            ClsPosition testPosition = new ClsPosition();

            testPosition.PositionID = 1;
            testPosition.PositionName = "Software Engineer";
            testPosition.Description = "Develop and deploy software.";
            testPosition.Salary = 35000.00M;

            allPosition.ThisPosition = testPosition;
            Assert.AreEqual(allPosition.ThisPosition, testPosition);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            List<ClsPosition> testList = new List<ClsPosition>();
            ClsPosition testItem = new ClsPosition();

            testItem.PositionID = 1;
            testItem.PositionName = "Software Engineer";
            testItem.Description = "Develop and deploy software.";
            testItem.Salary = 35000.00M;

            testList.Add(testItem);
            allPosition.PositionList = testList;
            Assert.AreEqual(allPosition.Count, testList.Count);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    ClsPositionCollection allPosition = new ClsPositionCollection();
        //    Int32 someCount = 10;
        //    allPosition.Count = someCount;

        //    Assert.AreEqual(allPosition.Count, someCount);
        //}

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    ClsPositionCollection allPosition = new ClsPositionCollection();
        //    Assert.AreEqual(allPosition.Count, 10);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            ClsPosition testItem = new ClsPosition();

            int primaryKey = 0;

            testItem.PositionID = 12;
            testItem.PositionName = "Web Designer";
            testItem.Description = "Create the look, layout, and features of a website.";
            testItem.Salary = 40000.00M;

            allPosition.ThisPosition = testItem;

            primaryKey = allPosition.Add();

            testItem.PositionID = primaryKey;

            Assert.AreEqual(allPosition.ThisPosition, testItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            ClsPosition testItem = new ClsPosition();

            int primaryKey = 0;

            testItem.PositionID = 1;
            testItem.PositionName = "Software Engineer";
            testItem.Description = "Develop and deploy software.";
            testItem.Salary = 35000.00M;

            allPosition.ThisPosition = testItem;
            primaryKey = allPosition.Add();
            testItem.PositionID = primaryKey;
            allPosition.ThisPosition.Find(primaryKey);

            allPosition.Delete();
            bool found = allPosition.ThisPosition.Find(primaryKey);

            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            ClsPosition testItem = new ClsPosition();

            int primaryKey = 0;

            testItem.PositionName = "Software Engineer";
            testItem.Description = "Develop and deploy software.";
            testItem.Salary = 35000.00M;

            allPosition.ThisPosition = testItem;
            primaryKey = allPosition.Add();

            testItem.PositionName = "Penetration Tester";
            testItem.Description = "";
            testItem.Salary = 50000.00M;

            allPosition.ThisPosition = testItem;
            allPosition.Update();
            allPosition.ThisPosition.Find(primaryKey);

            Assert.AreEqual(allPosition.ThisPosition, testItem);
        }

        [TestMethod]
        public void ReportByDescriptionMethodOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            ClsPositionCollection filteredPosition = new ClsPositionCollection();

            filteredPosition.ReportByDescription("");

            Assert.AreEqual(allPosition.Count, filteredPosition.Count);
        }

        [TestMethod]
        public void ReportByDescriptionNotFound()
        {
            ClsPositionCollection filteredPosition = new ClsPositionCollection();
            filteredPosition.ReportByDescription("xxxxx");

            Assert.AreEqual(2, filteredPosition.Count);
        }

        [TestMethod]
        public void ReportByDescriptionTestDataFound()
        {
            ClsPositionCollection filteredPosition = new ClsPositionCollection();
            bool ok = true;

            filteredPosition.ReportByDescription("xxxxx");

            if (filteredPosition.Count == 2)
            {
                if (filteredPosition.PositionList[0].PositionID != 9)
                {
                    ok = false;
                }


                if (filteredPosition.PositionList[1].PositionID != 9)
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
