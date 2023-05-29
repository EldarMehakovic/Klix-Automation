using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class VerifyThatLifestylePageIsOpened
    {
        [TestMethod]
        public void VerifyThatLifestylePageIsOpenedTest()
        {
            KlixLifeStyle lifestylePage = new KlixLifeStyle();
            lifestylePage.OpenLifestylePage();
            NUnit.Framework.Assert.IsTrue(lifestylePage.IsLifestylePageOpened("Lifestyle"));
        }
    }
}
