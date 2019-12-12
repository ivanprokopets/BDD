using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using NUnit.Framework;


namespace ClassLibrary1.CodeBindings
{
    [Binding]
    public class Remove_Record_AdminSteps
    {
        IWebDriver driver;
        [Given(@"That I am on the edgewords websites\.")]
        public void GivenThatIAmOnTheEdgewordsWebsites_()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.edgewordstraining.co.uk/webdriver2";
        }
        
        [Given(@"I log in as administrator")]
        public void GivenILogInAsAdministrator()
        {
            driver.FindElement(By.PartialLinkText("Login")).Click();
            driver.FindElement(By.Id("username")).SendKeys("Edgewords");
            driver.FindElement(By.Id("password")).SendKeys("edgewords123");
            driver.FindElement(By.LinkText("Submit")).Click();
        }
        
        [When(@"I will enter the name of the user in the field to remove the record")]
        public void WhenIWillEnterTheNameOfTheUserInTheFieldToRemoveTheRecord()
        {
            driver.FindElement(By.PartialLinkText("Remove Record")).Click();
            driver.FindElement(By.Id("username")).SendKeys("asafswra");
            driver.FindElement(By.LinkText("Submit")).Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
        
        [Then(@"the result will be deleted record from the database")]
        public void ThenTheResultWillBeDeletedRecordFromTheDatabase()
        {
            driver.Close();
        }
    }
}
