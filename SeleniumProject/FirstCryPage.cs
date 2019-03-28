using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    class FirstCryPage
    {
        //Global Variables
        private String strValue;
        private String strValue1;
        private double intValue;
        private bool boolValue;
        private double actualTotal;
        private double expectedTotal;

        private BaseTest objBaseTest;

        public FirstCryPage(BaseTest objBaseTest)
        {
            this.objBaseTest = objBaseTest;
        }
        //  BaseUtil objBaseUtil = new BaseUtil();

        //Locators
        By titleOfWebsite = By.XPath("//img[@title='Firstcry.com - Online Baby & Kids Store']");
        By lnkBdaysGift = By.XPath("//span[@id='menu11']");
        By imgBuyGiftCertificate = By.XPath("//img[@src='//cdn.fcglcdn.com/brainbees/images/n/giftcertificate.gif']");
        By btnDeny = By.XPath("//button[@id='deny']");
        By btnAdvertiseClose = By.XPath("//span[@class='wewidgeticon we_close icon-large']");
        By btnSignUpClose = By.XPath("//a[@title='Close']//following-sibling::div");
        By iframe1 = By.Id("webpush-bubble");
        By iframe2 = By.Id("webklipper-publisher-widget-container-notification-frame");

        By btnAdvertiseClose1 = By.XPath("//div[@id='webklipper-publisher-widget-container-notification-close-div']");
        By inpRecepicienistName = By.Id("txtRecepientName");
        By inpEmail = By.Id("txtEmailId");
        By inpTextArea = By.XPath("//textarea[@id='txtMessage']");
        By inpFromName = By.XPath("//input[@id='txtGiftFrom']");
        By drpSelectAmount = By.XPath("//select[@class='select def_val']");
        By btnGiftNow = By.XPath("//input[@value='GIFT NOW']");
        By lblContinueShopping = By.XPath("//span[text()='Continue Shopping']");
        By lblBrand = By.XPath("//a[text()='Karmallys']");
        By lblProductNames =
                By.XPath("//div[@id='maindiv']//a[contains(@title,'Karmallys ') ]");
        By lblProductPrice = By.XPath("//div[@class='list_block lft']//span[@class='r1']//a[contains(text(),'Rs.' ) ]");
        By chkTopRated = By.XPath("//a[text()='Top Rated']");
        By lnkMoreDetails = By.XPath("//a[text()='MORE PRODUCT DETAILS']");
        By lblProduct = By.XPath("//div[@class='list_block lft'][8]");
        By lnlQuickView = By.XPath("//div[@class='list_block lft'][8]//following::div[@class='qv_sp sprite_list lft']");
        By iframe3 = By.XPath("//iframe[@id='popupiframe']");
        By btnAddToCart = By.XPath("//div[@onclick='AddProductToCart()']");
        By btnIncreaseQuantity = By.XPath("//div[@class='p_number lft']//following-sibling::div");
        By lblPrice = By.XPath("//div[@class='crs_p lft cw']//span[@class='lft']");
        By totalAmount = By.XPath("//div[@class='crs_h5 lft']//span[@class='lft']");
        By btnPlaceOrder = By.XPath("//div[text()='PLACE ORDER ']");
        By inpEmailAddress = By.Id("BillEmailAddress");
        By btnContinue = By.XPath("//button[@id='btnlogin']");
        By inpUserName = By.XPath("//input[@id='ShipFirstName']");
        By inpAddressLine1 = By.XPath("//input[@id='AddressLine1']");
        By inpAddressLine2 = By.XPath("//input[@id='AddressLine2']");
        By inpPincode = By.XPath("//input[@id='ShipPinCode']");
        By inpMobile = By.XPath("//input[@id='ShipMobileNo']");
        By btnUseThisAddress = By.XPath("//input[@id='btnSubmitAdd']");
        By btnAddGiftWrap = By.XPath("//div[@onclick='GiftWrapClick()']");
        By inpGiftFrom = By.XPath("//input[@id='GiftFrom']");
        By textAreaGift = By.XPath("//textArea[@id='GiftMsg']");
        By btnSave = By.XPath("//input[@value='SAVE']");
        By btnAddGiftWrap1 = By.XPath("//div[@class='fc_ckot_sp btnla btnld']");
        By btnGoToFinal = By.XPath("//input[@id='fpay']");
        By drpBank = By.XPath("//select[@id='drpNetBank']");
        By btnPayNow = By.XPath("//input[@id='BtnNetBankPayNow']");
        By imgBankPage = By.XPath("//img[@src='/wps/AxisSMRetailLogin/new/images/AxisLogoText.png']");
        By inpGiftTo = By.XPath("//input[@id='GiftTo']");
        By btnNetBanking = By.XPath("//p[@id='pymentbtn1']");
        By rbPrevious = By.XPath("//input[@id='radSimilarOrder2']");
        By btnSubmit = By.XPath("//input[@id='btnSimilarOrder']");

        public void verifyFirstCryPageDisplayed()
        {
            objBaseTest.getObjUtilities().logReporter("Website Open Successfully",
            objBaseTest.getObjBaseUtil().isDisplayed(titleOfWebsite));
        }

        public void clickOnDenyButton()
        {

            if (objBaseTest.getObjBaseUtil().isDisplayed(btnDeny))
            {
                objBaseTest.getObjBaseUtil().switchToFrame(iframe1);
                objBaseTest.getObjUtilities().logReporter("Click on Alert Deny Button",
                    objBaseTest.getObjBaseUtil().click(btnDeny));
                objBaseTest.getObjBaseUtil().switchToDefaultContent();
            }
        }

        public void clickOnSignUpCloseButton()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Close button of Sign Up page",
                objBaseTest.getObjBaseUtil().click(btnSignUpClose));
        }
        public void hoverOnBdayAndGifts()
        {
            objBaseTest.getObjUtilities().logReporter("Mouse over on Bday Gift",
                objBaseTest.objBaseutil.moveToElement(lnkBdaysGift));
        }

        public void clickOnBuyGiftCertification()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Buy birthday gift Certificate",
                objBaseTest.getObjBaseUtil().click(imgBuyGiftCertificate));
        }
        public void setReceptionistName()
        {
            objBaseTest.getObjUtilities().logReporter("Set name into recepitient's textBox",
                objBaseTest.getObjBaseUtil().setText(inpRecepicienistName, "Snehalk"));
        }

        public void setEmailId()
        {
            objBaseTest.getObjUtilities().logReporter("Set emeil Id textBox",
                objBaseTest.getObjBaseUtil().setText(inpEmail, "Snehal@gmail.com"));
        }

        public void setMsg()
        {
            objBaseTest.getObjUtilities().logReporter("Set message into textBox",
            objBaseTest.getObjBaseUtil().setText(inpTextArea,
            "This is gift from dad to you"));
        }

        public void setGiftFrom()
        {
            objBaseTest.getObjUtilities().logReporter("Set name into from textBox",
            objBaseTest.getObjBaseUtil().setText(inpFromName,
            "Dad"));
        }

        public void selectAmount()
        {
            objBaseTest.getObjUtilities().logReporter("Select price from dropdown",
                objBaseTest.getObjBaseUtil().selectOptionFromDropDown(drpSelectAmount, "Text", "Rs.1000"));
        }

        public void clickOnGiftNowButton()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Gift Now button",
               objBaseTest.getObjBaseUtil().click(btnGiftNow));

        }

        public void clickOnContinueShoppingButton()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Continue Shopping button",
               objBaseTest.getObjBaseUtil().click(lblContinueShopping));
        }

        public void clickOnSecondBrand()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Brand button",
            objBaseTest.getObjBaseUtil().click(lblBrand));
        }

        public void writeProductNameAndPrice()
        {
            objBaseTest.getObjBaseUtil().listOfElements(lblProductNames, "Product");
            objBaseTest.getObjBaseUtil().listOfElements(lblProductPrice, "Price");
            objBaseTest.getObjUtilities().logReporter("Write product Names And prices into text file",
                objBaseTest.getObjBaseUtil().writeDataToFile());
        }

        public void sortByTopRated()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Top Rated",
            objBaseTest.getObjBaseUtil().click(chkTopRated));
        }

        public void clickOnQuickView()
        {
            objBaseTest.getObjBaseUtil().ScrollToView(lblProduct);
            objBaseTest.getObjBaseUtil().moveToElement(lblProduct);
            objBaseTest.getObjUtilities().logReporter("Click on Quick View",
                objBaseTest.getObjBaseUtil().click(lnlQuickView));

        }

        public void clickOnMoreDetails()
        {
            objBaseTest.getObjBaseUtil().switchToFrame(iframe3);
            objBaseTest.getObjUtilities().logReporter("Click on More Details",
                objBaseTest.getObjBaseUtil().clickByJavascriptExecutor(lnkMoreDetails));
            objBaseTest.getObjBaseUtil().switchToDefaultContent();
        }


        public void clickOnAddToCart()
        {
            objBaseTest.getObjBaseUtil().windowHandle("Karmallys Paper Cups Pack of 20 Smiley Face Print Blue Online in India, Buy at Best Price from Firstcry.com - 910322");
            objBaseTest.getObjUtilities().logReporter("Click on Add to Cart",
               objBaseTest.getObjBaseUtil().click(btnAddToCart));
        }

        public void validateTotalAmount()
        {
            strValue = objBaseTest.getObjBaseUtil().getText(lblPrice, "Text", "");
            objBaseTest.getObjBaseUtil().clickOnElementMultipleTimes(btnIncreaseQuantity);
            strValue1 = objBaseTest.getObjBaseUtil().getText(totalAmount, "Text", "");
            intValue = Double.Parse(strValue);
            expectedTotal = objBaseTest.getObjBaseUtil().number * intValue;
            actualTotal = Double.Parse(strValue1);
            if(expectedTotal == actualTotal)
            {
                Console.WriteLine("Total Amount is validate");
            }
        }

        public void clickOnPlaceOrder()
        { 
            objBaseTest.getObjUtilities().logReporter("Click on Place order Button",
               objBaseTest.getObjBaseUtil().click(btnPlaceOrder));
        }

        public void setEmailAddress()
        {
            objBaseTest.getObjUtilities().logReporter("set Email Address",
                objBaseTest.getObjBaseUtil().setText(inpEmailAddress, "Sneghal@gmail.com"));  
        }

        public void clickOnContinue()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Continue Button",
            objBaseTest.getObjBaseUtil().click(btnContinue));
        }

        public void setName()
        {
            objBaseTest.getObjUtilities().logReporter("set Name",
               objBaseTest.getObjBaseUtil().setText(inpUserName, "Sneghal"));
        }

        public void setFlatNumber()
        {
            objBaseTest.getObjUtilities().logReporter("set Flat Number",
               objBaseTest.getObjBaseUtil().setText(inpAddressLine1, "House No.31"));
        }

        public void setColony()
        {
            objBaseTest.getObjUtilities().logReporter("set Colony",
               objBaseTest.getObjBaseUtil().setText(inpAddressLine2, "Karvenagar"));
        }

        public void setPinCode()
        {
            objBaseTest.getObjUtilities().logReporter("set Pin code",
               objBaseTest.getObjBaseUtil().setText(inpPincode, "416113"));
        }

        public void setMobileNumber()
        {
            objBaseTest.getObjUtilities().logReporter("set Mobile Number",
               objBaseTest.getObjBaseUtil().setText(inpMobile, "8976543425"));
        }

        public void clickOnUseThisAddress()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Use this Address",
            objBaseTest.getObjBaseUtil().click(btnUseThisAddress));
        }

        public void clickOnAddGiftWrap()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Add giuft wrap",
            objBaseTest.getObjBaseUtil().click(btnAddGiftWrap));
        }

        public void setTo()
        {
            objBaseTest.getObjUtilities().logReporter("set To for Gift Wrap",
               objBaseTest.getObjBaseUtil().setText(inpGiftTo, "Daughter"));
        }

        public void setFrom()
        {
            objBaseTest.getObjUtilities().logReporter("set from for Gift Wrap",
               objBaseTest.getObjBaseUtil().setText(inpGiftFrom, "Daughter"));
        }

        public void setTextArea()
        {
            objBaseTest.getObjUtilities().logReporter("set Msg for Gift Wrap",
               objBaseTest.getObjBaseUtil().setText(textAreaGift, "Daughter"));
        }

        public void clickOnSave()
        {
            objBaseTest.getObjUtilities().logReporter("Click on Save",
            objBaseTest.getObjBaseUtil().click(btnSave));
        }

        public void clickOnGoToFinalPayment()
        {
            objBaseTest.getObjBaseUtil().ScrollToView(btnGoToFinal);
            objBaseTest.getObjUtilities().logReporter("Click on FinalPayment",
            objBaseTest.getObjBaseUtil().click(btnGoToFinal));
        }

        public void selectNetBanking()
        {
            objBaseTest.getObjUtilities().logReporter("Click on NetBanking",
           objBaseTest.getObjBaseUtil().click(btnNetBanking));
        }

        public void selectBankFromDropDown()
        {
            objBaseTest.getObjUtilities().logReporter("Select Bank From list",
           objBaseTest.getObjBaseUtil().selectOptionFromDropDown(drpBank, "Text", "Axis Bank"));
        }

        public void clickOnPayNow()
        {
            //objBaseTest.getObjBaseUtil().ScrollToView(btnGoToFinal);
            objBaseTest.getObjUtilities().logReporter("Click on Pay Now",
            objBaseTest.getObjBaseUtil().click(btnPayNow));
        }

        public void bankPageVerification()
        {
            objBaseTest.getObjBaseUtil().explicitWaitByThread(6000);
            objBaseTest.getObjUtilities().logReporter("Bank page is Validate",
                objBaseTest.getObjBaseUtil().isDisplayed(imgBankPage));
        }
    }
}
