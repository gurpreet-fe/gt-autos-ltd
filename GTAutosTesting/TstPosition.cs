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
            int PositionId = 13;
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

            // Create an instance of the class we want to create
            ClsPosition position = new ClsPosition();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            string Name = "Software Engineer";
            // Invoke the method
            Found = position.Find(PositionName);
            // Check the staff name
            if (position.PositionName != "Software Engineer")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDescriptionNotFound()
        {

            // Create an instance of the class we want to create
            ClsPosition position = new ClsPosition();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            string Desctiption = "Develops software solutions";
            // Invoke the method
            Found = position.Find(Description);
            // Check the staff name
            if (position.Description != "Develops software solutions")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSalaryNotFound()
        {

            // Create an instance of the class we want to create
            ClsPosition position = new ClsPosition();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int Salary = 50000;
            // Invoke the method
            Found = position.Find(Salary);
            // Check the staff name
            if (position.Salary!= 50000)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }



    }
}
