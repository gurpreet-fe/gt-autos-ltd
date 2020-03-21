using System;
using System.Collections.Generic;

namespace GTAutosClasses
{
    public class clsOfficeCollection
    {
        List<OfficeClasses> mOfficeList = new List<OfficeClasses>();
        OfficeClasses mThisOffice = new OfficeClasses();


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

        public OfficeClasses ThisOffice
        {
            get
            {
                return mThisOffice;
            }
            set
            {
                mThisOffice = value;
            }
        }


        public clsOfficeCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOffice_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AddressLine1", mThisOffice.AddressLine1);
            DB.AddParameter("@AddressLine2", mThisOffice.AddressLine2);
            DB.AddParameter("@City", mThisOffice.City);
            DB.AddParameter("@PhoneNumber", mThisOffice.PhoneNumber);
            DB.AddParameter("@PostCode", mThisOffice.PostCode);
            DB.AddParameter("@InspectionDate", mThisOffice.InspectionDate);
            DB.AddParameter("@IsActive", mThisOffice.IsActive);
            return DB.Execute("sproc_tblOffice_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisOffice
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OfficeCode", mThisOffice.OfficeCode);
            DB.Execute("sproc_tblOffice_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OfficeCode", mThisOffice.OfficeCode);
            DB.AddParameter("@AddressLine1", mThisOffice.AddressLine1);
            DB.AddParameter("@AddressLine2", mThisOffice.AddressLine2);
            DB.AddParameter("@City", mThisOffice.City);
            DB.AddParameter("@PostCode", mThisOffice.PostCode);
            DB.AddParameter("@PhoneNumber", mThisOffice.PhoneNumber);
            DB.AddParameter("@InspectionDate", mThisOffice.InspectionDate);
            DB.AddParameter("@IsActive", mThisOffice.IsActive);

            DB.Execute("sproc_tblOffice_Update");
        }

        public void ReportByPostCode(string PostCode)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PostCode", PostCode);
            DB.Execute("sproc_tblOffice_FilterByPostCode");
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOfficeList = new List<OfficeClasses>();
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