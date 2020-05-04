using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstCar
    {


        //-----------------------------------------------------TEST DATA TO PASS TO THE METHOD------------------------------------------------------------------
        String CarID = 0.ToString();
        String NumberPlate = "1234 ABCD";
        String Make = "Nissan";
        String Model = "Micra";
        String Description = "TestDescription";
        String Colour = "Blue";
        String Price = 200.ToString();
        String Sold = true.ToString();
        String OfficeCode = 2.ToString();

        //---------------------------------------------------TESTING INSTANCE OF CLASS + PROPERTIES--------------------------------------------------------------
        [TestMethod]
        public void InstanceOk()
        {
            ClsCar car = new ClsCar();
            Assert.IsNotNull(car);
        }

        [TestMethod]
        public void CarIDPropertyOK()
        {
            ClsCar car = new ClsCar();
            int TestData = 0;
            car.CarID = TestData;
            Assert.AreEqual(car.CarID, TestData);
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


        //----------------------------------------------TESTING FIND METHOD FOR EACH PROPERTY-------------------------------------------------------------------
        [TestMethod]
        public void FindMethodOK()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Int32 CarID = 0;
            Found = car.Find(CarID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCarIDFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarID = 0;
            Found = car.Find(CarID);
            if (car.CarID != 0)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNumberPlateFound()
        {
            ClsCar car = new ClsCar();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarID = 0;
            Found = car.Find(CarID);
            if (car.NumberPlate != "MP04TTX")
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
            Int32 CarID = 0;
            Found = car.Find(CarID);
            if (car.Make != "Test")
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
            Int32 CarID = 0;
            Found = car.Find(CarID);
            if (car.Model != "A3")
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
            Int32 CarID = 0;
            Found = car.Find(CarID);
            if (car.Colour != "Silver")
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
            Int32 CarID = 0;
            Found = car.Find(CarID);
            if (car.Description != "Good Condition")
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
            Int32 CarID = 0;
            Found = car.Find(CarID);
            if (car.Price != 5000)
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
            Int32 CarID = 0;
            Found = car.Find(CarID);
            if (car.Sold != false)
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
            Int32 CarID = 0;
            Found = car.Find(CarID);
            if (car.OfficeCode != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

       // ------------------------------------------------------------VALIDATION TESTING-------------------------------------------------------------------------------
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsCar car = new ClsCar();
            String Error = "";
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            Assert.AreEqual(Error, "");

        }

        //--------------------------------------------------------NUMBER PLATE PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void NumberPlateMin()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = "a"; // this should be ok
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; // this should be ok
            NumberPlate = NumberPlate.PadRight(8, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMid()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; // this should be ok
            NumberPlate = NumberPlate.PadRight(4, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMinLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; //should trigger an error
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMinPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = "aa"; // this should be ok 
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMaxLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; // this should be ok
            NumberPlate = NumberPlate.PadRight(7, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMaxPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; // this should fail
            NumberPlate = NumberPlate.PadRight(9, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateExtremeMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = "";
            NumberPlate = NumberPlate.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------MAKE PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void MakeMin()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = "a"; // this should be ok
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; // this should be ok
            Make = Make.PadRight(20, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMid()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; // this should be ok
            Make = Make.PadRight(10, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMinLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; //should trigger an error
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeMinPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = "aa"; // this should be ok 
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMaxLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; // this should be ok
            Make = Make.PadRight(19, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MakeMaxPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; // this should fail
            Make = Make.PadRight(21, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeExtremeMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = "";
            Make = Make.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //-----------------------------------------------------------MODEL PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void ModelMin()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = "a"; // this should be ok
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; // this should be ok
            Model = Model.PadRight(20, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMid()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; // this should be ok
            Model = Model.PadRight(10, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMinLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; //should trigger an error
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMinPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = "aa"; // this should be ok 
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; // this should be ok
            Model = Model.PadRight(19, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; // this should fail
            Model = Model.PadRight(21, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelExtremeMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = "";
            Model = Model.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //--------------------------------------------------DESCRIPTION PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void DescriptionMin()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = "a"; // this should be ok
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; // this should be ok
            Description = Description.PadRight(200, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; // this should be ok
            Description = Description.PadRight(100, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; //should trigger an error
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = "aa"; // this should be ok 
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; // this should be ok
            Description = Description.PadRight(199, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; // this should fail
            Description = Description.PadRight(201, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = "";
            Description = Description.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //----------------------------------------------------COLOUR PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void ColourMin()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = "a"; // this should be ok
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; // this should be ok
            Colour = Colour.PadRight(20, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMid()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; // this should be ok
            Colour = Colour.PadRight(10, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; //should trigger an error
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = "aa"; // this should be ok 
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; // this should be ok
            Colour = Colour.PadRight(19, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; // this should fail
            Colour = Colour.PadRight(21, 'a');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourExtremeMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = "";
            Colour = Colour.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //----------------------------------------------------PRICE PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void PriceMin()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = "0"; // this should be ok
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; // this should be ok
            Price = Price.PadRight(10, '0');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; // this should be ok
            Price = Price.PadRight(5, '0');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; //should trigger an error
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = "00"; // this should be ok 
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; // this should be ok
            Price = Price.PadRight(9, '0');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; // this should fail
            Price = Price.PadRight(11, '0');
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            ClsCar car = new ClsCar();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = "";
            Price = Price.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = car.Valid(NumberPlate, Make, Model, Description, Colour, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        


    }




}
