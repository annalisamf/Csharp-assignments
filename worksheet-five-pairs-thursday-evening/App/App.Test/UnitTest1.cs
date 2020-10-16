using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEncipher()
        {
            Assert.Equals(Program.Encipher("a", 1), "b");
        }
    }
}