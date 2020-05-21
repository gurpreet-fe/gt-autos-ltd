using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsStaff
    {

        private int mStaffID;
        private string mStaffName;
        private int mOfficeCode;
        private int mPositionID;
        private string mContactNumber;
        private string mAddress;
        private DateTime mHireDate;
        private bool mIsEmployed;

        // StaffID private member variable
        public int StaffID
        {
            get
            {
                // Send data out of the property
                return mStaffID;
            }
            set
            {
                // Allow data into the property
                mStaffID = value;
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

        public int PositionID
        {
            get { return mPositionID; }
            set { mPositionID = value; }
        }

        public string ContactNumber
        {
            get { return mContactNumber; }
            set { mContactNumber = value; }
        }

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
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
                return "Staff ID: " + StaffID + ", Staff Name: " + StaffName + ", Office Code: " + OfficeCode + ", Postion ID:" + PositionID + ", Contact Number:" + ContactNumber + ", Home Address:" + Address + ", Hire Date:" + HireDate + ", Is employed?:" + IsEmployed;
                ;
            }
        }

        public bool Find(int staffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");

            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mOfficeCode = Convert.ToInt32(DB.DataTable.Rows[0]["OfficeCode"]);
                mPositionID = Convert.ToInt32(DB.DataTable.Rows[0]["PositionID"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireDate"]);
                mIsEmployed = Convert.ToBoolean(DB.DataTable.Rows[0]["IsEmployed"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string staffName,
                            string contactNumber,
                            string address,
                            string hireDate)
        {
            string error = "";
            DateTime tempDate;

            // Staff Name
            if (staffName.Length == 0)
            { 
                error += "Staff name may not be blank: "; 
            }

            if (staffName.Length > 30)
            { 
                error += "Staff name must be less than 30 characters: ";
            }

            // Contact Number
            if (contactNumber.Length == 0)
            { 
                error += "Contact number may not be blank: "; 
            }

            if (contactNumber.Length < 10)
            { 
                error += "Contact number is too short: ";
            }

            if (contactNumber.Length > 15)
            { 
                error += "Contact number may not be less than 15: "; 
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(contactNumber, "^[a-zA-Z]*$"))
            { 
                error += "Contact number must not contain invalid characters: ";
            }

            // Staff Address
            if (address.Length == 0)
            {
                error += "Address may not be blank: ";
            }

            if (address.Length > 50)
            { 
                error += "Address must be less than 50 characters: "; 
            }

            // Hire Date
            try
            {
                tempDate = Convert.ToDateTime(hireDate);
                if (tempDate < DateTime.Now.Date)
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
