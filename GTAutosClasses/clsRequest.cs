using System;

namespace GTAutosClasses
{
    public class ClsRequest
    {
        //------------------------------------------------------PROPERTIES PLUS GET + SET METHODS------------------------------------------------------------------------
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

        //----------------------------------------------------------------FIND METHOD----------------------------------------------------------------------------
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

        //---------------------------------------------------------VALIDATION METHOD----------------------------------------------------------------------------------
        public string Valid(string sellerName, 
                            string sellerEmail, 
                            string sellerPhoneNum, 
                            string sellerAddress, 
                            string numberPlate, 
                            string make, 
                            string model, 
                            string colour, 
                            string description, 
                            string price, 
                            string dateOfPurchased, 
                            string dateOfRequest, 
                            string request,
                            string purchased)
        {
            String Error = "";
            //------------------------------------SELLER NAME---------------------------------
            if (sellerName.Length == 0)
            {
                Error = Error + "The Name of the seller may not be blank: ";
            }
            if (sellerName.Length > 30)
            {
                Error = Error + "The Name must be less than 30 characters: ";
            }
            //------------------------------------SELLER EMAIL--------------------------------
            if (sellerPhoneNum.Length == 0)
            {
                Error = Error + "The Email of the seller may not be blank: ";
            }
            if (sellerPhoneNum.Length > 320)
            {
                Error = Error + "The Email must be less than 320 characters: ";
            }
            //------------------------------------SELLER PHONE NUMBER-------------------------
            if (sellerPhoneNum.Length == 0)
            {
                Error = Error + "The Phone Number of the seller may not be blank: ";
            }
            if (sellerPhoneNum.Length != 11)
            {
                Error = Error + "The Phone Number must be 11 characters: ";
            }
            //------------------------------------SELLER ADDRESS------------------------------
            if (sellerAddress.Length == 0)
            {
                Error = Error + "The Address of the seller may not be blank: ";
            }
            if (sellerAddress.Length > 20)
            {
                Error = Error + "The Address must be less than 20 characters: ";
            }
            //------------------------------------NUMBER PLATE-------------------------------- 
            if (numberPlate.Length == 0)
            {
                Error = Error + "The Number Plate of the car may not be blank: ";
            }
            if (numberPlate.Length != 8)
            {
                Error = Error + "The Number Plate must be 8 characters: ";
            }
            //------------------------------------MAKE----------------------------------------
            if (make.Length == 0)
            {
                Error = Error + "The Make of the car may not be blank: ";
            }
            if (make.Length > 20)
            {
                Error = Error + "The Make must be less than 20 characters: ";
            }

            //----------------------------------MODEL------------------------------
            if (model.Length == 0)
            {
                Error = Error + "The Model of the car may not be blank: ";
            }
            if (model.Length > 20)
            {
                Error = Error + "The Model must be less than 20 characters: ";
            }

            //----------------------------------DESCRIPTION------------------------------
            if (description.Length == 0)
            {
                Error = Error + "The Description of the car may not be blank: ";
            }
            if (description.Length > 200)
            {
                Error = Error + "The Description must be less than 200 characters: ";
            }

            //----------------------------------COLOUR------------------------------
            if (colour.Length == 0)
            {
                Error = Error + "The Colour of the car may not be blank: ";
            }
            if (colour.Length > 20)
            {
                Error = Error + "The Colour must be less than 20 characters: ";
            }
            //------------------------------------PRICE---------------------------------------
            //------------------------------------DATE OF PURCHASE----------------------------
            //------------------------------------DATE OF REQUEST-----------------------------
            //------------------------------------REQUEST-------------------------------------
            //------------------------------------PURCHASED ----------------------------------

            //return any error messgaes
            return Error;
        }
    }
}
