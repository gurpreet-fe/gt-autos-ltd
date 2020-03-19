using System;
using System.Collections.Generic;

namespace GTAutosClasses
{
    public class ClsCarCollection
    {
        //private data member for the list
        List<ClsCar> mCarList = new List<ClsCar>();
        //private data memeber thisCar
        ClsCar mThisCar = new ClsCar();
        //public property for the car list
        public List<ClsCar> CarList
        {
            get
            {
                //return the private data
                return mCarList;
            }
            set
            {
                //set the private data
                mCarList = value;
            }
        }
        //public property of count
        public int Count
        {
            get
            {
                //return the count of the list
                return CarList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public ClsCar ThisCar
        {
            get
            {
                //return the private data
                return mThisCar;
            }
            set
            {
                //set the private data
                mThisCar = value;
            }
        }

        public ClsCarCollection()
        {
            //obkect for data connnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCar_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);

        }

            public String Add()
            {
                //adds a new record to the database based  on the values of mThisAddress
                //connect to the database 
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@Make", mThisCar.Make);
                DB.AddParameter("@Model", mThisCar.Model);
                DB.AddParameter("@Colour", mThisCar.Colour);
                DB.AddParameter("@Description", mThisCar.Description);
                DB.AddParameter("@Sold", mThisCar.Sold);
                DB.AddParameter("@Price", mThisCar.Price);
                DB.AddParameter("@OfficeCode", mThisCar.OfficeCode);
                //execute the query returning the primary key value 
                return DB.Execute("sproc_tblCar_Insert");
            }

        
           public void Delete()
        {
            //deletes the record pointed to by thisCar
            //conncet to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameeters for the stored procedure
            DB.AddParameter("@NumberPlate", mThisCar.NumberPlate);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_Delete");
        }

        public void Update()
        {
            //update an exsisting record based on the values of thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@NumberPlate", mThisCar.NumberPlate);
            DB.AddParameter("@Make", mThisCar.Make);
            DB.AddParameter("@Model", mThisCar.Model);
            DB.AddParameter("@Colour", mThisCar.Colour);
            DB.AddParameter("@Description", mThisCar.Description);
            DB.AddParameter("@Sold", mThisCar.Sold);
            DB.AddParameter("@Price", mThisCar.Price);
            DB.AddParameter("@OfficeCode", mThisCar.OfficeCode);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_Update");
        }

        public void ReportByMake(string Make)
        {
            //filters the records based on a make
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Make parameter to the database
            DB.AddParameter("@Make", Make);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_FilterByMake");
            //populat eth earray list woht the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB 
            //var fo the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the privcate array list 
            mCarList = new List<ClsCar>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank car
                ClsCar car = new ClsCar();
                //read the fields form the current record
                car.NumberPlate = Convert.ToString(DB.DataTable.Rows[Index]["NumberPlate"]);
                car.Model = Convert.ToString(DB.DataTable.Rows[Index]["Make"]);
                car.Model = Convert.ToString(DB.DataTable.Rows[Index]["Model"]);
                car.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                car.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                car.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                car.Sold = Convert.ToBoolean(DB.DataTable.Rows[Index]["Sold"]);
                car.OfficeCode = Convert.ToInt32(DB.DataTable.Rows[Index]["OfficeCode"]);
                //add the record to the private data member 
                mCarList.Add(car);
                //point at the next record
                Index++;
            }
        }
    }
}