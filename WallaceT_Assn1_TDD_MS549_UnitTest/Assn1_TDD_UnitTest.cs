using Microsoft.VisualStudio.TestTools.UnitTesting;
using WallaceT_Assn1_TDD_MS549;
using System.Collections;
using System.Collections.Generic;
using System;

namespace WallaceT_Assn1_TDD_MS549_UnitTest
{
    [TestClass]
    public class Assn1_TDD_UnitTest
    {
        private const int ciORArraySize = 5;

        [TestMethod]
        public void Test_ArrayManager_Construct_Standard()
        {
            ArrayManager AMObj = new ArrayManager();
        }

        [TestMethod]
        public void Test_ArrayManager_OpenArrayTest()
        {
            ArrayManager AMObj = new ArrayManager();
            Assert.AreEqual(AMObj.isPredefinedSize, false); 
        }

        [TestMethod]
        public void Test_ArrayManager_Construct_Override()
        {
            ArrayManager AMObj = new ArrayManager(ciORArraySize);
        }

        [TestMethod]
        public void Test_ArrayManager_PredefinedArrayTest()
        {
            ArrayManager AMObj = new ArrayManager(ciORArraySize);
            Assert.AreEqual(AMObj.isPredefinedSize, true);
        }

    }
}
