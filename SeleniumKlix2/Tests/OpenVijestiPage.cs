using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class OpenVijestiPage
    {
        [TestMethod]
        public void OpenVijestiPageTest() 
        {
            KlixBasePage homePage = new KlixBasePage();
            homePage.OpenWebPage();
            homePage.NavigateToVijesti();
        }
    }
}
