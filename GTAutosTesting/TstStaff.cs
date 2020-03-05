using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstStaff
    {
        // Good test data
        // Create some test data to pass to the method
        //string StaffId = "123";
        //string StaffName = "Bill Gates";
        //string OfficeCode = "03";
        //string PositionId = "112";
        //string StaffContactNumber = "07456330713";
        //string StaffAddress = "1 Park Road, Leicester, LE2 1PK";
        //string HireDate = DateTime.Now.Date.ToString();
        //string IsHired = "true";


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
            ClsStaff member = new ClsStaff();
            string TestData = "Bill Gates";
            member.StaffName = TestData;
            Assert.AreEqual(member.StaffName, TestData);
        }

        [TestMethod]
        public void OfficeCodePropertyOK()
        {
            ClsStaff member = new ClsStaff();
            int TestData = 03;
            member.OfficeCode = TestData;
            Assert.AreEqual(member.OfficeCode, TestData);
        }


        [TestMethod]
        public void PositionIdPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            int TestData = 112;
            member.PositionId = TestData;
            Assert.AreEqual(member.PositionId, TestData);
        }

        [TestMethod]
        public void StaffContactNumberPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            long TestData = 07456330713;
            member.StaffContactNumber = TestData;
            Assert.AreEqual(member.StaffContactNumber, TestData);
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            string TestData = "1 Park Road, Leicester, LE2 1PK";
            member.StaffAddress = TestData;
            Assert.AreEqual(member.StaffAddress, TestData);
        }

        [TestMethod]
        public void HireDatePropertyOK()
        {
            ClsStaff member = new ClsStaff();
            DateTime TestData = DateTime.Now.Date;
            member.HireDate = TestData;
            Assert.AreEqual(member.HireDate, TestData);
        }

        [TestMethod]
        public void IsEmployedPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            bool TestData = true;
            member.IsEmployed = TestData;
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
            //string Name = "Bill Gates";
            int StaffId = 1;
            // Invoke the method
            Found = member.Find(StaffId);
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
            int StaffId = 1;
            // Invoke the method
            Found = member.Find(StaffId);
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
            ClsStaff member = new ClsStaff();
            bool Found = false;
            bool OK = true;
            //string Name = "Bill Gates";
            int StaffId = 1;
            Found = member.Find(StaffId);
            if (member.StaffName != "Bill Gates")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOfficeCodeNotFound()
        {
            ClsStaff member = new ClsStaff();
            bool Found = false;
            bool OK = true;
            //Int32 OfficeCode = 1;
            int Id = 1;
            Found = member.Find(Id);
            if (member.OfficeCode != 03)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPositionIdNotFound()
        {

            ClsStaff member = new ClsStaff();
            bool Found = false;
            bool OK = true;
            //int PositionId = 112;
            int Id = 1;
            Found = member.Find(Id);
            if (member.PositionId != 112)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffContactNumberNotFound()
        {
            ClsStaff member = new ClsStaff();
            bool Found = false;
            bool OK = true;
            //long ContactNumber = 07456330713;
            int Id = 1;
            Found = member.Find(Id);
            if (member.StaffContactNumber != 07456330713)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressNotFound()
        {
            ClsStaff member = new ClsStaff();
            bool Found = false;
            bool OK = true;
            //string Address = "1 Park Road, Leicester, LE2 1PK";
            int StaffId = 1;
            Found = member.Find(StaffId);
            if (member.StaffName != "1 Park Road, Leicester, LE2 1PK")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHireDateNotFound()
        {
            ClsStaff member = new ClsStaff();
            bool Found = false;
            bool OK = true;
            //DateTime Today = DateTime.Now.Date;
            int StaffId = 1;
            Found = member.Find(StaffId);
            if (member.HireDate != DateTime.Now.Date)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsEmployedNotFound()
        {
            ClsStaff member = new ClsStaff();
            bool Found = false;
            bool OK = true;
            //bool IsEmployed = true;
            int Id = 1;
            Found = member.Find(Id);
            if (member.IsEmployed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        //public void ValidMethodOK()
        //{
        //    // Create an instance of the class we want to create
        //    ClsStaff member = new ClsStaff();
        //    // String variable to store any error message
        //    String Error = "";
        //    // Invoke the method
        //    Error = member.Valid(StaffId, StaffName, OfficeCode, PositionId, StaffContactNumber, StaffAddress, HireDate, IsHired);
        //    // Test to see that the result is correct
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void StaffNameMin()
        //{
        //    // Create an instance of the class we want to create
        //    ClsStaff member = new ClsStaff();
        //    // String variable to store any error message
        //    String Error = "";
        //    // Create some test data to pass to the method
        //    string StaffName = "a"; // This should be okay
        //    // Invoke the method
        //    Error = member.Valid(StaffId, StaffName, OfficeCode, PositionId, StaffContactNumber, StaffAddress, HireDate, IsHired);
        //    // Test to see that the result is correct
        //    Assert.AreEqual(Error, "");

        //}

        //[TestMethod]
        //public void StaffNameMinPlusOne()
        //{
        //    ClsStaff member = new ClsStaff();
        //    String Error = "";
        //    string StaffName = "aa";
        //    Error = member.Valid(StaffId, StaffName, OfficeCode, PositionId, StaffContactNumber, StaffAddress, HireDate, IsHired);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void StaffNameMaxLessOne()
        //{
        //    ClsStaff member = new ClsStaff();
        //    String Error = "";
        //    string StaffName = "aaaaa";
        //    Error = member.Valid(StaffId, StaffName, OfficeCode, PositionId, StaffContactNumber, StaffAddress, HireDate, IsHired);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void StaffNameMax()
        //{
        //    ClsStaff member = new ClsStaff();
        //    String Error = "";
        //    string StaffName = "aaaaaa";
        //    Error = member.Valid(StaffId, StaffName, OfficeCode, PositionId, StaffContactNumber, StaffAddress, HireDate, IsHired);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void StaffNameMid()
        //{
        //    ClsStaff member = new ClsStaff();
        //    String Error = "";
        //    string StaffName = "aaa";
        //    Error = member.Valid(StaffId, StaffName, OfficeCode, PositionId, StaffContactNumber, StaffAddress, HireDate, IsHired);
        //    Assert.AreEqual(Error, "");
        //}

        //[TestMethod]
        //public void StaffNameMaxPlusOne()
        //{
        //    ClsStaff member = new ClsStaff();
        //    String Error = "";
        //    string StaffName = "aaaaaaa";
        //    Error = member.Valid(StaffId, StaffName, OfficeCode, PositionId, StaffContactNumber, StaffAddress, HireDate, IsHired);
        //    Assert.AreEqual(Error, "");
        //}

    }
}
