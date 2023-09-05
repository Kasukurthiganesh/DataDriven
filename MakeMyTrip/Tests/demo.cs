using AngleSharp.Dom;
using MakeMyTrip.Action_Driver;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTrip.Tests
{
    public class demo
    {
        public void set() {
            RemoteWebDriver driverremote;
            IWebDriver driver;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized"); // Start the browser maximized
            options.AddArgument("--disable-extensions"); // Disable browser extensions
            options.AddArgument("--disable-popup-blocking"); // Disable popup blocking
            options.AddArgument("--disable-infobars"); // Disable info bars
            options.AddArgument("--incognito"); // Start in incognito mode
              // driverremote = new RemoteWebDriver(new Url("https://14.0.0145/wb/hub"), options);
            driver = new ChromeDriver(options);
            // WebDriver
            driver.Url = "";
            String url= driver.Url;
            String title=driver.Title;
            Console.WriteLine("the url of the page and title"+url + title);
            Console.WriteLine($"the url of the page and title {url} {title}");
            driver.FindElement(By.Id("email"));
            IList<IWebElement> listofelements = driver.FindElements(By.XPath(""));
           String pagesouce= driver.PageSource;
            //Windows
            driver.Manage().Window.Maximize();
            driver.Manage().Window.Minimize();
            driver.Manage().Window.Size = new System.Drawing.Size(800, 600);
            driver.Manage().Window.FullScreen();
            //Navigator
            driver.Navigate().Back();
            driver.Navigate().Refresh();
            driver.Navigate().Forward();
            driver.Navigate().GoToUrl(new Uri(""));
            driver.Navigate().GoToUrl("directlypass the url in string format");
            //options
            var cookies=driver.Manage().Cookies.AllCookies;
            var coockie =driver.Manage().Cookies.GetCookieNamed("Name");
            driver.Manage().Cookies.DeleteCookie(coockie);
            driver.Manage().Cookies.DeleteCookieNamed("Name");
            driver.Manage().Cookies.DeleteAllCookies();
            //timesout
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5); //set
            var time= driver.Manage().Timeouts().ImplicitWait; //get
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromMilliseconds(5000);//set
            var pageloadtime= driver.Manage().Timeouts().PageLoad;//get
            //targetlocators
            driver.SwitchTo().Frame(0);
            driver.SwitchTo().Frame("Name");
            IWebElement element= driver.FindElement(By.XPath("//tagname[@attribute='value']"));
            driver.SwitchTo().Frame(element);
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Window("WindowName");
            //   driver.SwitchTo().NewWindow(WindowType "");
            // once after switch to frame if u want exit present frame to Default by defaultcontent method
            driver.SwitchTo().DefaultContent();
           IWebElement activelemnt= driver.SwitchTo().ActiveElement();
            activelemnt.SendKeys("username"+ Keys.Tab + "password"+ Keys.Enter);
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Alert().Dismiss();
            driver.SwitchTo().Alert().SendKeys("Send the value or text into the textbox");
            driver.SwitchTo().Alert().Accept();
            // ----------------------       ------------------
            //IWebElements methods
            IWebElement element1=driver.FindElement(By.XPath(""));
            String taganame=element1.TagName;
            element1.GetCssValue(taganame);
            var size=element1.Size;
            var loc= element1.Location;
            String Text = element1.Text;
            Boolean falseortrue = element1.Enabled;
            Boolean selected = element1.Selected;
            Boolean displayed = element1.Displayed;
            element1.Clear();
            element1.SendKeys(Keys.Enter);
            element1.Submit();
            element1.Click();
            element1.GetAttribute("TagName");
            element1.GetDomAttribute("propertyName");
            element1.GetCssValue("propertyName");
            element1.GetShadowRoot();
            driver.Quit();
            driver.Close();
            Actions ac = new Actions(driver);
            ac.Click(element1).Perform();
            ac.MoveToElement(element1).Click();// movetoelement
            ac.DragAndDrop(element1, element).Perform();// dragnddrop
            ac.ContextClick().Perform();// right click
            ac.SendKeys(element1+"valuetosend"+Keys.Enter);// send keys
            ac.SendKeys(element1, "valuetosend").Perform();
            IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
            js.ExecuteScript("Arrugment[0].click();", element);// click on element
            js.ExecuteScript("Arrugment[0].scrollInttoView(true)", element1);// scrolintoelement
            js.ExecuteScript("Arrugment[0].");
            js.ExecuteScript("window.scrollBy(0, 400);");// scrool to page
            ac.KeyDown(element, Keys.Shift).SendKeys("selenium").KeyUp(Keys.Shift).Perform();
            ac.ClickAndHold(element).MoveByOffset(50, 0).Release().Perform();
            ac.ClickAndHold(element).Release().Perform();
            ac.Pause(TimeSpan.FromSeconds(2)).Perform();
            /*   DesiredCapabilities capabilities = new DesiredCapabilities(String browser,String version)
               capabilities.SetCapability(CapabilityType.BrowserName, browser);
               capabilities.SetCapability(CapabilityType.Version, version);
               capabilities.SetCapability(FirefoxDriverOptions.Capability, options.ToCapabilities());*/
             
               IWebElement activelemnt = driver.SwitchTo().ActiveElement();
                activelemnt.SendKeys("username" + Keys.Tab + "password" + Keys.Enter);


        }
    }
}
