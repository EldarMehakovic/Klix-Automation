using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class VerifyThatVijestiPageIsOpened
    {
        [TestMethod]
        public void VerifyThatVijestiPageIsOpenedTest()
        {
            KlixVijesti vijestiPage = new KlixVijesti();
            vijestiPage.OpenVijestiPage();
            NUnit.Framework.Assert.IsTrue(vijestiPage.IsVijestiPageOpened("Vijesti"));
        }
    }
}
