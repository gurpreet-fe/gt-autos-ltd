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

        
    }
}
