using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void instanceOK()
        {
            clsOrders anOrder = new clsOrders();

            Assert.IsNotNull(anOrder);
        }
    }
}
