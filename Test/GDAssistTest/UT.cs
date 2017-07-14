using System;
using GDAssist;
using Xunit;

namespace GDAssistTest
{
    public class UT
    {
        [Fact]
        public void SSDTest()
        {
            //PrivateObject po = new PrivateObject(Gates);
            Gates gd = NewMethod;
            gd.SSS(18);
            gd.SSS(2);
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
