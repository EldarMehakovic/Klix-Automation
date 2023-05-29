using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class VerifyThatHomePageIsOpened
    {
        [TestMethod]
        public void VerifyThatHomePageIsOpenedTest()
        {
            KlixBasePage homePage = new KlixBasePage();
            homePage.OpenWebPage();
            NUnit.Framework.Assert.IsTrue(homePage.IsHomePageOpened());
        }
    }
}
