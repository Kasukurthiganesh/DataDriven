using E2E_POM_Framework.Utilities;
using OpenQA.Selenium;
using Selenium.Community.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2E_POM_Framework.PageObjects
{
    public class LoginPage :Base
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver) 
        {
          this.driver=  driver;
            PageFactory.InitElements(driver, this);
        }

    }
}
