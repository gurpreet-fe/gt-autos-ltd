using System;

namespace GTAutosClasses
{
    public class Customer
    {
        private Int32 mCustomerID;
        private DateTime mDateAdded;
        private String mCustomerPassword;
        private Boolean mActive;
        private Int32 mAddressNo;
        private Int32 mCountyNo;
        private String mHouseNo;
        private String mPostcode;
        private String mStreet;
        private String mTown;
        private String mCustomerFirstName;
        private String mCustomerLastName;
        private String mCustomerPhoneNumber;
        private String mCustomerEmail;
        private DateTime mCustomerDOB;
        private Boolean mMarketing;

         public bool Find(int customerID)
         {
            mActive = true;
            mCustomerID = 1;
            mDateAdded = Convert.ToDateTime("12/02/2020");
            mCustomerPassword = "qwertyuiop";
            mActive = true;
            mAddressNo = 21;
            mCountyNo = 21;
            mHouseNo = "1B";
            mPostcode = "AA1 1AA";
            mStreet = "Test Street";
            mTown = "Test Town";
            mCustomerFirstName = "Testy";
            mCustomerLastName = "McTester";
            mCustomerPhoneNumber = "01234567890";
            mCustomerEmail = "testymctester@testemail.com";
            mCustomerDOB = Convert.ToDateTime("01/01/1900");
            mMarketing = false;
            return true;
         }

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }       
        
        public DateTime DateAdded 
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public Int32 AddressNo 
        {
            get
            {
                return mAddressNo;
            }
            set
            {
                mAddressNo = value;
            }
        }

        public Int32 CountyNo
        {
            get
            {
                return mCountyNo;
            }
            set
            {
                mCountyNo = value;
            }
        }

        public string HouseNo
        {
            get
            {
                return mHouseNo;
            }
            set
            {
                mHouseNo = value;
            }
        }

        public string PostCode
        {
            get
            {
                return mPostcode;
            }
            set
            {
                mPostcode = value;
            }
        }
        
        public string Street
        { 
            get
            {
                return mStreet;
            }
            set
            {
                mStreet = value;
            }
        }
        
        public string Town
        {
            get
            {
                return mTown;
            }
            set
            {
                mTown = value;
            }
        }
       

        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public string CustomerFirstName
        { 
            get
            {
                return mCustomerFirstName;
            }
            set
            {
                mCustomerFirstName = value;
            }
        }
        public string CustomerLastName
        {
            get
            {
                return mCustomerLastName;
            }
            set
            {
                mCustomerLastName = value;
            }
        }

        public string CustomerPhoneNumber
        {
            get
            {
                return mCustomerPhoneNumber;
            }
            set
            {
                mCustomerPhoneNumber = value;
            }
        }

        public string CustomerPassword 
        {
            get
            {
                return mCustomerPassword;
            }
            set
            {
                mCustomerPassword = value;
            }
        }

        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }

        public DateTime CustomerDOB
        {
            get
            {
                return mCustomerDOB;
            }
            set
            {
                mCustomerDOB = value;
            }
        }

        public bool Marketing
        {
            get
            {
                return mMarketing;
            }
            set
            {
                mMarketing = value;
            }
        }
                
}