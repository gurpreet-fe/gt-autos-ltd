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

        private string mStaffName;
        public string StaffName
        {
            get { return mStaffName; }
            set { mStaffName = value; }
        }

        private int mOfficeCode;
        public int OfficeCode
        {
            get { return mOfficeCode; }
            set { mOfficeCode = value; }
        }

        private int mPositionId;
        public int PositionId
        {
            get { return mPositionId; }
            set { mPositionId = value; }
        }

        private long mStaffContactNumber;
        public long StaffContactNumber
        {
            get { return mStaffContactNumber; }
            set { mStaffContactNumber = value; }
        }

        private string mStaffAddress;
        public string StaffAddress
        {
            get { return mStaffAddress; }
            set { mStaffAddress = value; }
        }

        private DateTime mHireDate;
        public DateTime HireDate
        {
            get { return mHireDate; }
            set { mHireDate = value; }
        }

        private bool mIsEmployed;
        public bool IsEmployed
        {
            get { return mIsEmployed; }
            set { mIsEmployed = value; }
        }

        //public bool Find(string staffName)
        //{
        //    // Set the private data member to the test data value
        //    mStaffId = 123;
        //    mStaffName = "Bill Gates";
        //    mOfficeCode = 03;
        //    mPositionId = 112;
        //    mStaffContactNumber = 07456330713;
        //    mStaffAddress = "1 Park Road, Leicester, LE2 1PK";
        //    mHireDate = DateTime.Now.Date;
        //    mIsEmployed = true;

        //    // Always return true
        //    return true;
        //}

        public bool Find(int staffId)
        {
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

        // Function for the public validation method
        public string Valid(string staffId,
                            string staffName,
                            string officeCode,
                            string positionId,
                            string staffContactNumber,
                            string staffAddress,
                            string hireDate,
                            string isHired)
        // This function accepts 5 parameters for validation
        // The function returns a string containing any error message
        // If no errors found then a blank string is returned
        {
            // Crate a string variable to store the error
            String Error = "";

            // If the StaffName is blank
            if (StaffName.Length == 0)
            {
                // Record the error
                Error = Error + "The staff name may not be blank: ";
            }

            // Return any error messages
            return Error;
        }


    }
}
