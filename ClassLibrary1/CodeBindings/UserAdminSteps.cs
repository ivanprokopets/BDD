using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using NUnit.Framework;
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
            //bool titleTextfield = driver.FindElement(By.LinkText("Add Record")).Displayed;
            //Assert.False(titleTextfield, "Title text field present which is not expected");
            Assert.That(driver.FindElement(By.LinkText("Add Record")).Displayed);
            //Assert.Equals("Add Record", driver.FindElement(By.LinkText("Add Record")).Displayed);
            //Assert.assertEquals("Log In – Perficient Wiki ", driver.ge());
            driver.Close();
        }
    }
}
