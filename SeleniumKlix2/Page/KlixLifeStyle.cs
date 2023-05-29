using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumKlix2.Page
{
    class KlixLifeStyle
    {
        public string lifestyleUrl;
        IWebDriver driver;

        #region Selectors

        private const string LIFESTYLE_PLACEHOLDER_ID = "breadcrumb";

        #endregion

        #region Constructor

        public KlixLifeStyle()
        {
            lifestyleUrl = "https://klix.ba/lifestyle";
            driver = new ChromeDriver();
        }

        #endregion

        #region Methods

        public void OpenLifestylePage()
        {
            driver.Navigate().GoToUrl(lifestyleUrl);
        }

        public bool IsLifestylePageOpened(string contentToVerify)
        {
            string content = driver.FindElement(By.Id(LIFESTYLE_PLACEHOLDER_ID)).Text;
            return content.Contains(contentToVerify);
        }

        #endregion
    }
}
