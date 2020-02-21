using System;

namespace GTAutosClasses
{
    public class clsCar
    {
        private String mNumberPlate;
        public string NumberPlate
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
        private string mMake;
        public string Make
        { get
            {
                return mMake;
            }

         set
            {
                mMake = value;
            }
        }

        private string mModel;
        public string Model
        { get
            {
                return mModel;
            }
            set
            {
                mModel = value;
            }
        }

        private string mColour;
        public string Colour
        { get
            {
                return mColour;
            }
            set
            {
                mColour = value;
            }
        }

    
        private string mDescription;
        public string Description
        { get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }

        private double mPrice;
        public double Price
        { get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        private Boolean mSold;
        public Boolean Sold
        { get
            {
                return mSold;
            }
            set
            {
                mSold = value;
            }
        }


        private int mOfficeCode;
        public int OfficeCode
        { get
            {
                return mOfficeCode;
            }
            set
            {
                mOfficeCode = value;
            }
        }

        public bool Find(string numberPlate)
        {
            mNumberPlate = "ASDE 1234";
            return true;
        }
    }
}