using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstCar
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCar car = new clsCar();
            Assert.IsNotNull(car);
        }
        
        [TestMethod]
        public void NumberPlatePropertyOK()
        {
            clsCar car = new clsCar();
            string TestData = "ABCD 1234";
            car.NumberPlate = TestData;
            Assert.AreEqual(car.NumberPlate, TestData);
        }

        [TestMethod]
        public void MakePropertyOK()
        {
            clsCar car = new clsCar();
            String TestData = "Nissan";
            car.Make = TestData;
            Assert.AreEqual(car.Make, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            clsCar car = new clsCar();
            String TestData = "micra";
            car.Model = TestData;
            Assert.AreEqual(car.Model, TestData);
        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            clsCar car = new clsCar();
            String TestData = "blue";
            car.Colour = TestData;
            Assert.AreEqual(car.Colour, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            clsCar car = new clsCar();
            String TestData = "a four wheeler that is blue and ..";
            car.Description = TestData;
            Assert.AreEqual(car.Description, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsCar car = new clsCar();
            Double TestData = 10.00;
            car.Price = TestData;
            Assert.AreEqual(car.Price, TestData);
        }

        [TestMethod]
        public void SoldPropertyOK()
        {
            clsCar car = new clsCar();
            Boolean TestData = true;
            car.Sold = TestData;
            Assert.AreEqual(car.Sold, TestData);
        }

        [TestMethod]
        public void OfficeCodePropertyOK()
        {
            clsCar car = new clsCar();
            int TestData = 0;
            car.OfficeCode = TestData;
            Assert.AreEqual(car.OfficeCode, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCar car = new clsCar();
            Boolean Found = false;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestNumberPlateNoFound()
        {
            clsCar car = new clsCar();
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
        public void TestMakeNoFound()
        {
            clsCar car = new clsCar();
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
        public void TestModelNoFound()
        {
            clsCar car = new clsCar();
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
        public void TestColourNoFound()
        {
            clsCar car = new clsCar();
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
        public void TestDescriptionNoFound()
        {
            clsCar car = new clsCar();
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
        public void TestPriceNoFound()
        {
            clsCar car = new clsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "TestNumberPlate";
            Found = car.Find(NumberPlate);
            if (car.Price != 100.50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSoldNoFound()
        {
            clsCar car = new clsCar();
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
        public void TestOfficeCodeNoFound()
        {
            clsCar car = new clsCar();
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



    }
}
