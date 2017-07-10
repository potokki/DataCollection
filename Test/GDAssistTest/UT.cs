using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDAssist;

namespace GDAssistTest
{
    [TestClass]
    public class UT
    {
        [TestMethod]
        public void SSDTest()
        {
            Gates gd = NewMethod;
            gd.SSS(1);
        }

        private static Gates NewMethod
        {
            get
            {
                return new Gates();
            }
        }
    }
}
