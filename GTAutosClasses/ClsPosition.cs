using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsPosition
    {
        private int mPositionId;
        private string mPositionName;
        private string mDescription;
        private double mSalary;

        // PositionId private member variable
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

        public double Salary
        {
            get { return mSalary; }
            set { mSalary = value; }
        }

        public String allProperties
        {
            get
            {
                return "Position Id: " + PositionId + ", Position Name: " + PositionName + ", Description: " + Description + ", Salary: " + Salary;
                ;
            }
        }

        public bool Find(int positoinId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PositionId", PositionId);
            DB.Execute("sproc_tblPosition_FilterByPositionId");

            if (DB.Count == 1)
            {
                mPositionId = Convert.ToInt32(DB.DataTable.Rows[0]["PositionId"]);
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
                            string positionDescription,
                            string salary)
        {
            string error = "";

            // Position Name
            if (positionName.Length == 0)
            {
                error += "The position name may not be blank: ";
            }

            if (positionName.Length > 60)
            {
                error += "The position name must be less than 60 characters: ";
            }

            // Description
            if (positionDescription.Length == 0)
            {
                error += "The position description must not be blank: ";
            }

            if (positionDescription.Length > 100)
            {
                error += "The position description must not be less than 100: ";
            }

            // Salary
            if (salary.Length == 0)
            {
                error += "The position salary must not be blank: ";
            }

            if (salary.Length > 7)
            {
                error += "The position salary must not be less than 7: ";
            }

            return error;
        }
    }
}
