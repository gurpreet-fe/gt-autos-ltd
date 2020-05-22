using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstPosition
    {
        string positioName = "Software Engineer";
        string description = "Develops software solutions";
        string salary = "30000.00";

        [TestMethod]
        public void InstanceOK()
        {
            ClsPosition position = new ClsPosition();

            Assert.IsNotNull(position);
        }

        [TestMethod]
        public void PositionIDPropertyOK()
        {
            ClsPosition position = new ClsPosition();
            int testData = 112;
            position.PositionID = testData;
            Assert.AreEqual(position.PositionID, testData);
        }

        [TestMethod]
        public void PositionNamePropertyOK()
        {
            ClsPosition position = new ClsPosition();
            string testData = "Software Engineer";
            position.PositionName = testData;
            Assert.AreEqual(position.PositionName, testData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            ClsPosition position = new ClsPosition();
            string testData = "Develops software solutions";
            position.Description = testData;
            Assert.AreEqual(position.Description, testData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            ClsPosition position = new ClsPosition();
            decimal testData = 50000.00M;
            position.Salary = testData;
            Assert.AreEqual(position.Salary, testData);
        }

        //[TestMethod]
        public void TestPositionIDFound()
        {
            ClsPosition position = new ClsPosition();

            bool Found = false;
            bool OK = true;
            int PositionID = 1;

            Found = position.Find(PositionID);

            if (position.PositionID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPositionNameFound()
        {
            ClsPosition position = new ClsPosition();
            bool Found = false;
            bool OK = true;
            int PositionID = 1;
            Found = position.Find(PositionID);
            if (position.PositionName != "Software Engineer")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {

            ClsPosition position = new ClsPosition();
            bool Found = false;
            bool OK = true;
            int positionID = 1;
            Found = position.Find(positionID);
            if (position.Description != "Develop and deploy software.")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSalaryFound()
        {

            ClsPosition position = new ClsPosition();
            bool Found = false;
            bool OK = true;
            int PositionID = 1;
            Found = position.Find(PositionID);
            if (position.Salary != 35000.00M)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        // ---------------------------------- Valid Method ---------------------------------- //
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsPosition position = new ClsPosition();
            string error = "";
            error = position.Valid(positioName, description, salary);
            Assert.AreEqual(error, "");
        }

        // ---------------------------------- Position Name ---------------------------------- //
        [TestMethod]
        public void PositionNameMinLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string name = "";

            error = position.Valid(name, description, salary);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void PositionNameMin()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string name = "A";

            error = position.Valid(name, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void PositionNameMinPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string name = "AA";

            error = position.Valid(name, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void PositionNameMid()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string name = "";
            name = name.PadRight(15, 'A');

            error = position.Valid(name, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void PositionNameMaxLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string name = "";
            name = name.PadRight(29, 'A');

            error = position.Valid(name, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void PositionNameMax()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string name = "";
            name = name.PadRight(30, 'A');

            error = position.Valid(name, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void PositionNameMaxPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string name = "";
            name = name.PadRight(31, 'A');

            error = position.Valid(name, description, salary);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void PositionNameMaxExtreme()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string name = "";
            name = name.PadRight(500, 'A');

            error = position.Valid(name, description, salary);

            Assert.AreNotEqual(error, "");

        }



        // ---------------------------------- Description ---------------------------------- //

        [TestMethod]
        public void DescriptionMinLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string description = "";

            error = position.Valid(positioName, description, salary);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void DescriptionMin()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string description = "A";

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void DescriptionMinPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string description = "AA";

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void DescriptionMid()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string description = "";
            description = description.PadRight(50, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void DescriptionMaxLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string description = "";
            description = description.PadRight(99, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void DescriptionMax()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string description = "";
            description = description.PadRight(100, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void DescriptionMaxPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string description = "";
            description = description.PadRight(101, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void DescriptionMaxExtreme()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string description = "";
            description = description.PadRight(500, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreNotEqual(error, "");

        }


        // ---------------------------------- Salary ---------------------------------- //

        [TestMethod]
        public void SalaryMinLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "";

            error = position.Valid(positioName, description, salary);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void SalaryMin()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "A";

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void SalaryMinPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "AA";

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void SalaryMid()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "";
            salary = salary.PadRight(9, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryMaxLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "";
            salary = salary.PadRight(17, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void SalaryMax()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "";
            salary = salary.PadRight(18, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void SalaryMaxPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "";
            salary = salary.PadRight(19, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void SalaryMaxExtreme()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "";
            salary = salary.PadRight(500, 'A');

            error = position.Valid(positioName, description, salary);

            Assert.AreNotEqual(error, "");
        }

    }
}
