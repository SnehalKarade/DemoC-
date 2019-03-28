using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.seleniumeasy.com/test/";
            System.Threading.Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[contains(text(),'Input Forms')]")).Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement element1 = driver.FindElement(By.XPath("//ul[@class='dropdown-menu']//a[text()='Select Dropdown List']"));
            System.Threading.Thread.Sleep(2000);
            element1.Click();
            IWebElement element2 = driver.FindElement(By.XPath("//select[@id='select-demo']"));
            SelectElement ele = new SelectElement(element2);
            ele.DeselectByValue("Monday");
            driver.Quit();

        }

    }
}

