using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumKlix2.Page
{
    class KlixMagazin
    {
        public string magazinUrl;
        IWebDriver driver;

        #region Selectors

        private const string MAGAZIN_PLACEHOLDER_ID = "breadcrumb";

        #endregion

        #region Constructor

        public KlixMagazin()
        {
            magazinUrl = "https://klix.ba/magazin";
            driver = new ChromeDriver();
        }

        #endregion

        #region Methods

        public void OpenMagazinPage()
        {
            driver.Navigate().GoToUrl(magazinUrl);
        }

        public bool IsMagazinPageOpened(string contentToVerify)
        {
            string content = driver.FindElement(By.Id(MAGAZIN_PLACEHOLDER_ID)).Text;
            return content.Contains(contentToVerify);
        }

        #endregion
    }
}
