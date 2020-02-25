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
            long TestData = 07456330713;
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

        [TestMethod]
        public void FindMethodOK()
        {

            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Boolean variable to store the result of the validation
            bool Found = false;
            // Create some test data to use with the method
            string Name = "Bill Gates";
            // Invoke the method
            Found = member.Find(Name);
            // Test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStaffIdNotFound()
        {

            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int Id = 123;
            // Invoke the method
            Found = member.Find(Id);
            // Check the staff name
            if (member.StaffId != 123)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffNameNotFound()
        {

            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            string Name = "Bill Gates";
            // Invoke the method
            Found = member.Find(Name);
            // Check the staff name
            if (member.StaffName != "Bill Gates")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOfficeCodeNotFound()
        {

            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int Code = 03;
            // Invoke the method
            Found = member.Find(Code);
            // Check the staff name
            if (member.OfficeCode != 03)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPositionIdNotFound()
        {

            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            int PositionId = 112;
            // Invoke the method
            Found = member.Find(PositionId);
            // Check the staff name
            if (member.PositionId != 112)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffContactNumberNotFound()
        {

            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            long ContactNumber = 07456330713;
            // Invoke the method
            Found = member.Find(ContactNumber);
            // Check the staff name
            if (member.StaffContactNumber != 07456330713)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffAddressNotFound()
        {

            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            string Address = "1 Park Road, Leicester, LE2 1PK";
            // Invoke the method
            Found = member.Find(Address);
            // Check the staff name
            if (member.StaffName != "1 Park Road, Leicester, LE2 1PK")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }
        
        [TestMethod]
        public void TestHireDateNotFound()
        {

            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            DateTime Today = DateTime.Now.Date;
            // Invoke the method
            Found = member.Find(Today);
            // Check the staff name
            if (member.HireDate != DateTime.Now.Date)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestIsEmployedNotFound()
        {

            // Create an instance of the class we want to create
            ClsStaff member = new ClsStaff();
            // Boolean variable to store the result of the search
            bool Found = false;
            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;
            // Create some test data to use with the method
            bool IsEmployed = true;
            // Invoke the method
            Found = member.Find(IsEmployed);
            // Check the staff name
            if (member.IsEmployed != true)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);

        }


    }
}
