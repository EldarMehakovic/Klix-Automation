using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumKlix2.Page
{
    class KlixSport
    {
        public string sportUrl;
        IWebDriver driver;

        #region Selectors

        private const string SPORT_PLACEHOLDER_ID = "breadcrumb";

        #endregion

        #region Constructor

        public KlixSport()
        {
            sportUrl = "https://klix.ba/sport";
            driver = new ChromeDriver();
        }

        #endregion

        #region Methods

        public void OpenSportPage()
        {
            driver.Navigate().GoToUrl(sportUrl);
        }

        public bool IsSportPageOpened(string contentToVerify)
        {
            string content = driver.FindElement(By.Id(SPORT_PLACEHOLDER_ID)).Text;
            return content.Contains(contentToVerify);
        }

        #endregion
    }
}

