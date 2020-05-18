using Microsoft.VisualStudio.TestTools.UnitTesting;
using GTAutosClasses;
using System.Collections.Generic;
using System;

namespace GTAutosTesting
{
    class TstPositionCollection
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

            testItem.PositionId = 1;
            testItem.PositionName = "Software Engineer";
            testItem.Description = "Develop and deploy software";
            testItem.Salary = 35000.00;

            testList.Add(testItem);
            allPosition.PositionList = testList;
            Assert.AreEqual(allPosition.PositionList, testList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            ClsPosition testPosition = new ClsPosition();

            testPosition.PositionId = 1;
            testPosition.PositionName = "Software Engineer";
            testPosition.Description = "Develop and deploy software";
            testPosition.Salary = 35000.00;

            allPosition.ThisPosition = testPosition;
            Assert.AreEqual(allPosition.ThisPosition, testPosition);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            List<ClsPosition> testList = new List<ClsPosition>();
            ClsPosition testItem = new ClsPosition();

            testItem.PositionId = 1;
            testItem.PositionName = "Software Engineer";
            testItem.Description = "Develop and deploy software";
            testItem.Salary = 35000.00;

            testList.Add(testItem);
            allPosition.PositionList = testList;
            Assert.AreEqual(allPosition.Count, testList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            Assert.AreEqual(allPosition.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            ClsPosition testItem = new ClsPosition();

            int primaryKey = 0;

            testItem.PositionId = 1;
            testItem.PositionName = "Software Engineer";
            testItem.Description = "Develop and deploy software";
            testItem.Salary = 35000.00;

            allPosition.ThisPosition = testItem;
            primaryKey = allPosition.Add();
            testItem.PositionId = primaryKey;

            Assert.AreEqual(allPosition.ThisPosition, testItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            ClsPosition testItem = new ClsPosition();

            int primaryKey = 0;

            testItem.PositionId = 1;
            testItem.PositionName = "Software Engineer";
            testItem.Description = "Develop and deploy software";
            testItem.Salary = 35000.00;

            allPosition.ThisPosition = testItem;
            primaryKey = allPosition.Add();
            testItem.PositionId = primaryKey;
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
            testItem.Description = "Develop and deploy software";
            testItem.Salary = 35000.00;

            allPosition.ThisPosition = testItem;
            primaryKey = allPosition.Add();

            testItem.PositionName = "Pen Tester";
            testItem.Description = "Demonstrate and document flaw in security";
            testItem.Salary = 55000.00;

            allPosition.ThisPosition = testItem;
            allPosition.Update();
            allPosition.ThisPosition.Find(primaryKey);

            Assert.AreEqual(allPosition.ThisPosition, testItem);
        }

        [TestMethod]
        public void ReportByPositionNameMethodOK()
        {
            ClsPositionCollection allPosition = new ClsPositionCollection();
            ClsPositionCollection filteredPosition = new ClsPositionCollection();

            filteredPosition.ReportByPositionName("");

            Assert.AreEqual(allPosition.Count, filteredPosition.Count);
        }

        [TestMethod]
        public void ReportByPositionNameNotFound()
        {
            ClsPositionCollection filteredPosition = new ClsPositionCollection();
            filteredPosition.ReportByPositionName("xxxxxxx");

            Assert.AreEqual(0, filteredPosition.Count);
        }

        public void ReportByPositionNameTestDataFound()
        {
            ClsPositionCollection filteredPosition = new ClsPositionCollection();
            bool ok = true;

            filteredPosition.ReportByPositionName("xxxxxx");

            if (filteredPosition.Count == 2)
            {
                if (filteredPosition.PositionList[0].PositionId != 11)
                {
                    ok = false;
                }
                if (filteredPosition.PositionList[0].PositionId != 11)
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
