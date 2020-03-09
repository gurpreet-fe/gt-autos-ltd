using System;
using System.Collections.Generic;

namespace GTAutosClasses
{
    public class ClsCarCollection
    {
        //private data member for the list
        List<ClsCar> mCarList = new List<ClsCar>();
        //public property for the address list
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
        public ClsCar ThisCar { get; set; }

        public ClsCarCollection()
        {
            //var for the index
            Int32 index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblCar_SelectAll");
            //get the count f records
            RecordCount = DB.Count;
            //while there are records to process
            while (index < RecordCount)
            {
                //create a blank car
                ClsCar car = new ClsCar();
                //read in the fields form the current records
                car.NumberPlate = Convert.ToString(DB.DataTable.Rows[0]["NumberPlate"]);
                car.Model = Convert.ToString(DB.DataTable.Rows[0]["Make"]);
                car.Model = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                car.Colour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                car.Description = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                car.Price= Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                car.Sold = Convert.ToBoolean(DB.DataTable.Rows[0]["Sold"]);
                car.OfficeCode = Convert.ToInt32(DB.DataTable.Rows[0]["OfficeCode"]);
                //add teh record ot the private data member
                mCarList.Add(car);
                //point to the next record
                index++;
            }


            ClsCar TestItem = new ClsCar();
            TestItem.NumberPlate = "1234 ABCD";
            TestItem.Make = "Nissan";
            TestItem.Model = "Micra";
            TestItem.Colour = "Blue";
            TestItem.Description = "4 wheeler";
            TestItem.Sold = true;
            TestItem.Price = 100.00;
            TestItem.OfficeCode = 1;
            //add the item to the test list
            mCarList.Add(TestItem);
            // re initalise the object for some new data
            TestItem = new ClsCar();
            TestItem.NumberPlate = "5678 FGHI";
            TestItem.Make = "BMW";
            TestItem.Model = "A5";
            TestItem.Colour = "Green";
            TestItem.Description = "5 wheeler";
            TestItem.Sold = false;
            TestItem.Price = 1000.00;
            TestItem.OfficeCode = 2;
            //add the item to the list
            mCarList.Add(TestItem);

        }
        
    }
}