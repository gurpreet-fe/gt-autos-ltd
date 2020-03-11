﻿using System;
using System.Collections.Generic;

namespace GTAutosClasses
{
    public class ClsServiceCollection
    {
        List<ClsService> mServiceList =  new List<ClsService>();
        

        public ClsServiceCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblService_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //ClsOrder AnOrder = new ClsOrder();
                ClsService AnService = new ClsService();
                /*AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.CarID = Convert.ToString(DB.DataTable.Rows[Index]["NumberPlate"]);
                AnOrder.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                AnOrder.DateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfOrder"]);*/
                AnService.ServiceID = Convert.ToString(DB.DataTable.Rows[Index]["ServiceID"]);
                AnService.ServicePrice = Convert.ToDouble(DB.DataTable.Rows[Index]["ServicePrice"]);
                /*AnOrder.OrderPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["OrderPrice"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.Completed = Convert.ToBoolean(DB.DataTable.Rows[Index]["Completed"]);*/
                mServiceList.Add(AnService);
                Index++;
            }
        }
    

        
        public List<ClsService> ServiceList
        {
            get
            {
                return mServiceList;
            }
            set
            {
                mServiceList = value;
            }
        }
        public int Count
        {
            get
            {
                return mServiceList.Count;
            }
            set
            {

            }
        }
        public ClsService ThisService { get; set; }
    }
}