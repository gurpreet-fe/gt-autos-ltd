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
        [TestMethod]
        public void SellerNameNumMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerName = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerNameNumMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerName = ""; // this should be ok
            SellerName = SellerName.PadRight(29, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerNameNumMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerName = ""; // this should be ok
            SellerName = SellerName.PadRight(14, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerNameMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerName = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerNameMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerName = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerNameMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerName = ""; // this should be ok
            SellerName = SellerName.PadRight(28, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerNameMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerName = ""; // this should fail
            SellerName = SellerName.PadRight(30, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerNameExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerName = "";
            SellerName = SellerName.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------SELLER EMAIL PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void SellerEmailNumMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerEmail = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerEmailNumMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerEmail = ""; // this should be ok
            SellerEmail = SellerEmail.PadRight(319, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerEmailNumMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerEmail = ""; // this should be ok
            SellerEmail = SellerEmail.PadRight(159, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerEmailMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerEmail = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerEmailMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerEmail = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerEmailMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerEmail = ""; // this should be ok
            SellerEmail = SellerEmail.PadRight(318, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerEmailMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerEmail = ""; // this should fail
            SellerEmail = SellerEmail.PadRight(320, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerEmailExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerEmail = "";
            SellerEmail = SellerEmail.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------SELLER PHONE NUMBER PARAMETER TEST METHODS (VALID)--------------------------------------------------
        [TestMethod]
        public void SellerPhoneNumMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerPhoneNum = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerPhoneNumMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerPhoneNum = ""; // this should be ok
            SellerPhoneNum = SellerPhoneNum.PadRight(10, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerPhoneNumMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerPhoneNum = ""; // this should be ok
            SellerPhoneNum = SellerPhoneNum.PadRight(5, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerPhoneNumMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerPhoneNum = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerPhoneNumMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerPhoneNum = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerPhoneNumMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerPhoneNum = ""; // this should be ok
            SellerPhoneNum = SellerPhoneNum.PadRight(9, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerPhoneNumMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerPhoneNum = ""; // this should fail
            SellerPhoneNum = SellerPhoneNum.PadRight(11, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerPhoneNumExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerPhoneNum = "";
            SellerPhoneNum = SellerPhoneNum.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------SELLER ADDRESS PARAMETER TEST METHODS (VALID)--------------------------------------------------------
        [TestMethod]
        public void SellerAddressMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerAddress = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerAddressMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerAddress = ""; // this should be ok
            SellerAddress = SellerAddress.PadRight(19, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerAddressMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerAddress = ""; // this should be ok
            SellerAddress = SellerAddress.PadRight(9, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerAddressMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerAddress = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerAddressMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerAddress = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerAddressMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerAddress = ""; // this should be ok
            SellerAddress = SellerAddress.PadRight(18, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerAddressMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerAddress = ""; // this should fail
            SellerAddress = SellerAddress.PadRight(20, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SellerAddressExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String SellerAddress = "";
            SellerAddress = SellerAddress.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------NUMBER PLATE PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void NumberPlateMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; // this should be ok
            NumberPlate = NumberPlate.PadRight(7, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; // this should be ok
            NumberPlate = NumberPlate.PadRight(3, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; // this should be ok
            NumberPlate = NumberPlate.PadRight(6, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = ""; // this should fail
            NumberPlate = NumberPlate.PadRight(8, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberPlateExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String NumberPlate = "";
            NumberPlate = NumberPlate.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------MAKE PARAMETER TEST METHODS (VALID)-----------------------------------------------------------------
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
        public void DescriptionMinLessOne()
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
        [TestMethod]
        public void PriceMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = "0"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; // this should be ok
            Price = Price.PadRight(9, '0');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; // this should be ok
            Price = Price.PadRight(4, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = "00"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; // this should be ok
            Price = Price.PadRight(8, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = ""; // this should fail
            Price = Price.PadRight(10, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //string variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Price = "";
            Price = Price.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------DATE OF PURCHASE PARAMETER TEST METHODS (VALID)-----------------------------------------------------
        [TestMethod]
        public void DateOfPurchaseExtremeMin()
        {
            ClsRequest req = new ClsRequest();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test data data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whateverteh date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfPurchase = TestDate.ToString();
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfPurchaseMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test data data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whateverteh date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string DateOfPurchase = TestDate.ToString();
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfPurchaseMin()
        {
            ClsRequest req = new ClsRequest();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test data data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfPurchase = TestDate.ToString();
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfPurchaseMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfPurchase = TestDate.ToString();
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            Assert.AreNotEqual(Error, "");
        }

        public void DateOfPurchaseExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOfPurchase = TestDate.ToString();
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfPurchaseInvalidData()
        {
            ClsRequest req = new ClsRequest();
            String Error = "";
            string DateOfPurchase = "this is not a date!";
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            Assert.AreNotEqual(Error, "");
        }



        //-----------------------------------------------------------DATE OF REQUEST PARAMETER TEST METHODS (VALID)------------------------------------------------------

        //-----------------------------------------------------------REQUEST PARAMETER TEST METHODS (VALID)--------------------------------------------------------------
        [TestMethod]
        public void RequestMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Request = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RequestMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Request = ""; // this should be ok
            Request = Request.PadRight(4, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RequestMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Request = ""; // this should be ok
            Request = Request.PadRight(1, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RequestMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Request = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RequestMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Request = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RequestMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Request = ""; // this should be ok
            Request = Request.PadRight(3, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RequestMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Request = ""; // this should fail
            Request = Request.PadRight(5, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RequestExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Request = "";
            Request = Request.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //-----------------------------------------------------------PURCHASED PARAMETER TEST METHODS (VALID)----------------------------------------------------------
        [TestMethod]
        public void PurchasedMin()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Purchased = "a"; // this should be ok
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchasedMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Purchased = ""; // this should be ok
            Purchased = Purchased.PadRight(4, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchasedMid()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Purchased = ""; // this should be ok
            Purchased = Purchased.PadRight(1, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchasedMinLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Purchased = ""; //should trigger an error
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchasedMinPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Purchased = "aa"; // this should be ok 
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchasedMaxLessOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Purchased = ""; // this should be ok
            Purchased = Purchased.PadRight(3, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchasedMaxPlusOne()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Purchased = ""; // this should fail
            Purchased = Purchased.PadRight(5, 'a');
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchasedExtremeMax()
        {
            ClsRequest req = new ClsRequest();
            //error variable stores any error messages
            String Error = "";
            //test data to pass to method
            String Purchased = "";
            Purchased = Purchased.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchased, DateOfRequest, Request, Purchased);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
