using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumKlix2.Page
{
    public class KlixBiznis
    {
        public string biznisUrl;
        IWebDriver driver;

        #region Selectors

        private const string BIZNIS_PLACEHOLDER_ID = "breadcrumb";

        #endregion

        #region Constructor

        public KlixBiznis() 
        {
            biznisUrl = "https://klix.ba/biznis";
            driver = new ChromeDriver();
        }

        #endregion

        #region Methods

        public void OpenBiznisPage() 
        {
            driver.Navigate().GoToUrl(biznisUrl);
        }

        public bool IsBiznisPageOpened(string contentToVerify) 
        {
            string content = driver.FindElement(By.Id(BIZNIS_PLACEHOLDER_ID)).Text;
            return content.Contains(contentToVerify);
        }

        #endregion
    }
}
