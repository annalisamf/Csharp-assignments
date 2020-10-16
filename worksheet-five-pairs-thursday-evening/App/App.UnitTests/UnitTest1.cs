using Microsoft.VisualStudio.TestTools.UnitTesting;
using static App.Program;

namespace App.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEncipher()
        {   
            Assert.AreEqual(Encipher("a", 1), "b");
            Assert.AreEqual(Encipher("hello",1),"ifmmp");
        }

        [TestMethod]
        public void TestDecipher()
        {
            Assert.AreEqual(Decipher("b"),"a");
        }
    }
}