using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Data;
using OpenQA.Selenium.DevTools.V108.Browser;

namespace MakeMyTrip.Utilities
{
    [TestFixture("Chrome")]
    [TestFixture("firefox")]
    [TestFixture("IE")]
    [TestFixture("safari")]
    public class Base
    {
        public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        // public IWebDriver driver;
        //dotnet test pathto.csproj (All Test)
        //dotnet test pathto.csproj --filter  TestCategory=Smoke1
        public ExtentReports extent;
        public ExtentTest test;
        private String Browser;
        public String b_browser;

        public Base(String browser)
        {
            this.Browser = browser;
            b_browser = Browser;
        }
        [SetUp]
        public void Setup()
        {
            //Initialize the driver

            string browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(b_browser);
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Value.Manage().Window.Maximize();
            driver.Value.Manage().Cookies.DeleteAllCookies();
            driver.Value.Url = "https://www.makemytrip.com/";
            // Set up Extent Reports
            var htmlReporter = new ExtentHtmlReporter(@"C:\reports\testreport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

        }
        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    //  new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver.Value = new ChromeDriver();
                    break;
                case "Firefox":
                    //   new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver.Value = new FirefoxDriver();
                    break;
                case "Edgebrowser":
                    //   new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver.Value = new EdgeDriver();
                    break;
            }
        }

        public IWebDriver getDriver()
        {
            return driver.Value;
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Value.Quit();
            // Flush the Extent Reports
            extent.Flush();
        }
        public static JsonReader getDataParser()
        {
            return new JsonReader();
        }
        public string TakeScreenshot(string screenshotName)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            String TimeStamp = DateTime.Now.ToString("yyyyMMddSSmm");
            String localDirectory = TestContext.CurrentContext.TestDirectory;
            var screenshotPath = $"{localDirectory}/Screenshots/{screenshotName}_{TimeStamp}.png";
            screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

            return screenshotPath;
        }
        public void takescreenshot()
        {
            IWebDriver driver = new ChromeDriver();
            Screenshot Screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            String ScreenshotName = "Screenshot1";
            String timestamp = DateTime.Now.ToString("yyyyMMddHHss");
            String screenshotFileName = $"{ScreenshotName}{timestamp}.png";
            Screenshot.SaveAsFile(screenshotFileName, ScreenshotImageFormat.Png);
        } 
       
    }
}