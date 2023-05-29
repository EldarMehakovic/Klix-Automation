using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumKlix2.Page
{
    public class KlixBasePage
    {

        #region Selectors

        private const string VIJESTI_BUTTON_XPATH = "//*[@id='nav_items']/ul/li[1]/div/a";
        private const string BIZNIS_BUTTON_XPATH = "//*[@id='nav_items']/ul/li[2]/div/a";
        private const string SPORT_BUTTON_XPATH = "//*[@id='nav_items']/ul/li[3]/div/a";
        private const string MAGAZIN_BUTTON_XPATH = "//*[@id='nav_items']/ul/li[4]/div/a";
        private const string LIFESTYLE_BUTTON_XPATH = "//*[@id='nav_items']/ul/li[5]/div/a";
        private const string KLIX_LOGO_XPATH = "//*[@id='logo']";
        private const string SEARCH_BUTTON_ID = "search-open";
        private const string SEARCH_BAR_INPUT_XPATH = "//*[@id='search']/div/input";
        private const string FIRST_SEARCH_RESULT_XPATH = "/html/body/div[3]/div[2]/div[2]/div[1]/div/div/div[1]/article/div[2]/a/h2";

        #endregion

        #region Objects

        string baseUrl;
        IWebDriver driver;

        #endregion

        #region Methods

        public KlixBasePage() 
        {
            baseUrl = "https://klix.ba";
            driver = new ChromeDriver();
        }

        public void OpenWebPage() 
        {
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void NavigateToVijesti() 
        {
            driver.FindElement(By.XPath(VIJESTI_BUTTON_XPATH)).Click();
        }

        public void NavigateToBiznis()
        {
            driver.FindElement(By.XPath(BIZNIS_BUTTON_XPATH)).Click();
        }

        public void NavigateToSport()
        {
            driver.FindElement(By.XPath(SPORT_BUTTON_XPATH)).Click();
        }

        public void NavigateToMagazin()
        {
            driver.FindElement(By.XPath(MAGAZIN_BUTTON_XPATH)).Click();
        }

        public void NavigateToLifeStyle()
        {
            driver.FindElement(By.XPath(LIFESTYLE_BUTTON_XPATH)).Click();
        }

        public bool IsHomePageOpened() 
        {
            try
            {
                return driver.FindElement(By.XPath(KLIX_LOGO_XPATH)).Displayed;
            }

            catch (Exception) 
            {
                return false;
            }
        }

        public void OpenSearchBar() 
        {
            driver.FindElement(By.Id(SEARCH_BUTTON_ID)).Click();
        }

        public void PerformSearch(string contentToSearchFor) 
        {
            driver.FindElement(By.XPath(SEARCH_BAR_INPUT_XPATH)).SendKeys(contentToSearchFor + Keys.Enter);
        }

        public bool AreSearchResultsCorrect(string contentToVerify) 
        {
            string content = driver.FindElement(By.XPath(FIRST_SEARCH_RESULT_XPATH)).Text;
            return content.Contains(contentToVerify);
        }

        #endregion
    }
}
