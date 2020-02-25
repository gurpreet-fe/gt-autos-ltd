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
            // Create an instance of the class we want to create
            ClsPosition position = new ClsPosition();
            // Create some test data to assign to the property
            string TestData = "Software Engineer";
            // Assign the data to the property
            position.PositionName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(position.PositionName, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsPosition position = new ClsPosition();
            // Create some test data to assign to the property
            string TestData = "Develops software solutions";
            // Assign the data to the property
            position.Description = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(position.Description, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsPosition position = new ClsPosition();
            // Create some test data to assign to the property
            double TestData = 50000.00;
            // Assign the data to the property
            position.Salary = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(position.Salary, TestData);
        }

    }
}
