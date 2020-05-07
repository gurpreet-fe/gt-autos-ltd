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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB) 
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //clsDataConnection DB = new clsDataConnection();
            RecordCount = DB.Count;
            mOrderList = new List<ClsOrder>();
            while (Index < RecordCount)
            {
                ClsOrder AnOrder = new ClsOrder();
                //ClsService thisService = new ClsService();
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                AnOrder.ServiceID = Convert.ToInt32(DB.DataTable.Rows[Index]["ServiceID"]);
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
            DB.AddParameter("@CarID", mThisOrder.CarID);
            DB.AddParameter("@PaymentID", mThisOrder.PaymentID);
            DB.AddParameter("@DateOfOrder", mThisOrder.DateOfOrder = DateTime.Now.Date);
            DB.AddParameter("@ServiceID", mThisOrder.ServiceID);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@Completed", mThisOrder.Completed);

            return DB.Execute("sproc_tblOrder_InsertOrder");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrders_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            // ClsOrder AnOrder = new ClsOrder();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@CarID", mThisOrder.CarID);
            DB.AddParameter("@PaymentID", mThisOrder.PaymentID);
            DB.AddParameter("@DateOfOrder", mThisOrder.DateOfOrder = DateTime.Now.Date);
            DB.AddParameter("@ServiceID", mThisOrder.ServiceID);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@Completed", mThisOrder.Completed);

            DB.Execute("sproc_tblOrders_Update");
        }

        public void ReportByOrderStatus(string OrderStatus)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderStatus", OrderStatus);
            DB.Execute("sproc_tblOrders_FilterByOrderStatus");
            PopulateArray(DB);
        }

        public void ReportByOrderID(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrders_FilterByOrderID");
            PopulateArray(DB);
        }
    }
}