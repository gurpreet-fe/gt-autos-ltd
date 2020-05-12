using System;

namespace GTAutosClasses
{
    public class clsCustomer
    {

        private Int32 mCustomerID;
        private String mCustomerFirstName;
        private String mCustomerLastName;
        private String mCustomerPhoneNumber;
        private String mAddress;
        private String mCustomerEmail;
        private String mCustomerPassword;
        private String mPostCode;
        private DateTime mCustomerDOB;
        private Boolean mMarketing;
        private DateTime mDateAdded;
        private Boolean mActive;


        public String Valid(string CustomerFirstName, string CustomerLastName, string CustomerPhoneNumber, string Address, 
            string CustomerEmail, string CustomerPassword, string PostCode, string DateOfBirth, string Marketing, string DateAdded, string Active)

        {
            String Error = "";
            DateTime DateTemp;
            DateTime TempDOB;

            if (CustomerFirstName.Length == 0)
            {
                Error += "The first name may not be blank.";
            }
            if(CustomerFirstName.Length > 20)
            {
                Error += "The first name cannot exceed 20 characters";
            }

            if (CustomerLastName.Length == 0)
            {
                Error += "The last name may not be blank.";
            }
            if(CustomerLastName.Length > 20)
            {
                Error += "The last name cannot exceed 20 characters";
            }
            if (CustomerEmail.Length == 0)
            {
                Error += "The email may not be blank.";
            }
            if(CustomerEmail.Length > 50)
            {
                Error += "The email cannot exceed 50 characters";
            }
            if(!CustomerEmail.Contains("@")) 
            {
                Error += "This is not an email address - an email address looks like: 'example@exampledomain.com'";
            }
            if(!CustomerEmail.Contains(".co.uk") || (!CustomerEmail.Contains(".com"))) 
            {
                Error += "This is not an email address - an email address looks like: 'example@exampledomain.com'";
            }
            if((CustomerPhoneNumber.Length != 11) || (!CustomerPhoneNumber.StartsWith("0")) || (!CustomerPhoneNumber.StartsWith("+44")))
            {
                Error += "This is not a valid telephone number";
            }
            if(Address.Length == 0)
            {
                Error += "The address field cannot be left empty";
            }
            if(Address.Length > 100)
            {
                Error += "The address field cannot exceed 100 characters";
            }
            if(PostCode.Length == 0)
            {
                Error += "The postcode field cannot be left empty";
            }
            if ((PostCode.Length != 6) || (PostCode.Length != 7) || (PostCode.Length != 8))
            {
                Error += "Please enter a valid postcode";
            }
            if(PostCode.Length < 8)
            {
                Error += "Please enter a valid postcode";
            }

            try
            {
                TempDOB = Convert.ToDateTime(DateOfBirth);
                if(TempDOB < DateTime.Now.AddYears(-17))
                {
                    Error += "You have to be at least 17 years old to use this service";
                }

            }
            catch
            {
                Error += "Please enter a valid date";
            }
            
            try 
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if(DateTemp < DateTime.Now.Date) 
                {
                    Error += "The date cannot be one in the past.";
                }
                if(DateTemp > DateTime.Now.Date) 
                {
                    Error += "The date cannot be one in the future.";
                }
            }
            catch 
            {
                Error += "Please enter a valid date";
            }
           
            return Error;
        }

        public bool Find(int CustomerID)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if(DB.Count == 1)
            {
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mMarketing = Convert.ToBoolean(DB.DataTable.Rows[0]["OptInMarketing"]);
                //if all criteria matches
                return true;
            }

            else
            {
                return false;
            }
            
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
        public String Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
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
                
}