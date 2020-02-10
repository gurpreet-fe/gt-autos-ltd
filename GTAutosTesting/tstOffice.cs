using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstOffice
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOffice AnOffice = new clsOffice();
            Assert.IsNotNull(AnOffice);
        }
    }
}
