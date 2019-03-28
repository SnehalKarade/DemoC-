using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class ClearTripPage
    {
        //Global Variables
        private String strValue;
        private int intValue;
        private bool boolValue;
        public BaseTest objBaseTest;

        //Costructor
        public ClearTripPage(BaseTest objBaseTest)
        {
            this.objBaseTest = objBaseTest;
        }

        //Locators

        By flightButton = By.XPath("//a[text() ='Flights']");
        By radioButton = By.XPath("//input[@id='RoundTrip']");
        By fromDate = By.XPath("//input[@id='DepartDate']");
        By toDate = By.XPath("//input[@id='ReturnDate']");
        By fromLocation = By.XPath("//input[@id='FromTag']");
        By locationList = By.XPath("//ul[@id='ui-id-1']//a");
        By locationList1 = By.XPath("//ul[@id='ui-id-2']//a");
        By toLocation = By.XPath("//input[@id='ToTag']");
        By dropDownAdult = By.XPath("//select[@id='Adults']");
        By searchButton = By.XPath("//input[@id='SearchBtn']");
        By nonStopOption = By.XPath("//label[@for='1_1_0']");
        By departFlight = By.XPath("//th[@class='vendor']//img[@title='IndiGo' or @title='SpiceJet']");
        By returnFlight = By.XPath("//div[@class='colZero leg col12 last']//th[@class='vendor']//img[@title='Jet Airways' or @title= 'GoAir']");
        By lstIndigoFlights = By.XPath("//span[text()='IndiGo ']");
        By lstSpiceJetFlight = By.XPath("//span[text()='SpiceJet ']");
        By lstJetAirwaysFlights = By.XPath("//div[@class='colZero leg col12 last']//span[text()='Jet Airways ']");
        By lstGoAirFlights = By.XPath("//div[@class='colZero leg col12 last']//span[text()='GoAir ']");
        By btnBook = By.XPath("//div[@id='ResultContainer_1_1']//button[text()='Book']");
        By btnContinueBooking = By.XPath("//input[@id='itineraryBtn']");
        By chkAcceptTerms = By.XPath("//input[@name='insuranceConfirm']");
        By chkInsurance = By.XPath("//input[@id='insurance_box']");
        By inpEmailAddress = By.XPath("//input[@id='username']");
        By btnContinue = By.XPath("//input[@id='LoginContinueBtn_1']");
        By drpAdult1 = By.XPath("//select[@id='AdultTitle1']");
        By drpAdult2 = By.XPath("//select[@id='AdultTitle2']");
        By inpFirstName = By.XPath("//input[@id='AdultFname1']");
        By inpLastName = By.XPath("//input[@id='AdultLname1']");
        By inpFirstName1 = By.XPath("//input[@id='AdultFname2']");
        By inpLastName1 = By.XPath("//input[@id='AdultLname2']");
        By inpMobileNumber = By.XPath("//input[@id='mobileNumber']");
        By btnContinue1 = By.XPath("//input[@id='travellerBtn']");
        By lnkNetBanking = By.XPath("//a[text()='Net Banking']");
        By rbKotakBank = By.XPath("//input[@id='kotak_bank']");
        By btnPayment = By.XPath("//input[@id='paymentSubmit']");
        By imgKotak = By.XPath("//img[@title='Kotak']");
            

        public void clickOnFlightButton() {
            objBaseTest.getObjUtilities().logReporter("Click on Flight Button", 
                objBaseTest.getObjBaseUtil().click(flightButton));
        }

        public void selectRoundTrip() {
            objBaseTest.getObjUtilities().logReporter("Click on Round Trip Button", 
                objBaseTest.getObjBaseUtil().click(radioButton));
        }

        public void setFromAirport()
        {
            String location = "Mumbai, IN - Chatrapati Shivaji Airport (BOM)";
            objBaseTest.getObjBaseUtil().setText(fromLocation, "Mumbai");
            objBaseTest.getObjUtilities().logReporter("Select From location from list", "Mumbai",
                objBaseTest.getObjBaseUtil().autoSelect(location, locationList));

        }

        public void setToAirport()
        {
            String location = "New Delhi, IN - Indira Gandhi Airport (DEL)";
            objBaseTest.getObjBaseUtil().setText(toLocation, "Delhi");
            objBaseTest.getObjUtilities().logReporter("Select To location from list", "Delhi",
                objBaseTest.getObjBaseUtil().autoSelect(location, locationList1));

        }

        public void selectDepartDate() {
            objBaseTest.getObjBaseUtil().click(fromDate);

            objBaseTest.getObjUtilities().logReporter("select Depart date from Calender ",
                 objBaseTest.getObjBaseUtil().selectDate("24/03/2019"));
        }

        public void selectReturnDate()
        {
            objBaseTest.getObjBaseUtil().explicitWaitByThread(5000);
            objBaseTest.getObjBaseUtil().click(toDate);
            objBaseTest.getObjUtilities().logReporter("select Return date from Calender",
                 objBaseTest.getObjBaseUtil().selectDate("25/03/2019"));
        }

        public void selectOptionFromAdultDropDown()
        {
            objBaseTest.getObjUtilities().logReporter("Select option from Dropdown",
                objBaseTest.getObjBaseUtil().selectOptionFromDropDown(dropDownAdult,"Text", "2"));
        }

        public void clickOnSearchFlight()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Search flight",
                 objBaseTest.getObjBaseUtil().click(searchButton));
        }

        public void clickOnNonStop()
        {
            objBaseTest.getObjBaseUtil().explicitWaitByThread(5000);
           
            objBaseTest.getObjUtilities().logReporter("Click on Non stop",
                 objBaseTest.getObjBaseUtil().click(nonStopOption));
        }

        public void selectDepartFlight()
        {
            string title = objBaseTest.getObjBaseUtil().getText(departFlight, "GetAttribute", "title");
            if (title.Equals("IndiGo"))
            {
                objBaseTest.getObjUtilities().logReporter("Slect "+title+" from depart flight list",
                     objBaseTest.getObjBaseUtil().slectSpecificElementFromList(lstIndigoFlights, 1));
            }
            if(title.Equals("SpiceJet"))
            {
                objBaseTest.getObjUtilities().logReporter("Slect " + title + " from depart flight list",
                objBaseTest.getObjBaseUtil().slectSpecificElementFromList(lstSpiceJetFlight, 1));
            }
        }
        
        public void selectReturnFlight()
        {
            string title = objBaseTest.getObjBaseUtil().getText(returnFlight, "GetAttribute", "title");
            if (title.Equals("Jet Airways"))
            {
                objBaseTest.getObjUtilities().logReporter("Slect " + title + " from return flight list",
              objBaseTest.getObjBaseUtil().slectSpecificElementFromList(lstJetAirwaysFlights, 1));
            }
            if (title.Equals("GoAir"))
            {
                objBaseTest.getObjUtilities().logReporter("Slect " + title + " from return flight list",
                objBaseTest.getObjBaseUtil().slectSpecificElementFromList(lstGoAirFlights, 1));
            }
        }

        public void clickBookButton()
        {
           // objBaseTest.getObjBaseUtil().ScrollToView(btnBook);
            objBaseTest.getObjUtilities().logReporter("Click on Book Button",
                objBaseTest.getObjBaseUtil().click(btnBook));
    }

        public void uncheckIsuranceCheckBox()
        {
            if (objBaseTest.getObjBaseUtil().isSelected(chkInsurance))
            {
                objBaseTest.getObjBaseUtil().explicitWaitByThread(5000);
                objBaseTest.getObjUtilities().logReporter("Uncheck Insurance CheckBox",
                   objBaseTest.getObjBaseUtil().click(chkInsurance));
            }
        }

        public void checkAcceptTermsCheckBox()
        {
            if (!(objBaseTest.getObjBaseUtil().isSelected(chkAcceptTerms)))
            {
                objBaseTest.getObjUtilities().logReporter("Uncheck Insurance CheckBox",
                   objBaseTest.getObjBaseUtil().click(chkAcceptTerms));
            }
        }

        public void clickOnContinue()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Continue Booking",
                 objBaseTest.getObjBaseUtil().click(btnContinue));
        }

        public void setEmailAddress()
        {
            objBaseTest.getObjBaseUtil().explicitWaitByThread(5000);
            objBaseTest.getObjUtilities().logReporter("Set email Address",
               objBaseTest.getObjBaseUtil().setText(inpEmailAddress,"snehal@gmail.com"));
        }

        public void clickContinueButton()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Continue Button",
                 objBaseTest.getObjBaseUtil().click(btnContinue));
        }

        public void selectTitleForAdult1()
        {
            objBaseTest.getObjBaseUtil().explicitWaitByThread(5000);
            objBaseTest.getObjUtilities().logReporter("Select title from dropDown",
                 objBaseTest.getObjBaseUtil().selectOptionFromDropDown(drpAdult1, "Text", "Ms"));
        }

        public void setFirstNameForAdult1()
        {
            objBaseTest.getObjUtilities().logReporter("Set First Name for Adult1",
               objBaseTest.getObjBaseUtil().setText(inpFirstName, "snehal"));
        }

        public void setLastNameForAdult1()
        {
            objBaseTest.getObjUtilities().logReporter("Set Last Name for Adult1",
               objBaseTest.getObjBaseUtil().setText(inpLastName, "kkhg"));
        }

        public void selectTitleForAdult2()
        {
            objBaseTest.getObjUtilities().logReporter("Select title from dropDown",
                 objBaseTest.getObjBaseUtil().selectOptionFromDropDown(drpAdult2, "Text", "Ms"));
        }


        public void setFirstNameForAdult2()
        {
            objBaseTest.getObjUtilities().logReporter("Set First Name for Adult2",
               objBaseTest.getObjBaseUtil().setText(inpFirstName1, "pooja"));
        }

        public void setLastNameForAdult2()
        {
            objBaseTest.getObjUtilities().logReporter("Set Last Name for Adult2",
               objBaseTest.getObjBaseUtil().setText(inpLastName1, "shhhg"));
        }

        public void setMobileNumber()
        {
            objBaseTest.getObjUtilities().logReporter("Set Mobile Number",
               objBaseTest.getObjBaseUtil().setText(inpMobileNumber, "2345678976"));
        }

        public void clickContinueButtonAfterDetails()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Continue Button",
                 objBaseTest.getObjBaseUtil().click(btnContinue1));
        }

        public void selectNetBanking()
        {
            objBaseTest.getObjBaseUtil().explicitWaitByThread(5000);
            objBaseTest.getObjUtilities().logReporter("Net Banking Option is Selected",
                objBaseTest.getObjBaseUtil().click(lnkNetBanking));
        }

        public void selectBank()
        {
            objBaseTest.getObjUtilities().logReporter("Select Kotak Bank",
               objBaseTest.getObjBaseUtil().click(rbKotakBank));

        }

        public void clickMakePayment()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Make Payment Button",
                objBaseTest.getObjBaseUtil().click(btnPayment));
        }

        public void verifyKotakBankPage()
        {
            objBaseTest.getObjBaseUtil().explicitWaitByThread(5000);
            objBaseTest.getObjUtilities().logReporter("Kotak Bank Page displayed",
                objBaseTest.getObjBaseUtil().isDisplayed(imgKotak));

        }
    }

   
         


    }

