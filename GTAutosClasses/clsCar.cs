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

        public bool Find(string NumberPlate)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@NumberPlate", NumberPlate);
            DB.Execute("sproc_tblCar_FilterByNumberPlate");
            if (DB.Count == 1)
            {
                mNumberPlate = Convert.ToString(DB.DataTable.Rows[0]["NumberPlate"]);
                mMake = Convert.ToString(DB.DataTable.Rows[0]["Make"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mSold = Convert.ToBoolean(DB.DataTable.Rows[0]["Sold"]);
                mOfficeCode = Convert.ToInt32(DB.DataTable.Rows[0]["OfficeCode"]);

                return true;

            }
            else
            {
                return false;
            }
        }
    }
}