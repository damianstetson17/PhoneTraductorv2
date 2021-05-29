using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telefono_App.Controllers;

namespace Telefono_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HiTest()
        {
            CharController testController = new CharController();
            string result = testController.getSecuence("hi");
            string spectedResult = "44 444";
            Assert.AreEqual(spectedResult,result);
        }

        [TestMethod]
        public void YesTest()
        {
            CharController testController = new CharController();
            string result = testController.getSecuence("yes");
            string spectedResult = "999337777";
            Assert.AreEqual(spectedResult,result);
        }

        [TestMethod]
        public void Foo_barTest()
        {
            CharController testController = new CharController();
            string result = testController.getSecuence("foo bar");
            string spectedResult = "333666 666022 2777";
            Assert.AreEqual(spectedResult,result);
        }

        [TestMethod]
        public void HelloWorldTest()
        {
            CharController testController = new CharController();
            string result = testController.getSecuence("hello world");
            string spectedResult = "4433555 555666096667775553";
            Assert.AreEqual(spectedResult,result);
        }
    }
}
