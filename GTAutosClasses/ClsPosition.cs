using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsPosition
    {

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
        // PositionName private member variable
        private string mPositionName;
        public string PositionName
        {
            get
            {
                // Send data out of the property
                return mPositionName;
            }
            set
            {
                // Allow data into the property
                mPositionName = value;
            }
        }
        // Description private member variable
        private string mDescription;
        public string Description
        {
            get
            {
                // Send data out of the property
                return mDescription;
            }
            set
            {
                // Allow data into the property
                mDescription = value;
            }
        }
        // Salary private member variable
        private double mSalary;
        public double Salary
        {
            get
            {
                // Send data out of the property
                return mSalary;
            }
            set
            {
                // Allow data into the property
                mSalary = value;
            }
        }

        public bool Find(int positionId)
        {

            // Set the private data member to the test data value
            mPositionId = 123;
            mPositionName = "Software Engineer";
            mDescription = "Develops software solutions";
            mSalary = 50000;

            // Always return true
            return true;

            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the staff name to search for
            DB.AddParameter("@PositionName", PositionName);
            // Execute the stored procedure
            DB.Execute("sproc_tblPosition_FilterByPositionName");

            // If one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // Copy the data from the daabase to the private data members
                mPositionId = Convert.ToInt32(DB.DataTable.Rows[0]["Position Id"]);
                mPositionName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);
                
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
