using System;
using System.Collections.Generic;

namespace GTAutosClasses
{
    public class clsOfficeCollection
    {
        List<OfficeClasses> mOfficeList = new List<OfficeClasses>();

        public List<OfficeClasses> OfficeList
        {
            get
            {
                return mOfficeList;
            }
            set
            {
                mOfficeList = value;
            }
        }

        public int Count
        {
            get
            {
                return OfficeList.Count;
            }
            set
            {
                //worry about this later
            }
        }

        public OfficeClasses ThisOffice { get; set; }

        //public clsOfficeCollection()
        //{
        //    OfficeClasses TestItem = new OfficeClasses();
        //    TestItem.IsActive = true;
        //    TestItem.OfficeCode = 1;
        //    TestItem.InspectionDate = DateTime.Now.Date;
        //    TestItem.AddressLine1 = "Flat 108, Ben Russell Court";
        //    TestItem.AddressLine2 = "25 Grasmere Street";
        //    TestItem.City = "Leicester";
        //    TestItem.PhoneNumber = "07464074954";
        //    TestItem.PhoneNumber = "LE2 7PT";
        //    mOfficeList.Add(TestItem);
        //    TestItem = new OfficeClasses();
        //    TestItem.IsActive = true;
        //    TestItem.OfficeCode = 2;
        //    TestItem.InspectionDate = DateTime.Now.Date;
        //    TestItem.AddressLine1 = "123a";
        //    TestItem.AddressLine2 = "Another Street";
        //    TestItem.City = "Another City";
        //    TestItem.PhoneNumber = "07516231200";
        //    TestItem.PhoneNumber = "T3S TPC";
        //    mOfficeList.Add(TestItem);
        //}

        public clsOfficeCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOffice_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                OfficeClasses AnOffice = new OfficeClasses();
                //read in the fields from the current record
                AnOffice.OfficeCode = Convert.ToInt32(DB.DataTable.Rows[Index]["OfficeCode"]);
                AnOffice.AddressLine1 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine1"]);
                AnOffice.AddressLine2 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine2"]);
                AnOffice.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                AnOffice.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnOffice.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnOffice.InspectionDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["InspectionDate"]);
                AnOffice.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                mOfficeList.Add(AnOffice);
                Index++;
            }
        }






    }

}