using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class OpenMagazinPage
    {
        [TestMethod]
        public void OpenMagazinPageTest() 
        {
            KlixBasePage homePage = new KlixBasePage();
            homePage.OpenWebPage();
            homePage.NavigateToMagazin();
        }
    }
}
