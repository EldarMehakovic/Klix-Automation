using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumKlix2.Page
{
    class KlixVijesti
    {
        public string vijestiUrl;
        IWebDriver driver;

        #region Selectors

        private const string VIJESTI_PLACEHOLDER_ID = "breadcrumb";

        #endregion

        #region Constructor

        public KlixVijesti()
        {
            vijestiUrl = "https://klix.ba/vijesti";
            driver = new ChromeDriver();
        }

        #endregion

        #region Methods

        public void OpenVijestiPage()
        {
            driver.Navigate().GoToUrl(vijestiUrl);
        }

        public bool IsVijestiPageOpened(string contentToVerify)
        {
            string content = driver.FindElement(By.Id(VIJESTI_PLACEHOLDER_ID)).Text;
            return content.Contains(contentToVerify);
        }

        #endregion
    }
}
