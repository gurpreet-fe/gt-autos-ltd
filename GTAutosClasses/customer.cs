using System;

namespace GTAutosClasses
{
    public class Customer
    {
        private Int32 mCustomerID;
        private DateTime mDateAdded;
        private string mTown;
        private string mPostCode;

        public bool Active { get; set; }
        
        public DateTime DateAdded {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public Int32 AddressNo { get; set; }
        public Int32 CountyNo { get; set; }
        public string HouseNo { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }

        public bool Find(int customerID)
        {
            mCustomerID = 1;
            mDateAdded = Convert.ToDateTime("31/01/1900");
            return true;
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

        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CustomerDOB { get; set; }
        public bool Marketing { get; set; }
    }
}