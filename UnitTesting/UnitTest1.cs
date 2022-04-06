using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectChocobo;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsDatabase.getUsers();
        }
    }
}
