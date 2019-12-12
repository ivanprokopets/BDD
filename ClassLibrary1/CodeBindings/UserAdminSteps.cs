using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using NUnit.Framework;
using AventStack.ExtentReports.Gherkin.Model;


namespace ClassLibrary1.CodeBindings
{
    [Binding]
    public class UserAdminSteps
    {

        IWebDriver driver;

        [Given(@"That I am on the edgewords web site")] 
        public void GivenThatIAmOnTheEdgewordsWebSite()
        {

            driver = new EdgeDriver();
            driver.Url = "https://www.edgewordstraining.co.uk/webdriver2";

        }
        
        [When(@"I login as an administrator")]
        public void WhenILoginAsAnAdministrator()
        {
                driver.FindElement(By.PartialLinkText("Login")).Click();
                driver.FindElement(By.Id("username")).SendKeys("Edgewords");
                driver.FindElement(By.Id("password")).SendKeys("edgewords123");
                driver.FindElement(By.LinkText("Submit")).Click();
        }
        
        [Then(@"I see the full admin list of options")]
        public void ThenISeeTheFullAdminListOfOptions()
        {
            Assert.That(driver.FindElement(By.LinkText("Add Record")).Displayed);
            driver.Close();
        }

        [Then(@"I am logout of application")]
        public void ThenIAmLogoutOfApplication()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
