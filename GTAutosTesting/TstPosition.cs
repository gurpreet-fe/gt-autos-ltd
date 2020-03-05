using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstPosition
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            ClsPosition position = new ClsPosition();
            // Test to see that it exists
            Assert.IsNotNull(position);
        }

        [TestMethod]
        public void PositionIdPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsPosition position = new ClsPosition();
            // Create some test data to assign to the property
            int TestData = 112;
            // Assign the data to the property
            position.PositionId = TestData;
            // Test to see that the two values are the same
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
        public void TestPositionIdNotFound()
        {

            // Create an instance of the class we want to create
            ClsPosition position = new ClsPosition();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int PositionId = 1;
            // Invoke the method
            Found = position.Find(PositionId);
            // Check the staff name
            if (position.PositionId != 13)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestPositionNameNotFound()
        {
            ClsPosition position = new ClsPosition();
            bool Found = false;
            bool OK = true;
            //string Name = "Software Engineer";
            int PositionId = 13;
            Found = position.Find(PositionId);
            if (position.PositionName != "Software Engineer")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionNotFound()
        {

            ClsPosition position = new ClsPosition();
            bool Found = false;
            bool OK = true;
            //string Description = "Develops software solutions";
            int PositionId = 13;
            Found = position.Find(PositionId);
            if (position.Description != "Develops software solutions")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSalaryNotFound()
        {

            ClsPosition position = new ClsPosition();
            bool Found = false;
            bool OK = true;
            //int Salary = 50000;
            int PositionId = 13;
            Found = position.Find(PositionId);
            if (position.Salary!= 50000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }



    }
}
