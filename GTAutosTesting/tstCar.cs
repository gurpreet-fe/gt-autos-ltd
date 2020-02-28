using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstCar
    {

        //good test data
        //create some test data to pass to the method
        String Make = "TestMake";
        String Model = "TestModel";
        String Description = "TestDescription";
        String Colour = "TestColour";
        String Price = 100.00.ToString();
        String Sold = true.ToString();
        String OfficeCode = 1.ToString();

        //test instances
        [TestMethod]
        public void InstanceOk()
        {
            ClsCar car = new ClsCar();
            Assert.IsNotNull(car);
        }

        [TestMethod]
        public void NumberPlatePropertyOK()
        {
            ClsCar car = new ClsCar();
            string TestData = "TestNumberPlate";
            car.NumberPlate = TestData;
            Assert.AreEqual(car.NumberPlate, TestData);
        }

        [TestMethod]
        public void MakePropertyOK()
        {
            ClsCar car = new ClsCar();
            String TestData = "TestMake";
            car.Make = TestData;
            Assert.AreEqual(car.Make, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            ClsCar car = new ClsCar();
            String TestData = "TestModel";
            car.Model = TestData;
            Assert.AreEqual(car.Model, TestData);
        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            ClsCar car = new ClsCar();
            String TestData = "TestColour";
            car.Colour = TestData;
            Assert.AreEqual(car.Colour, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            ClsCar car = new ClsCar();
            String TestData = "TestDescription";
            car.Description = TestData;
            Assert.AreEqual(car.Description, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            ClsCar car = new ClsCar();
            Double TestData = 100.00;
            car.Price = TestData;
            Assert.AreEqual(car.Price, TestData);
        }

        [TestMethod]
        public void SoldPropertyOK()
        {
            ClsCar car = new ClsCar();
            Boolean TestData = true;
            car.Sold = TestData;
            Assert.AreEqual(car.Sold, TestData);
        }

        [TestMethod]
        public void OfficeCodePropertyOK()
        {
            ClsCar car = new ClsCar();
            int TestData = 1;
            car.OfficeCode = TestData;
            Assert.AreEqual(car.OfficeCode, TestData);
        }


        //test find method
        [TestMethod]
        public void FindMethodOK()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestNumberPlateFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            if (car.NumberPlate != "TestNumberPlate")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMakeFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            if (car.Make != "TestMake")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestModelFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            if (car.Model != "TestModel")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            if (car.Colour != "TestColour")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            if (car.Description != "TestDescription")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            if (car.Price != 100.00)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSoldFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            if (car.Sold != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOfficeCodeFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            if (car.OfficeCode != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //valid
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsCar car = new ClsCar();
            String Error = "";
            Error = car.Valid(Make, Model, Description, Colour, Price, Sold, OfficeCode);
            Assert.AreEqual(Error, "");

        }



    }
}