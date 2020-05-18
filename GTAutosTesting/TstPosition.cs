using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstPosition
    {
        string positionName = "";
        string positionDescription = "";
        string salary = "";

        [TestMethod]
        public void InstanceOK()
        {
            ClsPosition position = new ClsPosition();

            Assert.IsNotNull(position);
        }

        [TestMethod]
        public void PositionIdPropertyOK()
        {
            ClsPosition position = new ClsPosition();
            int TestData = 112;
            position.PositionId = TestData;
            Assert.AreEqual(position.PositionId, TestData);
        }

        [TestMethod]
        public void PositionNamePropertyOK()
        {
            ClsPosition position = new ClsPosition();
            string TestData = "Software Engineer";
            position.PositionName = TestData;
            Assert.AreEqual(position.PositionName, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            ClsPosition position = new ClsPosition();
            string TestData = "Develops software solutions";
            position.Description = TestData;
            Assert.AreEqual(position.Description, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            ClsPosition position = new ClsPosition();
            double TestData = 50000.00;
            position.Salary = TestData;
            Assert.AreEqual(position.Salary, TestData);
        }



        [TestMethod]
        public void TestPositionIdFound()
        {
            ClsPosition position = new ClsPosition();

            bool Found = false;
            bool OK = true;
            int PositionId = 1;

            Found = position.Find(PositionId);

            if (position.PositionId != 13)
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
            int PositionId = 13;
            Found = position.Find(PositionId);
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
            int PositionId = 13;
            Found = position.Find(PositionId);
            if (position.Description != "Develops software solutions")
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
            int PositionId = 13;
            Found = position.Find(PositionId);
            if (position.Salary!= 50000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        // ---------------------------------- Valid Method ---------------------------------- //

        public void ValidMethodOK()
        {
            ClsPosition position = new ClsPosition();
            string error = "";
            error = position.Valid(positionName, positionDescription, salary);
            Assert.AreEqual(error, "");
        }

        // ---------------------------------- Position Name ---------------------------------- //
        [TestMethod]
        public void PositionNameMinLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionName = "";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void PositionNameMin()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionName = "A";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }
        public void PositionNameMinPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionName = "AA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void PositionNameMid()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionName = "AAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void PositionNameMaxLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionName = "AAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void PositionNameMax()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionName = "AAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void PositionNameMaxPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionName = "AAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void PositionNameMaxExtreme()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionName = "AAAAAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }



        // ---------------------------------- Position Description ---------------------------------- //

        [TestMethod]
        public void DescriptionMinLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionDescription = "";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void DescriptionMin()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionDescription = "A";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }
        public void DescriptionMinPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionDescription = "AA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void DescriptionMid()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionDescription = "AAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void DescriptionMaxLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionDescription = "AAAAAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void DescriptionMax()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionDescription = "AAAAAAAAAAAAAAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void DescriptionMaxPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionDescription = "AAAAAAAAAAAAAAAAAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void DescriptionMaxExtreme()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string positionDescription = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }


        // ---------------------------------- Salary ---------------------------------- //

        [TestMethod]
        public void SalaryMinLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void SalaryMin()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "A";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }
        public void SalaryMinPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "AA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void SalaryMid()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "AAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void SalaryMaxLess1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "AAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void SalaryMax()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "AAAAAAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void SalaryMaxPlus1()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "AAAAAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

        public void SalaryMaxExtreme()
        {
            ClsPosition position = new ClsPosition();

            string error = "";
            string salary = "AAAAAAAAAAAA";

            error = position.Valid(positionName, positionDescription, salary);

            Assert.AreNotEqual(error, "");

        }

    }
}
