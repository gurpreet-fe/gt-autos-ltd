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
        public void SellerNameOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "Jhon Barton";
            req.SellerName = TestData;
            Assert.AreEqual(req.SellerName, TestData);
        }
        public void SellerEmailOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "JhoneB@hotmail.com";
            req.SellerEmail = TestData;
            Assert.AreEqual(req.SellerEmail, TestData);
        }
        public void SellerPhoneNumOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "123456789";
            req.SellerPhoneNum = TestData;
            Assert.AreEqual(req.SellerPhoneNum, TestData);
        }
        public void SellerAddressOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "47 Mount Road";
            req.SellerAddress = TestData;
            Assert.AreEqual(req.SellerAddress, TestData);
        }
        public void NumberPlateOk()
        {
            clsRequest req = new clsRequest();
            String TestData = "ABCD 1234";
            req.NumberPlate = TestData;
            Assert.AreEqual(req.NumberPlate, TestData);
        }
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
        public void DateOfRequestOk()
        {
            clsRequest req = new clsRequest();
            DateTime TestData = DateTime.Now.Date;
            req.DateOfRequest = TestData;
            Assert.AreEqual(req.DateOfRequest, TestData);
        }
        public void RequestOk()
        {
            clsRequest req = new clsRequest();
            Boolean TestData = true;
            req.Request = TestData;
            Assert.AreEqual(req.Request, TestData);
        }

        public void PurchasedOk()
        {
            clsRequest req = new clsRequest();
            Boolean TestData = true;
            req.Purchased = TestData;
            Assert.AreEqual(req.Purchased, TestData);
        }

        public void DateOfPurchasedOk()
        {
            clsRequest req = new clsRequest();
            DateTime TestData = DateTime.Now.Date;
            req.DateOfPurchased = TestData;
            Assert.AreEqual(req.DateOfPurchased, TestData);
        }
    }
}
