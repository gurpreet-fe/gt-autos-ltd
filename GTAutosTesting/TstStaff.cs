using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Test to see that it exists
            Assert.IsNotNull(member);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Create some test data to assign to the property
            int TestData = 123;
            // Assign the data to the property
            member.StaffId = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(member.StaffId, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Create some test data to assign to the property
            string TestData = "Bill Gates";
            // Assign the data to the property
            member.StaffName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(member.StaffName, TestData);
        }

        [TestMethod]
        public void OfficeCodePropertyOK()
        {
            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Create some test data to assign to the property
            int TestData = 03;
            // Assign the data to the property
            member.OfficeCode = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(member.OfficeCode, TestData);
        }


        [TestMethod]
        public void PositionIdPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Create some test data to assign to the property
            int TestData = 112;
            // Assign the data to the property
            member.PositionId = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(member.PositionId, TestData);
        }

        [TestMethod]
        public void StaffContactNumberPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Create some test data to assign to the property
            int TestData = 07456330713;
            // Assign the data to the property
            member.StaffContactNumber = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(member.StaffContactNumber, TestData);
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Create some test data to assign to the property
            string TestData = "1 Park Road, Leicester, LE2 1PK";
            // Assign the data to the property
            member.StaffAddress = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(member.StaffAddress, TestData);
        }

        [TestMethod]
        public void HireDatePropertyOK()
        {
            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            member.HireDate = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(member.HireDate, TestData);
        }

        [TestMethod]
        public void IsEmployedPropertyOK()
        {
            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Create some test data to assign to the property
            bool TestData = true;
            // Assign the data to the property
            member.IsEmployed = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(member.IsEmployed, TestData);
        }

    }
}
