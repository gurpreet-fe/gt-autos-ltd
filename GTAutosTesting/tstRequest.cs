using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstRequest
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsRequest req = new clsRequest();
            int TestData = 0;
            req.RequestId = TestData;
            Assert.AreEqual(req.RequestId, TestData);
        }
        [TestMethod]
        public void SellerNameOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "Jhon Barton";
            req.SellerName = TestData;
            Assert.AreEqual(req.SellerName, TestData);
        }
        [TestMethod]
        public void SellerEmailOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "JhonB@hotmail.com";
            req.SellerEmail = TestData;
            Assert.AreEqual(req.SellerEmail, TestData);
        }
        [TestMethod]
        public void SellerPhoneNumOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "123456789";
            req.SellerPhoneNum = TestData;
            Assert.AreEqual(req.SellerPhoneNum, TestData);
        }
        [TestMethod]
        public void SellerAddressOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "47 Mount Road";
            req.SellerAddress = TestData;
            Assert.AreEqual(req.SellerAddress, TestData);
        }
        [TestMethod]
        public void NumberPlateOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "ABCD 1234";
            req.NumberPlate = TestData;
            Assert.AreEqual(req.NumberPlate, TestData);
        }
        [TestMethod]
        public void MakePropertyOK()
        {
            clsRequest req = new clsRequest();
            String TestData = "Nissan";
            req.Make = TestData;
            Assert.AreEqual(req.Make, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            clsRequest req = new clsRequest();
            String TestData = "micra";
            req.Model = TestData;
            Assert.AreEqual(req.Model, TestData);
        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            clsRequest req = new clsRequest();
            String TestData = "blue";
            req.Colour = TestData;
            Assert.AreEqual(req.Colour, TestData);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            clsRequest req = new clsRequest();
            String TestData = "a four wheeler that is blue and ..";
            req.Description = TestData;
            Assert.AreEqual(req.Description, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsRequest req = new clsRequest();
            Double TestData = 10.00;
            req.Price = TestData;
            Assert.AreEqual(req.Price, TestData);
        }
        [TestMethod]
        public void DateOfRequestOk()
        {
            clsRequest req = new clsRequest();
            DateTime TestData = DateTime.Now.Date;
            req.DateOfRequest = TestData;
            Assert.AreEqual(req.DateOfRequest, TestData);
        }
        [TestMethod]
        public void RequestOk()
        {
            clsRequest req = new clsRequest();
            Boolean TestData = true;
            req.Request = TestData;
            Assert.AreEqual(req.Request, TestData);
        }
        
        [TestMethod]
        public void PurchasedOk()
        {
            clsRequest req = new clsRequest();
            Boolean TestData = true;
            req.Purchased = TestData;
            Assert.AreEqual(req.Purchased, TestData);
        }
        [TestMethod]
        public void DateOfPurchasedOk()
        {
            clsRequest req = new clsRequest();
            DateTime TestData = DateTime.Now.Date;
            req.DateOfPurchased = TestData;
            Assert.AreEqual(req.DateOfPurchased, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsRequest req = new clsRequest();
            Boolean Found = false;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestRequestIDNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestSellerNameNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestSellerEmailNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestSellerPhoneNumNoFound()
        {
            clsRequest req = new clsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.SellerPhoneNum != "1234567891011")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSellerAddressNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestNumberPlateNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestMakeNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestModelNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestColourNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestDescriptionNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestPriceNoFound()
        {
            clsRequest req = new clsRequest();
            Boolean Found = false;
            Boolean OK = true;
            Int32 RequestID = 1;
            Found = req.Find(RequestID);
            if (req.Price != 100.50)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfRequestNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestDateOfPurchasedNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestPurchasedNoFound()
        {
            clsRequest req = new clsRequest();
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
        public void TestRequestNoFound()
        {
            clsRequest req = new clsRequest();
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
    }
}
