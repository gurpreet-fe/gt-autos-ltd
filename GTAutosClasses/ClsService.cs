using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsService
    {
        private int pServiceID;
        private string pServiceName;
        private string pServiceDesc;
        private double pServicePrice;
        private string pDataField;

        public int ServiceID
        {
            get
            {
                return pServiceID;
            }
            set
            {
                pServiceID = value;
            }
        }

        public string ServiceName
        {
            get
            {
                return pServiceName;
            }
            set
            {
                pServiceName = value;
            }
        }

        public string ServiceDescription
        {
            get
            {
                return pServiceDesc;
            }
            set
            {
                pServiceDesc = value;
            }
        }

        public double ServicePrice
        {
            get
            {
                return pServicePrice;
            }
            set
            {
                pServicePrice = value;
            }
        }

        public string DataField{
            get
            {
                 return pServiceName + " " + "£" + pServicePrice;
            }
            set
            {

            }
        }

        public bool Find(int ServiceID)
        {
            // Create a new database connection instance.
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the Order ID to search for.
            DB.AddParameter("@ServiceID", ServiceID);
            // Execute the stored procedure
            DB.Execute("sproc_tblServices_FilterByServiceID");
            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                pServiceID = Convert.ToInt32(DB.DataTable.Rows[0]["ServiceID"]);
                pServiceName = Convert.ToString(DB.DataTable.Rows[0]["ServiceName"]);
                pServiceDesc = Convert.ToString(DB.DataTable.Rows[0]["ServiceDescription"]);
                pServicePrice = Convert.ToDouble(DB.DataTable.Rows[0]["ServicePrice"]);
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string serviceName, string serviceDesc, string servicePrice)
        {
            String Error = "";
            double number;
            try
            {
                number = Convert.ToDouble(servicePrice);
                if (number <= 0)
                {
                    Error = Error + "The OrderPrice cannot be lower then or equal to 0 : ";
                }
            }
            catch
            {
                Error = Error + "The Service Price was not a valid number : ";
            }

            if (serviceName.Length == 0)
            {
                Error = Error + "The Service Name may not be kept empty : ";
            }

            if (serviceName.Length > 50)
            {
                Error = Error + "The Service Name must be less then 50 characters : ";
            }

            if (serviceDesc.Length == 0)
            {
                Error = Error + "The Service Description may not be kept empty : ";
            }

            if (serviceDesc.Length > 255)
            {
                Error = Error + "The Service Description must be less then 255 characters : ";
            }
            return Error;
        }
    }
}
