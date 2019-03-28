using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class BaseTest
    {
        public IWebDriver driver; 
        public BaseUtil objBaseutil;
        public Utilities objUtilities;
        public WebDriverWait wait;


        public void initializeEnvironment(String url,int seconds)
        {
             driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            objBaseutil = new BaseUtil(this);
            objUtilities = new Utilities(this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
           
        }

        public void tearDown()
        {
            getObjDriver().Quit();
        }

        public BaseUtil getObjBaseUtil()
        {
            return objBaseutil;
        }

        public IWebDriver getObjDriver()
        {
            return driver;
        }

        public Utilities getObjUtilities()
        {
            return objUtilities;
        }
        public WebDriverWait getObjWait()
        {
            return wait;
        }
       

    }
}
