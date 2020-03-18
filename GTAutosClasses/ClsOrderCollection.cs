using System;
using System.Collections.Generic;

namespace GTAutosClasses
{
    public class ClsOrderCollection
    {

         List<ClsOrder> mOrderList = new List<ClsOrder>();
         ClsOrder mThisOrder = new ClsOrder();

        public ClsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                ClsOrder AnOrder = new ClsOrder();
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.NumberPlate = Convert.ToString(DB.DataTable.Rows[Index]["NumberPlate"]);
                AnOrder.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                AnOrder.DateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfOrder"]);
                AnOrder.OrderPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["OrderPrice"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.Completed = Convert.ToBoolean(DB.DataTable.Rows[Index]["Completed"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }


        public List<ClsOrder> OrderList
         {
             get
             {
                 return mOrderList;
             }
             set
             {
                mOrderList = value;
             }
         }
        public ClsOrder ThisOrder { 
            get 
            {
                return mThisOrder;
            }
            set 
            {
                mThisOrder = value;
            } 
        }

        public int Count { 
            get 
            {
                return mOrderList.Count;    
            } 
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
           // ClsOrder AnOrder = new ClsOrder();
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@NumberPlate", mThisOrder.NumberPlate);
            DB.AddParameter("@PaymentID", mThisOrder.PaymentID);
            DB.AddParameter("@DateOfOrder", mThisOrder.DateOfOrder = DateTime.Now.Date);
            DB.AddParameter("@ServiceID", mThisOrder.ServiceID);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@Completed", mThisOrder.Completed);

            return DB.Execute("sproc_tblOrder_InsertOrder");

        }
    }
}