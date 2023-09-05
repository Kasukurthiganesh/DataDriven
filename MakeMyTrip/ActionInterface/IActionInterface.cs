using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTrip.ActionInterface
{
    public interface IActionInterface
    {
        //Added all user actions abstract methods to achieve Abstraction 
        public void ScrollByVisibilityOfElement(IWebDriver driver, IWebElement ele);
        public void HighLighterMethod(IWebDriver driver, IWebElement ele);
        public void Click(IWebDriver driver, IWebElement ele);
        public bool IsElementDisplayed(IWebDriver driver, IWebElement ele);
        public bool FindElement(IWebDriver driver, IWebElement ele);
        public bool IsElementSelected(IWebDriver driver, IWebElement ele);
        public bool IsElementEnabled(IWebDriver driver, IWebElement ele);
        public bool Type(IWebElement ele, String text);
        // public bool SelectBySendkeys(String value, IWebElement ele);
        public bool SelectByIndex(IWebElement element, int index);
        public bool SelectByValue(IWebElement element, String value);
        public bool SelectByText(IWebElement ele, String Text);
        public bool MouseHoverByJavaScript(IWebElement locator);
        public bool SwitchToFrameById(IWebDriver driver, String idValue);
        public bool SwitchToFrameByName(IWebDriver driver, String nameValue);
        public bool SwitchToDefaultFrame(IWebDriver driver);
        public void MouseOverElement(IWebDriver driver, IWebElement element);
        public bool MoveToElement(IWebDriver driver, IWebElement ele);
        public bool Mouseover(IWebDriver driver, IWebElement ele);
        public bool Draggable(IWebDriver driver, IWebElement source, int x, int y);
        public bool DragandDrop(IWebDriver driver, IWebElement source, IWebElement target);
        public bool Slider(IWebDriver driver, IWebElement ele, int x, int y);
        public bool Rightclick(IWebDriver driver, IWebElement ele);
        public bool JSClick(IWebDriver driver, IWebElement ele);
        public void GetAllImagesOnWebPage(IWebElement img);
        public int GetColumncount(IWebElement row);
        public int GetRowCount(IWebElement table);
        public bool Alert(IWebDriver driver);
        public bool LaunchUrl(IWebDriver driver, String url);
        public bool IsAlertPresent(IWebDriver driver);
        public String GetCurrentURL(IWebDriver driver);
        public String GetTitle(IWebDriver driver);
        public bool Click1(IWebElement locator, String locatorName);
        public void FluentWait(IWebDriver driver, IWebElement element, int timeOut);
        public void ImplicitWait(IWebDriver driver, int timeOut);
        public void ExplicitWait_Text(IWebDriver driver, IWebElement element, int timeOut, string text);
        public void ExplicitWait(IWebDriver driver, IWebElement element, int timeOut);
        public void PageLoadTimeOut(IWebDriver driver, int timeOut);
        public string ScreenShot(IWebDriver driver, String filename);
        public string GetCurrentTime();
        public void ScrollUpAndDown(IWebDriver driver, int x, int y);
        public void GetText(IWebElement ele);
        public void IterateListOfElementGetText(IList<IWebElement> ele);
        public void IterateElementbyText(IList<IWebElement> ele, string text);
    }
}
