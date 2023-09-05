using MakeMyTrip.Tests;
using MakeMyTrip.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = MakeMyTrip.Action_Driver.Action;

namespace MakeMyTrip.PageObjects
{
    public class Homepage
    {
        public IWebDriver driver;
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//iframe[@id='webklipper-publisher-widget-container-notification-frame']")]
        private IWebElement popup;
        [FindsBy(How = How.XPath, Using = "//*[@id='SW']/div[1]/div[2]/div/div/nav/ul/li")]
        private IList <IWebElement> _Menu_lIst;
        [FindsBy(How = How.XPath, Using = "//body/div[@id='root']/div[1]/div[2]/div[1]/div[1]/div[1]/ul[1]/li")]
        private IList<IWebElement> _TypeofTrips;
        //    [FindsBy(How = How.XPath, Using = "")]
        //private IWebElement ;
        // [FindsBy(How = How.XPath, Using = "")]
        //private IWebElement ;
        //[FindsBy(How = How.XPath, Using = "")]
        //private IWebElement ;
        //    [FindsBy(How = How.XPath, Using = "")]
        //private IWebElement ;
        //    [FindsBy(How = How.XPath, Using = "")]
        //private IWebElement ;
        //     [FindsBy(How = How.XPath, Using = "")]
        //private IWebElement ;
        //[FindsBy(How = How.XPath, Using = "")]
        //private IWebElement ;
        //    [FindsBy(How = How.XPath, Using = "")]
        //private IWebElement ;
        [FindsBy(How = How.XPath, Using = "//div[@class='wrapper-outer']")]
        private IWebElement iframe;

        Action ac = new Action();

        public LoginPage getpopup()
        {
            popup.Click();
            string parentWindow = driver.CurrentWindowHandle;
            foreach (string windowHandle in driver.WindowHandles) 
            {
                if (windowHandle != parentWindow)
                {
                    driver.SwitchTo().Window(windowHandle);
                    break;
                }
            }
            driver.SwitchTo().Window(parentWindow);
            return new LoginPage(driver);
        }
        public void ListofMenu()
        {
            //foreach(IWebElement listmenu in _Menu_lIst)
            //{
            //    //  ac.GetText(listmenu);
            //    Console.WriteLine("Total Menu activites are" + _Menu_lIst.Count);
            //    for (int i = 0; i < _Menu_lIst.Count; i++)
            //    {
            //        ac.HighLighterMethod(driver, _Menu_lIst[i]);
            //        ac.IsElementEnabled(driver, listmenu);
            //        string text = _Menu_lIst[i].Text;
            //        Console.WriteLine(text);
            //    }
            //    break;
            //}
            ac.IterateListOfElementGetText(_Menu_lIst);
        }
        public void SelectofMenu(string textofmenu)
        { 
            //for (int i = 0; i < _Menu_lIst.Count; i++)
            //{
            //    ac.HighLighterMethod(driver, _Menu_lIst[i]);
            //    string text = _Menu_lIst[i].Text;
            //    if (text == textofmenu)
            //    {
            //        _Menu_lIst[i].Click();
            //    }
            //}
            ac.IterateElementbyText(_Menu_lIst, textofmenu);
        }
        public void TypeOftrips(string textfortrip)
        {
            for (int i = 0; i < _TypeofTrips.Count; i++)
            {
                ac.HighLighterMethod(driver, _TypeofTrips[i]);
                string text = _TypeofTrips[i].Text;
                if (text == textfortrip)
                {
                    _TypeofTrips[i].Click();
                }
            }
        }


    }
}
