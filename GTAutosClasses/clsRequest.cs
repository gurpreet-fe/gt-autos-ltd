using System;

namespace GTAutosClasses
{
    public class ClsRequest
    {
        private int mRequestId;
        public int RequestId
        {
            get
            {
                return mRequestId;

            }
            set
            {
                mRequestId = value;
            }
        }

        private String mSellerName;
        public String SellerName
        {
            get
            {
                return mSellerName;

            }
            set
            {
                mSellerName = value;
            }
        }

        private String mSellerEmail;
        public String SellerEmail
        {
            get
            {
                return mSellerEmail;

            }
            set
            {
                mSellerEmail = value;
            }
        }

        private String mSellerPhoneNum;
        public String SellerPhoneNum
        {
            get
            {
                return mSellerPhoneNum;

            }
            set
            {
                mSellerPhoneNum = value;
            }
        }

        private String mSellerAddress;
        public String SellerAddress
        {
            get
            {
                return mSellerAddress;

            }
            set
            {
                mSellerAddress = value;
            }
        }

        private String mNumberPlate;
        public String NumberPlate
        {
            get
            {
                return mNumberPlate;

            }
            set
            {
                mNumberPlate = value;
            }
        }

        private String mMake;
        public String Make
        {
            get
            {
                return mMake;

            }
            set
            {
                mMake = value;
            }
        }

        private String mModel;
        public String Model
        {
            get
            {
                return mModel;

            }
            set
            {
                mModel = value;
            }
        }

        private String mColour;
        public String Colour
        {
            get
            {
                return mColour;

            }
            set
            {
                mColour = value;
            }
        }

        private String mDescription;
        public String Description
        {
            get
            {
                return mDescription;

            }
            set
            {
                mDescription = value;
            }
        }
        private Double mPrice;
        public double Price
        {
            get
            {
                return mPrice;

            }
            set
            {
                mPrice = value;
            }
        }

        private DateTime mDateOfRequest;
        public DateTime DateOfRequest
        {
            get
            {
                return mDateOfRequest;

            }
            set
            {
                mDateOfRequest = value;
            }
        }

        private DateTime mDateOfPurchased;
        public DateTime DateOfPurchased
        {
            get
            {
                return mDateOfPurchased;

            }
            set
            {
                mDateOfPurchased = value;
            }
        }
        private Boolean mPurchased;
        public Boolean Purchased
        {
            get
            {
                return mPurchased;

            }
            set
            {
                mPurchased = value;
            }
        }
        private Boolean mRequest;
        public Boolean Request
        {
            get
            {
                return mRequest;

            }
            set
            {
                mRequest = value;
            }
        }

        //find method
        public bool Find(Int32 RequestId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@RequestId", RequestId);
            DB.Execute("sproc_tblRequest_FilterByRequestId");
            if (DB.Count == 1)
            {
                mRequestId = Convert.ToInt32(DB.DataTable.Rows[0]["RequestId"]);
                mSellerName = Convert.ToString(DB.DataTable.Rows[0]["SellerName"]);
                mSellerEmail = Convert.ToString(DB.DataTable.Rows[0]["SellerEmail"]);
                mSellerPhoneNum = Convert.ToString(DB.DataTable.Rows[0]["SellerPhoneNum"]); ;
                mSellerAddress = Convert.ToString(DB.DataTable.Rows[0]["SellerAddress"]);
                mNumberPlate = Convert.ToString(DB.DataTable.Rows[0]["NumberPlate"]);
                mMake = Convert.ToString(DB.DataTable.Rows[0]["Make"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mDateOfRequest = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfRequest"]);
                mDateOfPurchased = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfPurchased"]);
                mPurchased = Convert.ToBoolean(DB.DataTable.Rows[0]["Purchased"]);
                mRequest = Convert.ToBoolean(DB.DataTable.Rows[0]["Request"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        //validation
        public string Valid(string sellerName, string sellerEmail, string sellerPhoneNum, string sellerAddress, string numberPlate, string make, string model, string colour, string description, string price, string dateOfPurchased, string dateOfRequest, string request)
        {
            return "";
        }
    }
}
