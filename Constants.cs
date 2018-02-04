using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WMReply
{
    public class Constants
    {

        public static readonly By ACTIVE_XPATH = By.XPath("//*[@id='filters']/li[3]/a");
        public const string ServiceH1Tag = "//*[@id='container']/section/header/h1";
        public const string LatextNewsText = "//h2[@class='block-header__heading' and text()='Latest news']";
        public const string ServiceLink = "//*[@id='navigationMenuWrapper']/div/ul/li[3]/a";
        public const string AboutLink = "//*[@id='navigationMenuWrapper']/div/ul/li[1]/a";
        public const string WorkLink = "//*[@id='navigationMenuWrapper']/div/ul/li[2]/a";
        public const string AboutH1Tag = "//*[@id='container']/div[1]/h1";
        public const string WorkH1Tag = "//*[@id='container']/header/h1";
        public const string ContactLink = "//*[@id='contacticon']/div/div/div[1]/i";
        public const string Offices = "//*[@id='contactbox']/div/div[1]/ul/li[1]";



    }
    
}
