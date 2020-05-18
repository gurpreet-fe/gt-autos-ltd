using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsStaff
    {

        private int mStaffId;
        private string mStaffName;
        private int mOfficeCode;
        private int mPositionId;
        private string mStaffContactNumber;
        private string mStaffAddress;
        private DateTime mHireDate;
        private bool mIsEmployed;



        // StaffId private member variable
        public int StaffId
        {
            get
            {
                // Send data out of the property
                return mStaffId;
            }
            set
            {
                // Allow data into the property
                mStaffId = value;
            }
        }


        public string StaffName
        {
            get { return mStaffName; }
            set { mStaffName = value; }
        }


        public int OfficeCode
        {
            get { return mOfficeCode; }
            set { mOfficeCode = value; }
        }

        public int PositionId
        {
            get { return mPositionId; }
            set { mPositionId = value; }
        }

        public string StaffContactNumber
        {
            get { return mStaffContactNumber; }
            set { mStaffContactNumber = value; }
        }

        public string StaffAddress
        {
            get { return mStaffAddress; }
            set { mStaffAddress = value; }
        }

        public DateTime HireDate
        {
            get { return mHireDate; }
            set { mHireDate = value; }
        }

        public bool IsEmployed
        {
            get { return mIsEmployed; }
            set { mIsEmployed = value; }
        }

        public String allProperties
        {
            get
            {
                return "Staff Id: " + StaffId + ", Staff Name: " + StaffName + ", Office Code: " + OfficeCode + ", Postion Id:" + PositionId + ", Contact Number:" + StaffContactNumber + ", Address:" + StaffAddress + ", Hire Date:" + HireDate + ", Is Employed?:" + IsEmployed;
                ;
            }
        }

        public bool Find(int staffId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblOrders_FilterByStaffID");

            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mOfficeCode = Convert.ToInt32(DB.DataTable.Rows[0]["OfficeCode"]);
                mPositionId = Convert.ToInt32(DB.DataTable.Rows[0]["PositionId"]);
                mStaffContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffHireDate"]);
                mIsEmployed = Convert.ToBoolean(DB.DataTable.Rows[0]["IsEmployed"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string staffName,
                            string staffContactNumber,
                            string staffAddress,
                            string hireDate)
        {
            string error = "";
            DateTime tempDate;

            // Staff Name
            if (staffName.Length == 0)
            { 
                error += "StaffName must not be blank: "; 
            }

            if (staffName.Length > 60)
            { 
                error += "StaffName must be less than 60 characters: ";
            }

            // Contact Number
            if (staffContactNumber.Length == 0)
            { 
                error += "StaffContactNumber may not be blank: "; 
            }

            if (staffContactNumber.Length < 10)
            { 
                error += "StaffContactNumber may not be less than 10: ";
            }

            if (staffContactNumber.Length > 15)
            { 
                error += "StaffContactNumber may not be less than 15: "; 
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(staffContactNumber, "^[a-zA-Z ]*$"))
            { 
                error += "StaffContactNumber contains invalid characters: ";
            }

            // Staff Address
            if (staffAddress.Length == 0)
            {
                error += "";
            }

            if (staffAddress.Length > 60)
            { 
                error += ""; 
            }

            // Hire Date
            try
            {
                tempDate = Convert.ToDateTime(hireDate);
                if (tempDate < DateTime.Now.Date.AddYears(-1))
                {
                    error += "The date cannot be in the past: ";
                }

                if (tempDate > DateTime.Now.Date)
                {
                    error += "The date cannot be in the future: ";
                }
            }
            catch
            {
                error += "The date entered is invalid: ";
            }

            return error;
        }
    }
}
