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
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mInspectionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["InspectionDate"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string addressLine1, string addressLine2, string city, string postCode, string phoneNumber, string inspectionDate)
        {
            String Error = "";
            DateTime DateTemp;

            //AddressLine1

            if (addressLine1.Length == 0)
            {
                Error = Error + "AddressLine1 may be empty : ";
            }

            if (addressLine1.Length > 60)
            {
                Error = Error + "AddressLine1 must be less than 60 characters : ";
            }

            // AddressLine2

            if (addressLine2.Length == 0)
            {
                Error = Error + "AddressLine2 may be empty : ";
            }

            if (addressLine2.Length > 60)
            {
                Error = Error + "AddressLine2 must be less than 60 characters : ";
            }

            // City

            if (city.Length == 0)
            {
                Error = Error + "The city may not be blank : ";
            }

            if (city.Length > 50)
            {
                Error = Error + "The city must be less than 50 characters : ";
            }

            //InspectionDate

            try
                {

                DateTemp = Convert.ToDateTime(inspectionDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The data cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date entered is invalid : ";
            }

            // PostCode

            try
            {

                if (postCode.Length == 0)
                {
                    Error = Error + "The post code may not be blank : ";
                }

                if (postCode.Length > 9)
                {
                    Error = Error + "The post code must be less than 9 characters : ";
                }
            }
            catch
            {
                Error = Error + "PostCode entered is invalid : ";
            }


            return Error;

        }
    }
}