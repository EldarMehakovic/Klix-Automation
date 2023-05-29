using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class VerifyThatSportPageIsOpened
    {
        [TestMethod]
        public void VerifyThatSportPageIsOpenedTest()
        {
            KlixSport sportPage = new KlixSport();
            sportPage.OpenSportPage();
            NUnit.Framework.Assert.IsTrue(sportPage.IsSportPageOpened("Sport"));
        }
    }
}
