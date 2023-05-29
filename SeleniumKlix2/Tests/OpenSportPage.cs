using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class OpenSportPage
    {
        [TestMethod]
        public void OpenSportPageTest() 
        {
            KlixBasePage homePage = new KlixBasePage();
            homePage.OpenWebPage();
            homePage.NavigateToSport();
        }
    }
}
