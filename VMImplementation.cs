using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WMReply
{
    public class VMImplementation
    {
        IWebDriver driver = new ChromeDriver();
        //IWebDriver driver = new InternetExplorerDriver();
        //IWebDriver driver = new FirefoxDriver();
        List<string> lst = new List<string>();
        List<string> active = new List<string>();
        public void NavigateToUrl()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["vm.url"]);
            driver.Manage().Window.Maximize();
        }
        public bool LatestNewTest()
        {
            bool latestNewsShows = false;
            var latestNew = driver.FindElement(By.XPath(Constants.LatextNewsText));

            //check if latest news is displayed
            if (latestNew.Displayed)
                latestNewsShows = true;
            return latestNewsShows;
        }
        public string ServicesTest()
        {
            WaitForElementToBeVisible(By.XPath(Constants.ServiceLink), TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath(Constants.ServiceLink)).Click();
           
            //wait for element visibilty
            WaitForElementToBeVisible(By.XPath(Constants.ServiceH1Tag), TimeSpan.FromSeconds(10));
            var ServiceText = driver.FindElement(By.XPath(Constants.ServiceH1Tag));

            return ServiceText.Text;
        }
        public string Work()
        {
           
            WaitForElementToBeVisible(By.XPath(Constants.WorkLink), TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath(Constants.WorkLink)).Click();
           
            //wait for element visibilty
            WaitForElementToBeVisible(By.XPath(Constants.WorkH1Tag), TimeSpan.FromSeconds(10));
            var ServiceText = driver.FindElement(By.XPath(Constants.WorkH1Tag));

            return ServiceText.Text;
        }

        public string About()
        {
            bool serviceDisplayed = false;
            WaitForElementToBeVisible(By.XPath(Constants.AboutLink), TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath(Constants.AboutLink)).Click();
            
            //wait for element visibilty
            WaitForElementToBeVisible(By.XPath(Constants.AboutH1Tag), TimeSpan.FromSeconds(10));
            var ServiceText = driver.FindElement(By.XPath(Constants.AboutH1Tag));
            return ServiceText.Text;
        }
        public int ContactTest()
        {
            WaitForElementToBeVisible(By.XPath(Constants.ContactLink), TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath(Constants.ContactLink)).Click();
            var elements = driver.FindElements(By.XPath(Constants.Offices));
            int numBer = 0;
            var total = elements.Count();
            numBer = total;
            return numBer;
            //Assert.AreEqual(total, "39");

        }
        internal void Click(By identifier)
        {
            driver.FindElement(identifier).Click();
        }
        internal void Clear(By identifier)
        {
            driver.FindElement(identifier).Clear();
        }
        internal void ClearAndSendKeys(By identifier, string text, int? waitingTime = null)
        {
            driver.FindElement(identifier).Clear();
            driver.FindElement(identifier).SendKeys(text);
            if (waitingTime != null)
            {
                Thread.Sleep(Convert.ToInt16(waitingTime));
            }
            driver.FindElement(identifier).SendKeys(Keys.Enter);
        }
        internal bool WaitForElementToBeVisible(By identifier, TimeSpan timeout)
        {
            bool elementVisible = false;

            try
            {

                WebDriverWait wait = new WebDriverWait(driver, timeout);
                wait.Until(ExpectedConditions.ElementExists(identifier));
                wait.Until(ExpectedConditions.ElementIsVisible(identifier));

                elementVisible = true;
            }
            catch
            {
                Console.WriteLine(elementVisible);
            }
            return elementVisible;
        }
        internal IWebElement GetElement(By identifier)
        {
            IWebElement element = driver.FindElement(identifier);
            return element;
        }
        internal string GetElementText(By identifier)
        {
            string text = driver.FindElement(identifier).Text;
            return text;
        }
        public void close()
        {
            driver.Close();
        }
    }
}
