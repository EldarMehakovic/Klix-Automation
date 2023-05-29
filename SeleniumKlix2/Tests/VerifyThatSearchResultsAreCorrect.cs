using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumKlix2.Page;

namespace SeleniumKlix2.Tests
{
    [TestClass]
    public class VerifyThatSearchResultsAreCorrect
    {
        [TestMethod]
        public void VerifyThatSearchResultsAreCorrectTest()
        {
            KlixBasePage homePage = new KlixBasePage();
            homePage.OpenWebPage();
            Assert.IsTrue(homePage.IsHomePageOpened(), "Home page was not opened!");
            homePage.OpenSearchBar();
            homePage.PerformSearch("Barcelona");
            Assert.IsTrue(homePage.AreSearchResultsCorrect("Barcelona"), "Search Results are not correct!!");
        }
    }
}
