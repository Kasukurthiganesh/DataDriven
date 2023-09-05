using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_learning
{
    public class Tests
    {
        IWebDriver driver;
       [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver= new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);//implicitwait wait only for 5sec only
            WebDriverWait wait=new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
            //    .TextToBePresentInElement(driver.FindElement(By.XPath("")), "Textvalue"));


        }

        [Test]
        public void Test()
        {
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            String title = driver.Title;
            
            TestContext.Progress.WriteLine(title);
            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("learning");
            IWebElement dropdown = driver.FindElement(By.XPath("//select[@class='form-control']"));
            SelectElement s = new SelectElement(dropdown);
            s.SelectByIndex(2);   
            driver.FindElement(By.XPath("//input[@id='terms']")).Click();
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(5000);
            String title1= driver.Title;
            Console.WriteLine(title1);

        }
        [Test]
        public void Test1()
        {
            string radioTitle = "Radio Button Example";
            string classexmaple = "Suggession Class Example";
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            string radioDescription =
            driver.FindElement(By.XPath("//legend[contains(text(),'Radio Button Example')]")).Text;
            Console.WriteLine(radioDescription);
            Assert.AreEqual(radioTitle, radioDescription);
            driver.FindElement(By.XPath("//input[@value='radio1']")).Click();
            driver.FindElement(By.XPath("//input[@value='radio2']")).Click();
            driver.FindElement(By.XPath("//input[@value='radio3']")).Click();
            //
          //string ClassExamp = driver.FindElement(By.XPath("//legend[contains(text(),'Suggession Class Example')]]")).Text;
          //  Console.WriteLine(ClassExamp);
          //  Assert.AreEqual(classexmaple, ClassExamp);
            driver.FindElement(By.XPath("//input[@id='autocomplete']")).Clear();
            driver.FindElement(By.XPath("//input[@id='autocomplete']")).SendKeys("India");
            // 
            IWebElement dropdown1= driver.FindElement(By.XPath("//select[@id='dropdown-class-example']"));
            SelectElement s = new SelectElement(dropdown1);
            s.SelectByText("Option3");
            Thread.Sleep(5000);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}