using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using NUnit.Framework;

namespace ClassLibrary1.CodeBindings
{
    [Binding]
    public class Edit_Record_AdminSteps
    {
        IWebDriver driver;
        [Given(@"That I am on the edgewords websites")]
        public void GivenThatIAmOnTheEdgewordsWebsites()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.edgewordstraining.co.uk/webdriver2";
        }
        
        [Given(@"I have a form to fill out as admin")]
        public void GivenIHaveAFormToFillOutAsAdmin()
        {
            driver.FindElement(By.PartialLinkText("Login")).Click();
            driver.FindElement(By.Id("username")).SendKeys("Edgewords");
            driver.FindElement(By.Id("password")).SendKeys("edgewords123");
            driver.FindElement(By.LinkText("Submit")).Click();
        }
        
        [When(@"I’ll fill out a form with the data, where I want to change")]
        public void WhenILlFillOutAFormWithTheDataWhereIWantToChange()
        {
            driver.FindElement(By.PartialLinkText("Edit Record")).Click();
            driver.FindElement(By.Id("username")).SendKeys("dexter");
            driver.FindElement(By.LinkText("Submit")).Click();
        }
        
        [When(@"I have a form to changes information")]
        public void WhenIHaveAFormToChangesInformation()
        {
            driver.FindElement(By.Id("name")).Clear();
            driver.FindElement(By.Id("name")).SendKeys("Ivan");
            driver.FindElement(By.Id("house")).Clear();
            driver.FindElement(By.Id("house")).SendKeys("12");
            driver.FindElement(By.Id("adl1")).Clear();
            driver.FindElement(By.Id("adl1")).SendKeys("Politechnika");
            driver.FindElement(By.Id("town")).Clear();
            driver.FindElement(By.Id("town")).SendKeys("Warszawa");
            driver.FindElement(By.Id("county")).Clear();
            driver.FindElement(By.Id("county")).SendKeys("Poland");
            driver.FindElement(By.Id("postcode")).Clear();
            driver.FindElement(By.Id("postcode")).SendKeys("WF1 5DG");
            driver.FindElement(By.Id("password")).SendKeys("2a");
            driver.FindElement(By.LinkText("Submit")).Click();
        }
        
        [Then(@"The result should be on the screen with alert information, that record was edited")]
        public void ThenTheResultShouldBeOnTheScreenWithAlertInformationThatRecordWasEdited()
        {
            Assert.That(driver.FindElement(By.LinkText("Add Record")).Displayed);
            driver.Close();
        }
    }
}
