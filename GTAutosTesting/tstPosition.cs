using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstPosition
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Creates new instance of the Position class
            clsPosition aPosition = new clsPosition();

            // Test to validate if the new instance is created
            Assert.IsNotNull(aPosition);

        }
    }
}
