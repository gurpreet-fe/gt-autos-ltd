using System;
using System.Collections.Generic;

namespace GTAutosClasses
{
    public class ClsServiceCollection
    {
        List<ClsService> mServiceList =  new List<ClsService>();
        ClsService mThisService = new ClsService();
        

        public ClsServiceCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblService_SelectAll");
            PopulateArray(DB);


        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            mServiceList = new List<ClsService>();
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                ClsService AnService = new ClsService();
                AnService.ServiceID = Convert.ToInt32(DB.DataTable.Rows[Index]["ServiceID"]);
                AnService.ServiceName = Convert.ToString(DB.DataTable.Rows[Index]["ServiceName"]);
                AnService.ServicePrice = Convert.ToDouble(DB.DataTable.Rows[Index]["ServicePrice"]);
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
        public ClsService ThisService
        {
            get
            {
                return mThisService;
            }
            set
            {
                mThisService = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ServiceName", mThisService.ServiceName);
            DB.AddParameter("@ServiceDesc", mThisService.ServiceDescription);
            DB.AddParameter("@ServicePrice", mThisService.ServicePrice);
            return DB.Execute("sproc_tblService_InsertService");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ServiceID", mThisService.ServiceID);
            DB.Execute("sproc_tblServices_Delete");
        }
    }
}