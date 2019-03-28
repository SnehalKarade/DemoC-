using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class BaseUtil : LoadableComponent<BaseUtil>
    {
        public BaseTest objBaseTest;



        public BaseUtil(BaseTest objBaseTest)
        {
            this.objBaseTest = objBaseTest;
        }

        public Actions action;
        public SelectElement select;
        public bool blnFlag;
        public IWebElement element;
        public String text;
        public int size;
        public int number;
        public String[] stringData;
        public String[] stringPrice;
        public String data;





        enum MONTH { January, February, March, April, May, June, July, August, September, October, November, December };




        public IWebElement explicitWebDriverWait(By locator)
        {
            try
            {

                element = objBaseTest.getObjWait().Until(ExpectedConditions.ElementIsVisible(locator));
                return element;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool click(By locator)
        {
            try
            {
                element = this.explicitWebDriverWait(locator);

                element.Click();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool setText(By locator, String text)
        {
            try
            {
                element = this.explicitWebDriverWait(locator);
                element.SendKeys(text);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public String getText(By locator, String textBy, String attributeName)
        {

            try
            {
                if (textBy.Equals("Text"))
                {
                    element = this.explicitWebDriverWait(locator);
                    text = element.Text;
                }

                else if (textBy.Equals("GetAttribute"))
                {
                    element = this.explicitWebDriverWait(locator);
                    text = element.GetAttribute(attributeName);
                }

                else
                {
                    text = null;
                }
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public bool selectOptionFromDropDown(By locator, String selectBy, String option)
        {
            try
            {
                element = objBaseTest.getObjWait().Until(ExpectedConditions.ElementIsVisible(locator));
                select = new SelectElement(element);
                if (selectBy.Equals("Text"))
                {
                    select.SelectByText(option);
                    return true;
                }
                else if (selectBy.Equals("Value"))
                {
                    select.SelectByValue(option);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public bool moveToElement(By locator)
        {
            try
            {
                action = new Actions(objBaseTest.getObjDriver());
                element = objBaseTest.getObjWait().Until(ExpectedConditions.ElementIsVisible(locator));
                action.MoveToElement(element).Perform();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool isDisplayed(By locator)
        {
            try
            {
                element = objBaseTest.getObjWait().Until(ExpectedConditions.ElementIsVisible(locator));
                blnFlag = element.Displayed;
                return blnFlag;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return blnFlag;
            }
        }

        public bool isSelected(By locator)
        {
            try
            {
                element = objBaseTest.getObjWait().Until(ExpectedConditions.ElementIsVisible(locator));
                blnFlag = element.Selected;
                return blnFlag;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return blnFlag;
            }
        }

        public bool autoSelect(String option, By locator)
        {
            try
            {
                explicitWaitByThread(10000);
                element = objBaseTest.getObjWait().Until(ExpectedConditions.ElementIsVisible(locator));
                var list = objBaseTest.getObjDriver().FindElements(locator);
                int numberOfElement = list.Count;
                for (int i = 0; i < numberOfElement; i++)
                {
                    if (option.Equals(list.ElementAt(i).Text))
                    {

                        list.ElementAt(i).Click();

                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public void explicitWaitByThread(int seconds)
        {

            Thread.Sleep(seconds);

        }

        public bool slectSpecificElementFromList(By locator, int index)
        {
            try
            {
                var list = objBaseTest.getObjDriver().FindElements(locator);
                element = list.ElementAt(index);
                element.Click();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool selectDate(String strDate)
        {
            try
            {
                By arrowNext = By.XPath("//div[@class='monthBlock last']//a[@class='nextMonth ']");
                By locMonth = By.XPath("//div[@class='monthBlock first']//div[@class='title']");

                DateTime locDate = DateTime.ParseExact(strDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int day = locDate.Day;
                int month = locDate.Month;
                int year = locDate.Year;
                MONTH MonthName = (MONTH)(month - 1);
                String currentMonth = objBaseTest.getObjDriver().FindElement(locMonth).Text;
                while (!currentMonth.Contains(MonthName.ToString()))
                {
                    objBaseTest.getObjDriver().FindElement(arrowNext).Click();
                    Console.WriteLine("Click on next  arrow");
                    break;
                }
                By date = By.XPath("//div[@class='monthBlock first']//div[@class='title']/parent::div/following-sibling::table/tbody/tr/td/a[text()='" + day + "']");
                objBaseTest.getObjDriver().FindElement(date).Click();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public Boolean switchToFrame(By locator)
        {
            try
            {
                element = objBaseTest.getObjWait().Until(ExpectedConditions.ElementIsVisible(locator));
                objBaseTest.getObjDriver().SwitchTo().Frame(element);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public void listOfElements(By locator, String listOf)
        {
            this.explicitWaitByThread(6000);

            var listOfPrioducts = objBaseTest.getObjDriver().FindElements(locator);
            if (listOf.Equals("Product"))
            {
                size = listOfPrioducts.Count;
                stringData = new string[size];
                for (int i = 0; i < 18; i++)
                {
                    data = listOfPrioducts.ElementAt(i).Text;
                    this.explicitWaitByThread(2000);

                    stringData[i] = data;
                }
            }
            if (listOf.Equals("Price"))
            {
                size = listOfPrioducts.Count;
                stringPrice = new string[size];
                for (int i = 0; i < 18; i++)
                {
                    data = listOfPrioducts.ElementAt(i).Text;
                    this.explicitWaitByThread(2000);

                    stringPrice[i] = data;
                }
            }

        }

        public bool writeDataToFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter("D:\\SeleniumTest.txt");
                this.explicitWaitByThread(5000);
                int size = 18;
                for (int i = 0; i < size; i++)
                {

                    if (!stringData[i].Equals("") && !stringPrice.Equals(""))
                    {
                        sw.WriteLine(stringData[i] + ": " + stringPrice[i]);
                    }
                }
                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public void switchToDefaultContent()
        {
            objBaseTest.getObjDriver().SwitchTo().DefaultContent();

        }
        protected override void ExecuteLoad()
        {
            throw new NotImplementedException();
        }

        protected override bool EvaluateLoadedStatus()
        {
            throw new NotImplementedException();
        }

        public void ScrollToView(By Locator)
        {
            IJavaScriptExecutor js = objBaseTest.getObjDriver() as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].scrollIntoView(true)", objBaseTest.getObjDriver().FindElement(Locator));
        }

        public bool clickByJavascriptExecutor(By locator)
        {
            try
            {
                this.explicitWaitByThread(6000);
                element = objBaseTest.getObjDriver().FindElement(locator);
                IJavaScriptExecutor js = (IJavaScriptExecutor)objBaseTest.getObjDriver();
                js.ExecuteScript("arguments[0].click()", element);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;

            }
        }

        public void windowHandle(String newWindow)
        {
            String mainWindow = objBaseTest.getObjDriver().WindowHandles.First();

            var HashSet = objBaseTest.getObjDriver().WindowHandles;
            foreach (string tab in HashSet)
            {
                Task.Delay(2000);
                String title = objBaseTest.getObjDriver().SwitchTo().Window(tab).Title;
                if (newWindow.Equals(objBaseTest.getObjDriver().Title))
                {
                    // Console.WriteLine(title);
                    objBaseTest.getObjDriver().SwitchTo().Window(tab);
                }
                else
                    objBaseTest.getObjDriver().SwitchTo().Window(mainWindow);
            }
        }

        public void clickOnElementMultipleTimes(By locator)
        {
            Random r = new Random();
            number = r.Next(2);
            if (number == 0)
            {
                number++;
            }
            for(int i = 0; i < number; i++)
            {
             element =   objBaseTest.getObjDriver().FindElement(locator);
                element.Click();
                this.explicitWaitByThread(2000);
            }

        }
    }

}