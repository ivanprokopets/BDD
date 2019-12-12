using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using NUnit.Framework;

namespace ClassLibrary1.CodeBindings
{
    [Binding]
    public class Add_Record_AdminSteps
    {
        IWebDriver driver;
        [Given(@"That I am on the edgewords website")]
        public void GivenThatIAmOnTheEdgewordsWebsite()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.edgewordstraining.co.uk/webdriver2";
        }
        
        [Given(@"I have a form to fill out")]
        public void GivenIHaveAFormToFillOut()
        {
            driver.FindElement(By.PartialLinkText("Login")).Click();
            driver.FindElement(By.Id("username")).SendKeys("Edgewords");
            driver.FindElement(By.Id("password")).SendKeys("edgewords123");
            driver.FindElement(By.LinkText("Submit")).Click();
        }
        
        [When(@"I press submin")]
        public void WhenIPressSubmin()
        {
            driver.FindElement(By.PartialLinkText("Add Record")).Click();
            driver.FindElement(By.Id("name")).SendKeys("Nfswedrdsl");
            driver.FindElement(By.Id("username")).SendKeys("Nawqseaod");
            driver.FindElement(By.Id("pin")).SendKeys("1234");
            driver.FindElement(By.Id("password")).SendKeys("newRecord1");
            driver.FindElement(By.LinkText("Submit")).Click();
        }
        
        [Then(@"the result should be on the screen with alert information, that record was added")]
        public void ThenTheResultShouldBeOnTheScreenWithAlertInformationThatRecordWasAdded()
        {
            driver.Close();
        }
    }
}
