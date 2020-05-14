using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsOrder
    {
        private Int32 pOrderID;
        private Int32 pCustomerID;
        private Int32 pCarID;
        private Int32 pPaymentID;
        private DateTime pDateOfOrder;
        private int pServiceID;
        private double pOrderPrice;
        private string pOrderStatus;
        private Boolean pCompleted;
        ClsService cs = new ClsService();
        public int OrderID 
        {
            get 
            {
                return pOrderID;
            }
            set
            {
                pOrderID = value;
            }
        }
        public int CustomerID 
        { 
            get 
            {
                return pCustomerID;
            } 
            set 
            {
                pCustomerID = value;
            } 
        }
        public int CarID 
        { 
            get 
            {
                return pCarID;
            }
            set
            {
                pCarID = value;
            } 
        }
        public DateTime DateOfOrder 
        {
            get 
            {
                return pDateOfOrder;          
            } 
            set 
            {
                pDateOfOrder = value;   
            } 
        }
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
        public double OrderPrice 
        {
            get 
            {
                return pOrderPrice;
            } 
            set 
            {
                pOrderPrice = value;
            } 
        }
        public string OrderStatus 
        {
            get 
            {
                return pOrderStatus;
            }
            set 
            {
                pOrderStatus = value;
            } 
        }
        public int PaymentID 
        {
            get 
            {
                return pPaymentID;
            } 
            set 
            {
                pPaymentID = value;
            } 
        }
        public bool Completed 
        {
            get 
            {
                return pCompleted;
            } 
            set 
            {
                pCompleted = value;   
            } 
        }

        public string allProperties 
        {
            get 
            {
                return "OrderID: " + OrderID + ", CustomerID: " +  CustomerID + ", CarID: " + CarID + ", PaymentID: " + PaymentID +  ", Date Of Order: " + DateOfOrder.ToString("dd-MM-yy") + ", ServiceID: " + ServiceID + ", Order Price: " + OrderPrice +  ", Order Status:" + OrderStatus + ", Completed: " + Completed;
            }
        }

        public bool Find(int OrderID)
        {
            // Create a new database connection instance.
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the Order ID to search for.
            DB.AddParameter("@OrderID", OrderID);
            // Execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderID");
            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                pOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                pCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                pCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
                pPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                pDateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfOrder"]);
                pServiceID = Convert.ToInt32(DB.DataTable.Rows[0]["ServiceID"]);
                pOrderPrice = Convert.ToDouble(DB.DataTable.Rows[0]["OrderPrice"]);
                pOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                pCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["Completed"]);
                return true;
            }
            else 
            {
                return false;
            }
        }

        public string Valid(string dateOfOrder, string orderPrice, string orderStatus)
        {
            String Error = "";
            DateTime DateTemp;
            double number;
            try
            {
                DateTemp = Convert.ToDateTime(dateOfOrder);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the past : ";
                }

                DateTemp = Convert.ToDateTime(dateOfOrder);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The Date cannot be in the future : ";
                }
            }
            catch 
            {
                Error = Error + "The Date was not a valid date : ";
            }

            try
            {
                number = Convert.ToDouble(orderPrice);
                if (number <= 0)
                {
                    Error = Error + "The OrderPrice cannot be lower then or equal to 0 : ";
                }
            }
            catch 
            {
                Error = Error + "The OrderPrice was not a valid number : ";
            }

            if (orderStatus.Length == 0) 
            {
                Error = Error + "The OrderStatus may not be kept empty : ";
            }

            if (orderStatus.Length > 50)
            {
                Error = Error + "The serviceID must be less then 50 characters : ";
            }
            return Error;
        }
    }
}