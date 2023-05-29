using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class VerifyThatBiznisPageIsOpened
    {
        [TestMethod]
        public void VerifyThatBiznisPageIsOpenedTest()
        {
            KlixBiznis biznisPage = new KlixBiznis();
            biznisPage.OpenBiznisPage();
            NUnit.Framework.Assert.IsTrue(biznisPage.IsBiznisPageOpened("Biznis"));
        }
    }
}
