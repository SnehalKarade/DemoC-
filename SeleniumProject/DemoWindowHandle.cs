using NUnit.Framework;
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
    class DemoWindowHandle
    {
        
      IWebDriver driver = new ChromeDriver();

       [SetUp]
       public void initializeEnvironment()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Manage().Window.Maximize();
        }

       [Test]
      public void testForNewTabAndWindow()
        {
            // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.FindElement(By.XPath("//a[text()='Instagram']")).Click();
            Task.Delay(3000);
            windowHandle("Instagram");

            driver.FindElement(By.XPath("//input[@name='emailOrPhone']")).SendKeys("snehal@gmail.com");

            windowHandle("Facebook – log in or sign up");
            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-switch-windows/");

            driver.FindElement(By.XPath("//button[@id='button1']")).Click();
            Task.Delay(3000);
            windowHandle("QA Automation Tools Tutorial");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//span[text()='HOME']")).Click();

            windowHandle("A new title is here");

        }

        public void windowHandle(String newWindow)
        {
            String mainWindow = driver.WindowHandles.First();

            var HashSet = driver.WindowHandles;
            foreach (string tab in HashSet)
            {
                Task.Delay(2000);
                String title = driver.SwitchTo().Window(tab).Title;
                if (newWindow.Equals(driver.Title))
                {
                    // Console.WriteLine(title);
                    driver.SwitchTo().Window(tab);
                }
                else
                    driver.SwitchTo().Window(mainWindow);
            }
        }
       
        [TearDown]
          public void tearDownEnvironment()
            {
                 driver.Quit();

            }

        }
    }

