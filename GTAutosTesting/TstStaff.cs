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
        string staffName = "Bill Gates";
        string staffContactNumber = "07456330713";
        string staffAddress = "1 Park Road, Leicester, LE2 1PK";
        string hireDate = DateTime.Now.Date.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            ClsStaff member = new ClsStaff();

            Assert.IsNotNull(member);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            int TestData = 123;

            member.StaffId = TestData;

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
            string TestData = "07456330713";

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

        // -------------------------------- Find Method -------------------------------- //

        [TestMethod]
        public void FindMethodOK()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            int StaffId = 1;

            Found = member.Find(StaffId);

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int StaffId = 1;

            Found = member.Find(StaffId);

            if (member.StaffId != 123)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int StaffId = 1;

            Found = member.Find(StaffId);

            if (member.StaffName != "Bill Gates")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOfficeCodeFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int Id = 1;

            Found = member.Find(Id);

            if (member.OfficeCode != 03)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPositionIdFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int Id = 1;

            Found = member.Find(Id);

            if (member.PositionId != 112)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffContactNumberFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int Id = 1;

            Found = member.Find(Id);

            if (member.StaffContactNumber != "07456330713")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int StaffId = 1;

            Found = member.Find(StaffId);

            if (member.StaffName != "1 Park Road, Leicester, LE2 1PK")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHireDateFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int StaffId = 1;

            Found = member.Find(StaffId);

            if (member.HireDate != DateTime.Now.Date)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsEmployedFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int Id = 1;

            Found = member.Find(Id);

            if (member.IsEmployed != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        // -------------------------------- Valid Method -------------------------------- //

        [TestMethod]
        public void ValidMethodOK()
        {
            ClsStaff member = new ClsStaff();

            String Error = "";

            Error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);

            Assert.AreEqual(Error, "");
        }

        // ---------------- Staff Name ---------------- //

        [TestMethod]
        public void StaffNameMinLess1()
        {
            ClsStaff member = new ClsStaff();

            string error = "";
            string staffName = "";

            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);

            Assert.AreNotEqual(error, "");

        }

        [TestMethod]
        public void StaffNameMin()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "A";

            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void StaffNameMinPlus1()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "AA";

            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "AAA";

            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxLess1()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "AAAAAAAAAAAAAAAAAAA";

            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "AAAAAAAAAAAAAAAAAAAA";

            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlus1()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "AAAAAAAAAAAAAAAAAAAAA";

            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxExtreme()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "AAAAAAAAAAAAAAAAAAAAAAAAAA";

            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);

            Assert.AreNotEqual(error, "");
        }

        // ---------------- Staff Contact Number ---------------- //

        [TestMethod]
        public void StaffContactNumberMinLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffContactNumberMin()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "A";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffContactNumberMinPlus1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffContactNumberMid()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AAAA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffContactNumberMaxLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AAAAAAAA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffContactNumberMax()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AAAAAAAAA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffContactNumberMaxPlus1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AAAAAAAAAA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffContactNumberMaxExtreme()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "";
            staffContactNumber = staffContactNumber.PadRight(500, 'A');
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }



        // ---------------- Staff Address ---------------- //


        [TestMethod]
        public void StaffAddressMinLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMin()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "A";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMinPlus1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMid()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AAAA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMaxLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AAAAAAAA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMax()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AAAAAAAAA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMaxPlus1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "AAAAAAAAAA";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMaxExtreme()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string staffContactNumber = "";
            staffContactNumber = staffContactNumber.PadRight(500, 'A');
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }



        // ---------------- Staff Hire Date ---------------- //

        [TestMethod]
        public void DateMinExtreme()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(-100);
            string hireDate = testDate.ToString();
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateMinLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(-1);
            string hireDate = testDate.ToString();
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateMin()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            string hireDate = testDate.ToString();
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateMinPlus1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(1);
            string hireDate = testDate.ToString();
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateMaxExtreme()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(100);
            string hireDate = testDate.ToString();
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateInvalid()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string hireDate = "This is a date!";
            error = member.Valid(staffName, staffContactNumber, staffAddress, hireDate);
            Assert.AreNotEqual(error, "");
        }
    }
}