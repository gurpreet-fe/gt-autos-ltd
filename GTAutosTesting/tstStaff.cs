using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GTAutosTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Creates new instance of the Staff class
            clsStaff staffMember = new clsStaff();

            // Test to validate if the new instance is created
            Assert.IsNotNull(staffMember);
        }
    }
}
