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
        string contactNumber = "07456330713";
        string address = "1 Park Road, Leicester, LE2 1PK";
        string hireDate = DateTime.Now.Date.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            ClsStaff member = new ClsStaff();
            Assert.IsNotNull(member);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            int testData = 1;
            member.StaffID = testData;
            Assert.AreEqual(member.StaffID, testData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            ClsStaff member = new ClsStaff();
            string testData = "Bill Gates";
            member.StaffName = testData;
            Assert.AreEqual(member.StaffName, testData);
        }

        [TestMethod]
        public void OfficeCodePropertyOK()
        {
            ClsStaff member = new ClsStaff();
            int testData = 03;
            member.OfficeCode = testData;
            Assert.AreEqual(member.OfficeCode, testData);
        }


        [TestMethod]
        public void PositionIDPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            int testData = 1;
            member.PositionID = testData;
            Assert.AreEqual(member.PositionID, testData);
        }

        [TestMethod]
        public void ContactNumberPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            string testData = "07456330713";
            member.ContactNumber = testData;
            Assert.AreEqual(member.ContactNumber, testData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            string testData = "1 Park Road, Leicester, LE2 1PK";
            member.Address = testData;
            Assert.AreEqual(member.Address, testData);
        }

        [TestMethod]
        public void HireDatePropertyOK()
        {
            ClsStaff member = new ClsStaff();
            DateTime testData = DateTime.Now.Date;
            member.HireDate = testData;
            Assert.AreEqual(member.HireDate, testData);
        }

        [TestMethod]
        public void IsEmployedPropertyOK()
        {
            ClsStaff member = new ClsStaff();
            bool testData = true;
            member.IsEmployed = testData;
            Assert.AreEqual(member.IsEmployed, testData);
        }

        // -------------------------------- Find Method -------------------------------- //
        [TestMethod]
        public void FindMethodOK()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            int StaffID = 1;

            Found = member.Find(StaffID);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int StaffID = 1;

            Found = member.Find(StaffID);

            if (member.StaffID != 123)
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
            int StaffID = 1;

            Found = member.Find(StaffID);

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
            int ID = 1;

            Found = member.Find(ID);

            if (member.OfficeCode != 03)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPositionIDFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int ID = 1;

            Found = member.Find(ID);

            if (member.PositionID != 112)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNumberFound()
        {
            ClsStaff member = new ClsStaff();

            bool Found = false;
            bool OK = true;
            int ID = 1;

            Found = member.Find(ID);

            if (member.ContactNumber != "07456330713")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            ClsStaff member = new ClsStaff();

            bool found = false;
            bool OK = true;
            int ID = 1;

            found = member.Find(ID);

            if (member.Address != "1 Park Road, Leicester, LE2 1PK")
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
            int StaffID = 1;

            Found = member.Find(StaffID);

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
            int ID = 1;

            Found = member.Find(ID);

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

            Error = member.Valid(staffName, contactNumber, address, hireDate);

            Assert.AreEqual(Error, "");
        }

        // ---------------- Staff Name ---------------- //
        [TestMethod]
        public void StaffNameMinLess1()
        {
            ClsStaff member = new ClsStaff();

            string error = "";
            string staffName = "";

            error = member.Valid(staffName, contactNumber, address, hireDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "A";

            error = member.Valid(staffName, contactNumber, address, hireDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMinPlus1()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "AA";

            error = member.Valid(staffName, contactNumber, address, hireDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "";
            staffName = staffName.PadRight(15, 'A');

            error = member.Valid(staffName, contactNumber, address, hireDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxLess1()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "";
            staffName = staffName.PadRight(29, 'A');

            error = member.Valid(staffName, contactNumber, address, hireDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "";
            staffName = staffName.PadRight(30, 'A');

            error = member.Valid(staffName, contactNumber, address, hireDate);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlus1()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "";
            staffName = staffName.PadRight(31, 'A');

            error = member.Valid(staffName, contactNumber, address, hireDate);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxExtreme()
        {
            ClsStaff member = new ClsStaff();

            String error = "";
            string staffName = "";
            staffName = staffName.PadRight(500, 'A');

            error = member.Valid(staffName, contactNumber, address, hireDate);

            Assert.AreNotEqual(error, "");
        }

        // ---------------- Staff Contact Number ---------------- //
        [TestMethod]
        public void ContactNumberMinLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string contactNumber = "";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ContactNumberMin()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string contactNumber = "0";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ContactNumberMinPlus1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string contactNumber = "01";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ContactNumberMid()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string contactNumber = "012345";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ContactNumberMaxLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string contactNumber = "01234567891123";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ContactNumberMax()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string contactNumber = "012234567898765";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ContactNumberMaxPlus1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string contactNumber = "0122345547859736";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ContactNumberMaxExtreme()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string contactNumber = "";
            contactNumber = contactNumber.PadRight(500, '1');
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        // ---------------- Staff Address ---------------- //
        [TestMethod]
        public void AddressMinLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string address = "";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string address = "A";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMinPlus1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string address = "AA";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string address = "";
            address = address.PadRight(25, 'A');
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMaxLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string address = "";
            address = address.PadRight(49, 'A');
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string address = "";
            address = address.PadRight(50, 'A');
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void AddressMaxPlus1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string address = "";
            address = address.PadRight(51, 'A');
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void AddressMaxExtreme()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string address = "";
            contactNumber = contactNumber.PadRight(500, 'A');
            error = member.Valid(staffName, contactNumber, address, hireDate);
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
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateMinLess1()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddDays(-1);
            string hireDate = testDate.ToString();
            error = member.Valid(staffName, contactNumber, address, hireDate);
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
            error = member.Valid(staffName, contactNumber, address, hireDate);
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
            error = member.Valid(staffName, contactNumber, address, hireDate);
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
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateInvalid()
        {
            ClsStaff member = new ClsStaff();
            string error = "";
            string hireDate = "This is a date!";
            error = member.Valid(staffName, contactNumber, address, hireDate);
            Assert.AreNotEqual(error, "");
        }
    }
}