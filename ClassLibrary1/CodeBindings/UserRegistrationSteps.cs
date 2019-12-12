using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using NUnit.Framework;

namespace ClassLibrary1.CodeBindings
{
    [Binding]
    public class UserRegistrationSteps
    {
        IWebDriver driver;
        [Given(@"That I am on registration form")]
        public void GivenThatIAmOnRegistrationForm()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.edgewordstraining.co.uk/webdriver2";
        }
        
        [When(@"I login as an user")]
        public void WhenILoginAsAnUser()
        {
            driver.FindElement(By.PartialLinkText("Login")).Click();
            driver.FindElement(By.PartialLinkText("Register")).Click();
            //driver.FindElement(By.Id("Register").FindElement(By.Id("username")));
            IWebElement parent = driver.FindElement(By.Id("Register"));
            IWebElement child  = parent.FindElement(By.Id("username"));
            child.SendKeys("sqaaa21s");
            driver.FindElement(By.Id("password1")).SendKeys("ivan123");
            driver.FindElement(By.Id("password2")).SendKeys("ivan123");
            driver.FindElement(By.LinkText("Submit")).Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
        
        [Then(@"I see my internet profile")]
        public void ThenISeeMyInternetProfile()
        {
            Assert.That(driver.FindElement(By.LinkText("Add Record")).Displayed);
            driver.Close();
        }
    }
}
