using System;

namespace GTAutosClasses
{
    public class clsRequest
    {
        private int mRequestId;
        public int RequestId
        { get
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


        public Boolean Find(int requestID)
        {
            mRequestId = 1;
            mSellerName = "TestName";
            mSellerEmail = "TestEmail";
            mSellerPhoneNum = ;
            mSellerAddress = "TestAddress";
            mNumberPlate = "TestNumberPlate";
            mMake = "TestMake";
            mModel = "TestModel";
            mColour = "TestColour";
            mDescription = "TestDescription";
            mPrice = 100.50;
            mDateOfRequest = Convert.ToDateTime("2/21/2020");
            mDateOfPurchased = Convert.ToDateTime("2/21/2020");
            mPurchased = true;
            mRequest = true;
            return true;
        }
    }
}