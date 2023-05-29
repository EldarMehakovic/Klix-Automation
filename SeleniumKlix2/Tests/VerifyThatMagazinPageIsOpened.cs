using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class VerifyThatMagazinPageIsOpened
    {
        [TestMethod]
        public void VerifyThatMagazinPageIsOpenedTest()
        {
            KlixMagazin magazinPage = new KlixMagazin();
            magazinPage.OpenMagazinPage();
            NUnit.Framework.Assert.IsTrue(magazinPage.IsMagazinPageOpened("Magazin"));
        }
    }
}
