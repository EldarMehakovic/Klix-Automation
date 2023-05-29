using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class OpenLifeStylePage
    {
        [TestMethod]
        public void OpenLifeStylePageTest() 
        {
            KlixBasePage homePage = new KlixBasePage();
            homePage.OpenWebPage();
            homePage.NavigateToLifeStyle();
        }
    }
}
