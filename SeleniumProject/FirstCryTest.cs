using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject 
{
    class FirstCryTest : BaseTest
    {

        FirstCryPage objFirstCryPage;

        public void initializeEnvironmrnt()
        {
            objFirstCryPage = new FirstCryPage(this);
        }

        [SetUp]
        public void initializeEnvironment()
        {
            this.initializeEnvironment("https://www.firstcry.com/", 120);
            this.initializeEnvironmrnt();
        }

        [Test]
        public void firstCryTest()
        {
            objFirstCryPage.verifyFirstCryPageDisplayed();
            objFirstCryPage.clickOnDenyButton();
            objFirstCryPage.clickOnSignUpCloseButton();
            objFirstCryPage.hoverOnBdayAndGifts();
            objFirstCryPage.clickOnBuyGiftCertification();
            objFirstCryPage.setReceptionistName();
            objFirstCryPage.setEmailId();
            objFirstCryPage.setMsg();
            objFirstCryPage.setGiftFrom();
            objFirstCryPage.selectAmount();
            objFirstCryPage.clickOnGiftNowButton();
            objFirstCryPage.clickOnContinueShoppingButton();
            objFirstCryPage.hoverOnBdayAndGifts();
            objFirstCryPage.clickOnSecondBrand();
            objFirstCryPage.writeProductNameAndPrice();
            objFirstCryPage.sortByTopRated();
            objFirstCryPage.clickOnQuickView();
            objFirstCryPage.clickOnMoreDetails();
            objFirstCryPage.clickOnAddToCart();
            objFirstCryPage.validateTotalAmount();
            objFirstCryPage.clickOnAddToCart();
           
            
           
            objFirstCryPage.setMobileNumber();
            objFirstCryPage.clickOnUseThisAddress();
            objFirstCryPage.clickOnAddGiftWrap();
            objFirstCryPage.setTo();
            objFirstCryPage.setFrom();
            objFirstCryPage.setTextArea();
            objFirstCryPage.clickOnSave();
            objFirstCryPage.clickOnGoToFinalPayment();
            objFirstCryPage.selectNetBanking();
            objFirstCryPage.selectBankFromDropDown();
            objFirstCryPage.clickOnPayNow();
            objFirstCryPage.bankPageVerification();

        }

        [TearDown]
        public void tearDownEnvironment()
        {

            

        }

    }
}
