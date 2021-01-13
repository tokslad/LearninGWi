using futureShoppersProject.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace futureShoppersProject.Stepdefs
{
    [Binding]
    public class FutureShopperSteps
    { FuturePageObject futurePageObject;
        public FutureShopperSteps()
        {
            futurePageObject = new FuturePageObject();
        }


        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string Url)
        {
            futurePageObject.navigateTo(Url);
        }


       
        [When(@"I click on close pop up")]
        public void WhenIClickOnClosePopUp()
        {
            futurePageObject.IClickOnClosePopUP();
            
        }





        [When(@"I click on create Account/Log in")]
        public void WhenIClickOnCreateAccountLogIn()
        {
            futurePageObject.IClickOnCreateAccount();
        }
        
        [When(@"I enter email address ""(.*)""")]
        public void WhenIEnterEmailAddress(string Ema)
        {
            futurePageObject.IClickOnClosePopUP();
            futurePageObject.IEnterEmailAddress(Ema);

        }
        
        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            futurePageObject.IClickOnRegiterButton();
        }

        [Then(@"I should be register with My Account Displayed")]
        public void ThenIShouldBeRegisterWithMyAccountDisplayed()
        {
            Assert.That(futurePageObject.IsMyAccountDisplayed);
        }

    }
}
