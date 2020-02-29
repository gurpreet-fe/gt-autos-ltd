using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class TstRequest
    {
        //-----------------------------------------------------TEST DATA TO PASS TO THE METHOD------------------------------------------------------------------
        string SellerName = "TestName";
        string SellerEmail = "TestEmail";
        string SellerPhoneNum = "TestPhoneNum";
        string SellerAddress = "TestAddress";
        string NumberPlate = "TestNumberPlate";
        string Make = "TestMake";
        string Model = "TestModel";
        string Colour = "TestColour";
        string Description = "TestDescription";
        string Price = 100.00.ToString();
        string DateOfPurchased = DateTime.Now.Date.ToString();
        string DateOfRequest = DateTime.Now.Date.ToString();
        string Purchased = true.ToString();
        string Request = true.ToString();

        //---------------------------------------------------TESTING INSTANCE OF CLASS + PROPERTIES--------------------------------------------------------------
        [TestMethod]
        public void InstanceOK()
        {
            ClsRequest req = new ClsRequest();
            int TestData = 0;
            req.RequestId = TestData;
            Assert.AreEqual(req.RequestId, TestData);
        }
        [TestMethod]
        public void SellerNameOK()
        {
            ClsRequest req = new ClsRequest();
            String TestData = "TestName";
            req.SellerName = TestData;
            Assert.AreEqual(req.SellerName, TestData);
        }
        [TestMethod]
        public void SellerEmailOK()
        {
            ClsRequest req = new ClsRequest();
            String TestData = "TestEmail";
            req.SellerEmail = TestData;
            Assert.AreEqual(req.SellerEmail, TestData);
        }
        [TestMethod]
        public void SellerPhoneNumOK()
        {
            ClsRequest req = new ClsRequest();
            String TestData = "TestPhoneNum";
            req.SellerPhoneNum = TestData;
            Assert.AreEqual(req.SellerPhoneNum, TestData);
        }
        [TestMethod]
        public void SellerAddressOK()
        {
            ClsRequest req = new ClsRequest();
            String TestData = "TestAddress";
            req.SellerAddress = TestData;
            Assert.AreEqual(req.SellerAddress, TestData);
        }
        [TestMethod]
        public void NumberPlateOK()
        {
            ClsRequest req = new ClsRequest();
            String TestData = "TestNumberPlate";
            req.NumberPlate = TestData;
            Assert.AreEqual(req.NumberPlate, TestData);
        }
        [TestMethod]
        public void MakePropertyOK()
        {
            ClsRequest req = new ClsRequest();
            String TestData = "TestMake";
            req.Make = TestData;
            Assert.AreEqual(req.Make, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            ClsRequest req = new ClsRequest();
            String TestData = "TestModel";
            req.Model = TestData;
            Assert.AreEqual(req.Model, TestData);
        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            ClsRequest req = new ClsRequest();
            String TestData = "TestColour";
            req.Colour = TestData;
            Assert.AreEqual(req.Colour, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            ClsRequest req = new ClsRequest();
            String TestData = "TestDescription";
            req.Description = TestData;
            Assert.AreEqual(req.Description, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            ClsRequest req = new ClsRequest();
            Double TestData = 100.00;
            req.Price = TestData;
            Assert.AreEqual(req.Price, TestData);
        }
        [TestMethod]
        public void DateOfRequestOK()
        {
            ClsRequest req = new ClsRequest();
            DateTime TestData = DateTime.Now.Date;
            req.DateOfRequest = TestData;
            Assert.AreEqual(req.DateOfRequest, TestData);
        }
        [TestMethod]
        public void RequestOK()
        {
            ClsRequest req = new ClsRequest();
            Boolean TestData = true;
            req.Request = TestData;
            Assert.AreEqual(req.Request, TestData);
        }
        
        [TestMethod]
        public void PurchasedOK()
        {
            ClsRequest req = new ClsRequest();
            Boolean TestData = true;
            req.Purchased = TestData;
            Assert.AreEqual(req.Purchased, TestData);
        }
        [TestMethod]
        public void DateOfPurchasedOK()
        {
            ClsRequest req = new ClsRequest();
            DateTime TestData = DateTime.Now.Date;
            req.DateOfPurchased = TestData;
            Assert.AreEqual(req.DateOfPurchased, TestData);
        }

        //----------------------------------------------TESTING FIND METHOD FOR EACH PROPERTY-------------------------------------------------------------------
        [TestMethod]
        public void FindMethodOK()
        {
            ClsRequest req = new ClsRequest();
            Int32 RequestID = 1;
            Boolean Found = req.Find(RequestID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestRequestIDFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.RequestId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSellerNameFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.SellerName != "TestName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSellerEmailFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.SellerEmail != "TestEmail")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSellerPhoneNumFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.SellerPhoneNum != "TestPhoneNum")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSellerAddressFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.SellerAddress != "TestAddress")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNumberPlateFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.NumberPlate != "TestNumberPlate")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMakeFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.Make != "TestMake")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestModelFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.Model != "TestModel")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.Colour != "TestColour")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.Description != "TestDescription")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.Price != 100.00)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfRequestFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.DateOfRequest != Convert.ToDateTime("2/21/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfPurchasedFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.DateOfPurchased != Convert.ToDateTime("2/21/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPurchasedFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.Purchased != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRequestFound()
        {
            ClsRequest req = new ClsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.Request != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        // ------------------------------------------------------------VALIDATION TESTING-------------------------------------------------------------------------------
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsRequest req = new ClsRequest();
            String Error = "";
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Colour, Description, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            Assert.AreEqual(Error, "");
        }

        //-----------------------------------------------------------SELLER NAME PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        //-----------------------------------------------------------SELLER EMAIL PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        //-----------------------------------------------------------SELLER PHONE NUMBER PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        //-----------------------------------------------------------SELLER ADDRESS PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        //-----------------------------------------------------------NUMBER PLATE PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        //-----------------------------------------------------------MAKE PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void MakeMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; // this should be ok
            Make = Make.PadRight(19, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; // this should be ok
            Make = Make.PadRight(9, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; // this should be ok
            Make = Make.PadRight(18, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = ""; // this should fail
            Make = Make.PadRight(20, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MakeExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Make = "";
            Make = Make.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------MODEL PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void ModelMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; // this should be ok
            Model = Model.PadRight(19, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; // this should be ok
            Model = Model.PadRight(9, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; // this should be ok
            Model = Model.PadRight(18, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = ""; // this should fail
            Model = Model.PadRight(20, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Model = "";
            Model = Model.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------COLOUR PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void ColourMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; // this should be ok
            Colour = Colour.PadRight(19, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; // this should be ok
            Colour = Colour.PadRight(9, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; // this should be ok
            Colour = Colour.PadRight(18, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = ""; // this should fail
            Colour = Colour.PadRight(20, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Colour = "";
            Colour = Colour.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------DESCRIPTION PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void DescriptionMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; // this should be ok
            Description = Description.PadRight(199, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; // this should be ok
            Description = Description.PadRight(99, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; // this should be ok
            Description = Description.PadRight(198, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = ""; // this should fail
            Description = Description.PadRight(200, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Description = "";
            Description = Description.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------PRICE PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        //-----------------------------------------------------------DATE OF PURCHASE PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        //-----------------------------------------------------------DATE OF REQUEST PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        //-----------------------------------------------------------REQUEST PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        //-----------------------------------------------------------PURCHASED PARAMETER TEST METHODS (VALID)----------------------------------------------------------
    }
}
