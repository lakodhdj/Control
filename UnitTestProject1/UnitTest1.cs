using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Control;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGrade5()
        {
            Assert.AreEqual("5", Program.GetGrade(95));
        }

        [TestMethod]
        public void TestGrade4()
        {
            Assert.AreEqual("4", Program.GetGrade(80));
        }

        [TestMethod]
        public void TestGrade3()
        {
            Assert.AreEqual("3", Program.GetGrade(65));
        }

        [TestMethod]
        public void TestGrade2()
        {
            Assert.AreEqual("2", Program.GetGrade(45));
        }

        [TestMethod]
        public void TestGrade1()
        {
            Assert.AreEqual("1", Program.GetGrade(30));
        }
    }
}
