using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject 
{
    class ClearTripTest : BaseTest
    {
       
       public ClearTripPage objClearTripPage;

        public void initializeEnvironmrnt() 
        {
            objClearTripPage = new ClearTripPage(this);
        }

         [SetUp]
        public void initializeEnvironment()
        {
            this.initializeEnvironment("https://www.cleartrip.com/",120);
            this.initializeEnvironmrnt();
        }

        [TearDown]
        public void tearDownEnvironment()
        {

           // this.tearDown();
            //objClearTripPage = null;

        }
        [Test]
        public void clearTripTest()
        {
            objClearTripPage.selectRoundTrip();
            objClearTripPage.setFromAirport();
            objClearTripPage.setToAirport();
            objClearTripPage.selectDepartDate();
            objClearTripPage.selectReturnDate();
            objClearTripPage.selectOptionFromAdultDropDown();
            objClearTripPage.clickOnSearchFlight();
            objClearTripPage.clickOnNonStop();
            objClearTripPage.selectDepartFlight();
            objClearTripPage.selectReturnFlight();
            objClearTripPage.clickBookButton();
            objClearTripPage.uncheckIsuranceCheckBox();
          //  objClearTripPage.checkAcceptTermsCheckBox();
            objClearTripPage.clickOnContinue();
            objClearTripPage.setEmailAddress();
            objClearTripPage.clickContinueButton();
            objClearTripPage.selectTitleForAdult1();
            objClearTripPage.setFirstNameForAdult1();
            objClearTripPage.setLastNameForAdult1();
            objClearTripPage.selectTitleForAdult2();
            objClearTripPage.setFirstNameForAdult2();
            objClearTripPage.setLastNameForAdult2();
            objClearTripPage.setMobileNumber();
            objClearTripPage.clickContinueButtonAfterDetails();
            objClearTripPage.selectNetBanking();
            objClearTripPage.selectBank();
            objClearTripPage.verifyKotakBankPage();

        }

    

    }

}

