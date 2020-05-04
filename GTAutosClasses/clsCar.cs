using System;

namespace GTAutosClasses
{
    public class ClsCar
    {
        //------------------------------------------------------PROPERTIES PLUS GET + SET METHODS------------------------------------------------------------------------
        private int mCarID;
        public int CarID
        {
            get
            {
                return mCarID;
            }
            set
            {
                mCarID = value;
            }
        }
        private string mNumberPlate;
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


        //----------------------------------------------------------------FIND METHOD----------------------------------------------------------------------------
        public bool Find(int CarID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarID", CarID);
            DB.Execute("sproc_tblCar_FilterByCarID");
            if (DB.Count == 1)
            {
                mCarID = Convert.ToInt32(DB.DataTable.Rows[0]["CarID"]);
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


        //---------------------------------------------------------VALIDATION METHOD----------------------------------------------------------------------------------
        public string Valid(string numberPlate,
                            string make,
                            string model,
                            string description,
                            string colour,
                            string price)
        {
            String Error = "";
            //------------------------------------NUMBER PLATE-----------------------------
            if (numberPlate.Length == 0)
            {
                Error = Error + "The Number plate of the car may not be blank: ";
            }
            if (numberPlate.Length > 8)
            {
                Error = Error + "The Number plate must be less than 8 characters: ";
            } 
            //------------------------------------MAKE-----------------------------
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
            //----------------------------------PRICE------------------------------
            if (price.Length == 0)
            {
                Error = Error + "The Price of the car may not be blank: ";
            }
            if (price.Length > 10)
            {
                Error = Error + "The Price must be less than 10 characters: ";
            }
            



            //return any error messgaes
            return Error;
        }
       
    }
}