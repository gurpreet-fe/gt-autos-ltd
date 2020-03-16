using System;

namespace GTAutosClasses
{
    public class clsCustomer
    {
        private Boolean mActive;
        private Int32 mCustomerID;
        private DateTime mDateAdded;
        private String mCustomerPassword;
        private String mAddress;
        private String mPostcode;
        private String mCustomerFirstName;
        private String mCustomerLastName;
        private String mCustomerPhoneNumber;
        private String mCustomerEmail;
        private DateTime mCustomerDOB;
        private Boolean mMarketing;

        public String Valid(string customerFirstName, string customerLastName, string customerPhoneNumber, string customerEmail, string dateAdded, string dateOfBirth, string customerPassword, string address, string postCode)
        {
            String Error = "";
            DateTime DateTemp;
            DateTime TempDOB;

            if (customerFirstName.Length == 0)
            {
                Error = Error + "The first name may not be blank.";
            }
            if(customerFirstName.Length > 20)
            {
                Error = Error + "The first name cannot exceed 20 characters";
            }

            if (customerLastName.Length == 0)
            {
                Error = Error + "The last name may not be blank.";
            }
            if(customerLastName.Length > 20)
            {
                Error = Error + "The last name cannot exceed 20 characters";
            }
            if (customerEmail.Length == 0)
            {
                Error = Error + "The email may not be blank.";
            }
            if(customerEmail.Length > 50)
            {
                Error = Error + "The email cannot exceed 50 characters";
            }
            if(!customerEmail.Contains("@")) 
            {
                Error = Error + "This is not an email address - an email address looks like: 'example@exampledomain.com'";
            }
            if(!customerEmail.Contains(".co.uk") || (!customerEmail.Contains(".com"))) 
            {
                Error = Error + "This is not an email address - an email address looks like: 'example@exampledomain.com'";
            }
            if((customerPhoneNumber.Length != 11) ||(!customerPhoneNumber.StartsWith("0")))
            {
                Error = Error + "This is not a valid telephone number";
            }
            if(address.Length == 0)
            {
                Error = Error + "The address field cannot be left empty";
            }
            if(address.Length > 100)
            {
                Error = Error + "The address field cannot exceed 100 characters";
            }
            if(postCode.Length == 0)
            {
                Error = Error + "The postcode field cannot be left empty";
            }
            if ((postCode.Length != 6) || (postCode.Length != 7) || (postCode.Length != 8))
            {
                Error = Error + "Please enter a valid postcode";
            }
            if(postCode.Length < 8)
            {
                Error = Error + "The postcode cannot be longer than 8 characters (including one space)";
            }

            try
            {
                TempDOB = Convert.ToDateTime(dateOfBirth);
                if(TempDOB < DateTime.Now.AddYears(-17))
                {
                    Error = Error + "You have to be at least 17 years old to use this service";
                }

            }
            catch
            {
                Error = Error + "Please enter a valid date";
            }
            
            try 
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if(DateTemp < DateTime.Now.Date) 
                {
                    Error = Error + "The date cannot be one in the past.";
                }
                if(DateTemp > DateTime.Now.Date) 
                {
                    Error = Error + "The date cannot be one in the future.";
                }
            }
            catch 
            {
                Error = Error + "Please enter a valid date";
            }
           
            return Error;
        }

        public bool Find(int customerID)
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
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
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
                return mPostcode;
            }
            set
            {
                mPostcode = value;
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