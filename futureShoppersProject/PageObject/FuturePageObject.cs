using futureShoppersProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace futureShoppersProject.PageObject
{
    class FuturePageObject
    {
        IWebDriver driver;
        public FuturePageObject()
        {
            driver = Hooks1.driver;
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        IWebElement createAccount => driver.FindElement(By.XPath("//a[@href='http://futureshoppers.com.ng/my-account/']"));
        IWebElement closePopUp => driver.FindElement(By.XPath("//span[@class='icon_close']"));
        IWebElement tickPopup => driver.FindElement(By.XPath("//*[contains(text(), 'Prevent This Pop-up')]"));
        IWebElement emailAddress => driver.FindElement(By.XPath("//*[@id='reg_email']"));
        IWebElement registerButton => driver.FindElement(By.XPath("//button[@name='register']"));
        IWebElement myAccount => driver.FindElement(By.LinkText("My account"));

        public void navigateTo(String Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void IClickOnCreateAccount()
        {
            createAccount.Click();
        }

        public void IClickOnClosePopUP()
        {
            // driver.SwitchTo().Alert();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            tickPopup.Click();
            closePopUp.Click();

        }

        public void IEnterEmailAddress(String Ema)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            emailAddress.SendKeys(Ema+randomInt+"@gmail.com");
            //emailAddress.SendKeys(Ema);

        }

        public void IClickOnRegiterButton()
        {
            registerButton.Click();
        }

        public bool IsMyAccountDisplayed()
        {
            return myAccount.Displayed;
        }

    }

}
