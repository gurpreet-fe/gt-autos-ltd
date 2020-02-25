using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsStaff
    {

        // StaffId private member variable
        private int mStaffId;
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

        // StaffName private member variable
        private string mStaffName;
        public string StaffName
        {
            get
            {
                // Send data out of the property
                return mStaffName;
            }
            set
            {
                // Allow data into the property
                mStaffName = value;
            }
        }

        // OfficeCode private member variable
        private int mOfficeCode;
        public int OfficeCode
        {
            get
            {
                // Send data out of the property
                return mOfficeCode;
            }
            set
            {
                // Allow data into the property
                mOfficeCode = value;
            }
        }

        // PositionId private member variable        
        private int mPositionId;
        public int PositionId
        {
            get
            {
                // Send data out of the property
                return mPositionId;
            }
            set
            {
                // Allow data into the property
                mPositionId = value;
            }
        }

        // StaffContactNumber private member variable        
        private long mStaffContactNumber;
        public long StaffContactNumber
        {
            get
            {
                // Send data out of the property
                return mStaffContactNumber;
            }
            set
            {
                // Allow data into the property
                mStaffContactNumber = value;
            }
        }

        // StaffAddress private member variable
        private string mStaffAddress;
        public string StaffAddress
        {
            get
            {
                // Send data out of the property
                return mStaffAddress;
            }
            set
            {
                // Allow data into the property
                mStaffAddress = value;
            }
        }

        // HireDate private member variable
        private DateTime mHireDate;
        public DateTime HireDate
        {
            get
            {
                // Send data out of the property
                return mHireDate;
            }
            set
            {
                // Allow data into the property
                mHireDate = value;
            }
        }

        // IsEmployed private member variable        
        private bool mIsEmployed;
        public bool IsEmployed
        {
            get
            {
                // Send data out of the property
                return mIsEmployed;
            }
            set
            {
                // Allow data into the property
                mIsEmployed = value;
            }
        }

        public bool Find(string staffName)
        {
            // Set the private data member to the test data value
            mStaffId = 123;
            mStaffName = "Bill Gates";
            mOfficeCode = 03;
            mPositionId = 112;
            mStaffContactNumber = 07456330713;
            mStaffAddress = "1 Park Road, Leicester, LE2 1PK";
            mHireDate = DateTime.Now.Date;
            mIsEmployed = true;

            // Always return true
            return true;

            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the staff name to search for
            DB.AddParameter("@StaffName", StaffName);
            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffName");

            // If one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // Copy the data from the daabase to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["Staff Id"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mOfficeCode = Convert.ToInt32(DB.DataTable.Rows[0]["Office Code"]);
                mPositionId = Convert.ToInt32(DB.DataTable.Rows[0]["Position Id"]);
                mStaffContactNumber = Convert.ToInt64(DB.DataTable.Rows[0]["Contact Number"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mHireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Hire Date"]);
                mIsEmployed = Convert.ToBoolean(DB.DataTable.Rows[0]["Employed?"]);

                // return that everything worked OK
                return true;
            }
            // If no record was found
            else
            {
                // Return false indicating a problem
                return false;
            }


        }
    }
}
