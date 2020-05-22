using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsPosition
    {
        private int mPositionID;
        private string mPositionName;
        private string mDescription;
        private decimal mSalary;

        // PositionID private member variable
        public int PositionID
        {
            get
            {
                // Send data out of the property
                return mPositionID;
            }
            set
            {
                // Allow data into the property
                mPositionID = value;
            }
        }

        public string PositionName
        {
            get { return mPositionName; }
            set { mPositionName = value; }
        }

        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        public decimal Salary
        {
            get { return mSalary; }
            set { mSalary = value; }
        }

        public String allProperties
        {
            get
            {
                return "Position ID: " + PositionID + ", Position Name: " + PositionName + ", Description: " + Description + ", Salary: " + Salary;
                ;
            }
        }

        public bool Find(int positionID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PositionID", positionID);
            DB.Execute("sproc_tblPosition_FilterByPositionID");

            if (DB.Count == 1)
            {
                mPositionID = Convert.ToInt32(DB.DataTable.Rows[0]["PositionID"]);
                mPositionName = Convert.ToString(DB.DataTable.Rows[0]["PositionName"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string positionName,
                            string description,
                            string salary)
        {
            string error = "";

            // Name
            if (positionName.Length == 0)
            {
                error += "The position name may not be blank: ";
            }

            if (positionName.Length > 30)
            {
                error += "The position name must be less than 30 characters: ";
            }

            // Description
            if (description.Length == 0)
            {
                error += "The description may not be blank: ";
            }

            if (description.Length > 100)
            {
                error += "The description must not be less than 100: ";
            }

            // Salary
            if (salary.Length == 0)
            {
                error += "The salary may not be blank: ";
            }

            if (salary.Length > 18)
            {
                error += "The salary must not be less than 18: ";
            }

            return error;
        }
    }
}
