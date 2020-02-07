using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class customerAddressTest
    {
        [TestMethod]
        public void InstanceOK()
        {
            //new instance of class
            customerAddress anAddress = new customerAddress();
            //test to see if it exists
            Assert.IsNotNull(anAddress);
        }
    }
}
