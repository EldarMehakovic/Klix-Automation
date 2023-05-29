using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class OpenBiznisPage
    {
        [TestMethod]
        public void OpenBiznisPageTest() 
        {
            KlixBasePage homePage = new KlixBasePage();
            homePage.OpenWebPage();
            homePage.NavigateToBiznis();
        }
    }
}
