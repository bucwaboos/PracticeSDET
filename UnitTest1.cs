using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V152.DOM;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;


namespace SeleniumNUnitDemo
{
    public class Tests
    {
        //setting up the web driver and ignoring the warning about the driver needing teardown as teardown is provided
        #pragma warning disable NUnit1032
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //setup the driver
            //driver = new ChromeDriver();
            driver = new EdgeDriver();
            //open the driver and make sure the window is always maximized
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            //link to the URL
            driver.Navigate().GoToUrl("https://admlucid.com");
            //checks if the URL is correct
            Assert.That(driver.Url, Is.EqualTo("https://admlucid.com/"));
            //check if the website title is correct
            Assert.That(driver.Title, Is.EqualTo("Home Page - Admlucid"));
            //Assert.Pass();
        }

        // tear down the previously set up tags
        [TearDown]
        //teardown package with driver method and quit
        public void TearDown() 
        {
            driver.Quit();
        }
    }
}
