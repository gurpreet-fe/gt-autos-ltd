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
        //GO OVER THIS AT THE END
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
            String NumberPlate = "ASDE 1234";
            Found = car.Find(NumberPlate);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestNumberPlateFound()
        {
            clsCar car = new clsCar();
            Boolean Found = false;
            Boolean OK = true;
            String NumberPlate = "ASDE 1234";
            Found = car.Find(NumberPlate);
            if (car.NumberPlate != "ASDF 1234")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
