using Microsoft.VisualStudio.TestTools.UnitTesting;
using WallaceT_Assn1_TDD_MS549;

namespace WallaceT_Assn1_TDD_MS549_UnitTest
{
    [TestClass]
    public class Assn1_TDD_UnitTest
    {
        [TestMethod]
        public void Test_ArrayManager_Construct_Standard()
        {
            ArrayManager AM = new ArrayManager();


        }

        [TestMethod]
        public void Test_ArrayManager_Construct_Override()
        {
            ArrayManager AM = new ArrayManager(5);

        }


    }
}
