using System;

namespace GTAutosClasses
{
    public class OfficeClasses
    {

        private Int32 mOfficeCode;
        private Boolean mIsActive;
        private string mAddressLine1;
        private string mAddressLine2;
        private string mPostCode;
        private string mCity;
        private string mPhoneNumber;
        private DateTime mInspectionDate;

        public Int32 OfficeCode
        {
            get
            {
                return mOfficeCode;
            }
            set
            {
                mOfficeCode = value;
            }
        }

        public Boolean IsActive
        {
            get
            {
                return mIsActive;
            }
            set
            {
                mIsActive = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return mAddressLine1;
            }
            set
            {
                mAddressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return mAddressLine2;
            }
            set
            {
                mAddressLine2 = value;
            }
        }

        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }

        public string City
        {
            get
            {
                return mCity;
            }
            set
            {
                mCity = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        public DateTime InspectionDate
        {
            get
            {
                return mInspectionDate;
            }
            set
            {
                mInspectionDate = value;
            }
        }

        //public bool Find(int OfficeCode)
        //{
        //    mOfficeCode = 21;
        //    mInspectionDate = Convert.ToDateTime("19/02/2020");
        //    mAddressLine1 = "Test Street";
        //    mAddressLine2 = "Test Street 2";
        //    mCity = "Test City";
        //    mPostCode = "XXX XXX";
        //    mPhoneNumber = "XXXXXXXXXXX";
        //    mIsActive = true;

        //    return true;

        //}


        public bool Find(int OfficeCode)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OfficeCode", OfficeCode);
            DB.Execute("sproc_tblOffice_FilterByOfficeCode");
            if (DB.Count == 1)
            {
                mOfficeCode = Convert.ToInt32(DB.DataTable.Rows[0]["OfficeCode"]);
                mAddressLine1 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine1"]);
                mAddressLine2 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine2"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mInspectionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["InspectionDate"]);

                return true;
            }
            else
            {
                return false;
            }
        }



    }
}