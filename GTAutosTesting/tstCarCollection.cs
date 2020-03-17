using System;
using System.Collections.Generic;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstCarCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsCarCollection AllCars = new ClsCarCollection();
            Assert.IsNotNull(AllCars);
        }

        [TestMethod]
        public void CarListOK()
        {
            ClsCarCollection AllCars = new ClsCarCollection();
            //create some test data to asign to the property 
            //in this cas the data needs to be a list of objects
            List<ClsCar> TestList = new List<ClsCar>();
            //add an item to the list 
            //create the item of test data
            ClsCar TestItem = new ClsCar();
            //set its properties
            TestItem.NumberPlate = "1234 ABCD";
            TestItem.Make = "Nissan";
            TestItem.Model = "Micra";
            TestItem.Colour = "Blue";
            TestItem.Description = "4 wheeler";
            TestItem.Sold = true;
            TestItem.Price = 100.00;
            TestItem.OfficeCode = 1;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            Assert.AreEqual(AllCars.CarList, TestList);

        }

     

        [TestMethod]
        public void ThisCarPropertyOK()
        {
            ClsCarCollection AllCars = new ClsCarCollection();
            //create some test data to assign to the property 
            ClsCar TestCar = new ClsCar();
            //set its properties
            TestCar.NumberPlate = "1234 ABCD";
            TestCar.Make = "Nissan";
            TestCar.Model = "Micra";
            TestCar.Colour = "Blue";
            TestCar.Description = "4 wheeler";
            TestCar.Sold = true;
            TestCar.Price = 100.00;
            TestCar.OfficeCode = 1;
            //assign the data to the property 
            AllCars.ThisCar = TestCar;
            Assert.AreEqual(AllCars.ThisCar, TestCar);
        }

        [TestMethod]
        public void ListAndCountOK()

        {
            ClsCarCollection AllCars = new ClsCarCollection();
            //create some test data to asign to the property 
            //in this cas the data needs to be a list of objects
            List<ClsCar> TestList = new List<ClsCar>();
            //add an item to the list 
            //create the item of test data
            ClsCar TestItem = new ClsCar();
            //set its properties
            TestItem.NumberPlate = "1234 ABCD";
            TestItem.Make = "Nissan";
            TestItem.Model = "Micra";
            TestItem.Colour = "Blue";
            TestItem.Description = "4 wheeler";
            TestItem.Sold = true;
            TestItem.Price = 100.00;
            TestItem.OfficeCode = 1;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the calss we want to create 
            ClsCarCollection AllCars = new ClsCarCollection();
            //create the item of test data
            ClsCar TestItem = new ClsCar();
            String PrimaryKey = "1234 ABCD";
            //set its propertiers
            TestItem.Make = "Nissan";
            TestItem.Model = "Micra";
            TestItem.Colour = "Blue";
            TestItem.Description = "4 wheeler";
            TestItem.Sold = true;
            TestItem.Price = 100.00;
            TestItem.OfficeCode = 1;
            //set ThisAddress to the test data
            AllCars.ThisCar = TestItem;
            //add the record
     //       PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.NumberPlate = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllCars.ThisCar, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the calss we want to create 
            ClsCarCollection AllCars = new ClsCarCollection();
            //create the item of test data
            ClsCar TestItem = new ClsCar();
            String PrimaryKey = "1234 ABCD";
            //set its propertiers
            TestItem.Make = "Nissan";
            TestItem.Model = "Micra";
            TestItem.Colour = "Blue";
            TestItem.Description = "4 wheeler";
            TestItem.Sold = true;
            TestItem.Price = 100.00;
            TestItem.OfficeCode = 1;
            //set ThisAddress to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            //       PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.NumberPlate = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //delete the record
            AllCars.Delete();
            //now find the record
            Boolean Found = AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the calss we want to create 
            ClsCarCollection AllCars = new ClsCarCollection();
            //create the item of test data
            ClsCar TestItem = new ClsCar();
            String PrimaryKey = "1234 ABCD";
            //set its propertiers
            TestItem.Make = "Nissan";
            TestItem.Model = "Micra";
            TestItem.Colour = "Blue";
            TestItem.Description = "4 wheeler";
            TestItem.Sold = true;
            TestItem.Price = 100.00;
            TestItem.OfficeCode = 1;
            //set ThisAddress to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            //       PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.NumberPlate = PrimaryKey;
            //modify the test data
            TestItem.Make = "BMW";
            TestItem.Model = "A5";
            TestItem.Colour = "Green";
            TestItem.Description = "2 wheeler";
            TestItem.Sold = false;
            TestItem.Price = 200.00;
            TestItem.OfficeCode = 2;
            //set the record based on the new data
            AllCars.ThisCar = TestItem;
            //update the record
            AllCars.Update();
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see ThisCar matches the test data
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void ReportByMakeMethodOK()
        {
            //creat an instance of the class containing the unfiltered results
            ClsCarCollection AllCars = new ClsCarCollection();
            //create an instacne of the filtered data 
            ClsCarCollection FilteredCars = new ClsCarCollection();
            //apply a blank string (should return all the records)
            FilteredCars.ReportByMake("");
            //test to see that the 2 values are the same 
            Assert.AreEqual(AllCars.Count, FilteredCars.Count);
        }

        [TestMethod]
        public void ReportByMakeNoneFound()
        {
            //create an instacne of the filtered data
            ClsCarCollection FilteredCars = new ClsCarCollection();
            //apply a make that does not exsist
            FilteredCars.ReportByMake("XXXXXX");
            //test to see that there are no records 
            Assert.AreEqual(0, FilteredCars.Count);
        }

        [TestMethod]
        public void ReportByMakeTestDataFound()
        {
            //create an instacne of the filterd data 
            ClsCarCollection FilteredCars = new ClsCarCollection();
            //var to store the outcome 
            Boolean OK = true;
            //apply a make that doesnt exsist 
            FilteredCars.ReportByMake("XXXXXXX");
            //check that the correct number of records are found 1
            if (FilteredCars.Count == 1)
            {

            }
        }

        
    }
}
