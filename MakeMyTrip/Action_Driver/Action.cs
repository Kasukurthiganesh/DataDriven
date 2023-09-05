using MakeMyTrip.ActionInterface;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeMyTrip.Utilities;

namespace MakeMyTrip.Action_Driver { 
   
    public class Action :Base , IActionInterface
    {
        
    public void ScrollByVisibilityOfElement(IWebDriver driver, IWebElement ele)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", ele);

        }
        public void HighLighterMethod(IWebDriver driver, IWebElement ele)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].setAttribute('style','background:yellow; border:2px solid red;');", ele);
        }
        public void Click(IWebDriver driver, IWebElement ele)
        {

            Actions act = new Actions(driver);
            act.MoveToElement(ele).Click().Build().Perform();

        }
        public bool FindElement(IWebDriver driver, IWebElement ele)
        {
            bool flag = false;
            try
            {
                bool status = ele.Displayed;
                flag = true;
            }
            catch (Exception e)
            {
                // System.out.println("Location not found: "+locatorName);
                flag = false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Successfully Found element ");

                }
                else
                {
                    Console.WriteLine("Unable to locate element");
                }
            }
            return flag;
        }
        public bool IsElementEnabled(IWebDriver driver, IWebElement ele)
        {
            bool isButtonEnabled = FindElement(driver, ele);
            if (isButtonEnabled)
            {
                isButtonEnabled = ele.Displayed;
                if (isButtonEnabled)
                {
                    Console.WriteLine("The element is Enabled");
                }
                else
                {
                    Console.WriteLine("The element is not Enabled");
                }
            }
            else
            {
                Console.WriteLine("Not Enabled ");
            }
            return isButtonEnabled;
        }
        public bool IsElementDisplayed(IWebDriver driver, IWebElement ele)
        {
            bool IsElementDisplayed = FindElement(driver, ele);
            if (IsElementDisplayed)
            {
                IsElementDisplayed = ele.Displayed;
                if (IsElementDisplayed)
                {
                    Console.WriteLine("The element is Displayed");
                }
                else
                {
                    Console.WriteLine("The element is not Displayed");
                }
            }
            else
            {
                Console.WriteLine("Not displayed ");
            }
            return IsElementDisplayed;
        }
        public bool IsElementSelected(IWebDriver driver, IWebElement ele)
        {
            bool IsElementSelected = FindElement(driver, ele);
            if (IsElementSelected)
            {
                IsElementSelected = ele.Selected;
                if (IsElementSelected)
                {
                    Console.WriteLine("The element is Selected");
                }
                else
                {
                    Console.WriteLine("The element is not Selected");
                }
            }
            else
            {
                Console.WriteLine("Not Selected ");
            }
            return IsElementSelected;
        }
        public bool Type(IWebElement ele, string text)
        {
            bool flag = false;
            try
            {
                flag = ele.Displayed;
                ele.Clear();
                ele.SendKeys(text);

                flag = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Location Not found");
                Console.WriteLine(e.StackTrace);
                flag = false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Successfully entered value");
                }
                else
                {
                    Console.WriteLine("Unable to enter value");
                }

            }
            return flag;
        }
        public bool SelectByIndex(IWebElement element, int index)
        {
            bool flag = false;
            try
            {
                SelectElement s = new SelectElement(element);
                s.SelectByIndex(index);
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Option selected by Index");
                }
                else
                {
                    Console.WriteLine("Option not selected by Index");
                }
            }
        }
        public bool SelectByValue(IWebElement element, String value)
        {
            bool flag = false;
            try
            {
                SelectElement s = new SelectElement(element);
                s.SelectByValue(value);
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Option selected by Index");
                }
                else
                {
                    Console.WriteLine("Option not selected by Index");
                }
            }
        }
        public bool SelectByText(IWebElement element, String Text)
        {
            bool flag = false;
            try
            {
                SelectElement s = new SelectElement(element);
                s.SelectByText(Text);
                flag = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Option selected by Index");
                }
                else
                {
                    Console.WriteLine("Option not selected by Index");
                }
            }
        }
        public bool MouseHoverByJavaScript(IWebElement ele)
        {
            bool flag = false;
            try
            {
                IWebElement mo = ele;
                String javaScript = "var evObj = document.createEvent('MouseEvents');"
                        + "evObj.initMouseEvent(\"mouseover\",true, false, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null);"
                        + "arguments[0].dispatchEvent(evObj);";
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript(javaScript, mo);
                flag = true;
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("MouseOver Action is performed");
                }
                else
                {
                    Console.WriteLine("MouseOver Action is not performed");
                }
            }
        }
        public bool JSClick(IWebDriver driver, IWebElement ele)
        {
            bool flag = false;
            try
            {
                // IWebElement element = driver.findElement(locator);
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", ele);
                // driver.executeAsyncScript("arguments[0].click();", element);

                flag = true;

            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);

            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Click Action is performed");
                }
                else if (!flag)
                {
                    Console.WriteLine("Click Action is not performed");
                }
            }
            return flag;
        }
        public bool SwitchToFrameById(IWebDriver driver, String idValue)
        {
            bool flag = false;
            try
            {
                driver.SwitchTo().Frame(idValue);
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Frame with Id \"" + idValue + "\" is selected");
                }
                else
                {
                    Console.WriteLine("Frame with Id \"" + idValue + "\" is not selected");
                }
            }
        }
        public bool SwitchToFrameByName(IWebDriver driver, String nameValue)
        {
            bool flag = false;
            try
            {
                driver.SwitchTo().Frame(nameValue);
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Frame with Name \"" + nameValue + "\" is selected");
                }
                else if (!flag)
                {
                    Console.WriteLine("Frame with Name \"" + nameValue + "\" is not selected");
                }
            }
        }
        public bool SwitchToDefaultFrame(IWebDriver driver)
        {
            bool flag = false;
            try
            {
                driver.SwitchTo().DefaultContent();
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (flag)
                {
                    // SuccessReport("SelectFrame ","Frame with Name is selected");
                }
                else if (!flag)
                {
                    // failureReport("SelectFrame ","The Frame is not selected");
                }
            }
        }
        public void MouseOverElement(IWebDriver driver, IWebElement element)
        {
            bool flag = false;
            try
            {
                new Actions(driver).MoveToElement(element).Build().Perform();
                flag = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine(" MouserOver Action is performed on ");
                }
                else
                {
                    Console.WriteLine("MouseOver action is not performed on");
                }
            }
        }
        public bool MoveToElement(IWebDriver driver, IWebElement ele)
        {
            bool flag = false;
            try
            {
                // WebElement element = driver.findElement(locator);
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].scrollIntoView(true);", ele);
                Actions actions = new Actions(driver);
                // actions.moveToElement(driver.findElement(locator)).build().perform();
                actions.MoveToElement(ele).Build().Perform();
                flag = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return flag;
        }
        public bool Mouseover(IWebDriver driver, IWebElement ele)
        {
            bool flag = false;
            try
            {
                new Actions(driver).MoveToElement(ele).Build().Perform();
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                /*
                 * if (flag) {
                 * SuccessReport("MouseOver ","MouserOver Action is performed on \""+locatorName
                 * +"\""); } else {
                 * failureReport("MouseOver","MouseOver action is not performed on \""
                 * +locatorName+"\""); }
                 */
            }
        }
        public bool Draggable(IWebDriver driver, IWebElement source, int x, int y)
        {
            bool flag = false;
            try
            {
                new Actions(driver).DragAndDropToOffset(source, x, y).Build().Perform();
                Thread.Sleep(5000);
                flag = true;
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Draggable Action is performed on \"" + source + "\"");
                }
                else if (!flag)
                {
                    Console.WriteLine("Draggable action is not performed on \"" + source + "\"");
                }
            }
        }
        public bool DragandDrop(IWebDriver driver, IWebElement source, IWebElement target)
        {
            bool flag = false;
            try
            {
                new Actions(driver).DragAndDrop(source, target).Perform();
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("DragAndDrop Action is performed");
                }
                else if (!flag)
                {
                    Console.WriteLine("DragAndDrop Action is not performed");
                }
            }
        }
        public bool Slider(IWebDriver driver, IWebElement ele, int x, int y)
        {
            bool flag = false;
            try
            {
                // new Actions(driver).dragAndDropBy(dragitem, 400, 1).build()
                // .perform();
                new Actions(driver).DragAndDropToOffset(ele, x, y).Build().Perform();// 150,0
                Thread.Sleep(5000);
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Slider Action is performed");
                }
                else
                {
                    Console.WriteLine("Slider Action is not performed");
                }
            }
        }
        public bool Rightclick(IWebDriver driver, IWebElement ele)
        {
            bool flag = false;
            try
            {
                Actions clicker = new Actions(driver);
                clicker.ContextClick(ele).Perform();
                flag = true;
                return true;
                // driver.findElement(by1).sendKeys(Keys.DOWN);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("RightClick Action is performed");
                }
                else
                {
                    Console.WriteLine("RightClick Action is not performed");
                }
            }
        }
        //public bool SwitchWindowByTitle(IWebDriver driver, String windowTitle, int count)
        //    {
        //        bool flag = false;
        //        try
        //        {
        //            ISet<string> windowList = driver.WindowHandles;

        //            String[] array = windowList.ToArray(new String[0]);

        //            driver.SwitchTo().Window(array[count - 1]);

        //            if (driver.Title.Contains(windowTitle))
        //            {
        //                flag = true;
        //            }
        //            else
        //            {
        //                flag = false;
        //            }
        //            return flag;
        //        }
        //        catch (Exception e)
        //        {
        //            // flag = true;
        //            return false;
        //        }
        //        finally
        //        {
        //            if (flag)
        //            {
        //                Console.WriteLine("Navigated to the window with title");
        //            }
        //            else
        //            {
        //                Console.WriteLine("The Window with title is not Selected");
        //            }
        //        }
        //    }
        // public bool switchToNewWindow(IWebDriver driver)
        //{
        //    bool flag = false;
        //    try
        //    {

        //        Set<String> s = driver.getWindowHandles();
        //        Object popup[] = s.toArray();
        //        driver.switchTo().window(popup[1].toString());
        //        flag = true;
        //        return flag;
        //    }
        //    catch (Exception e)
        //    {
        //        flag = false;
        //        return flag;
        //    }
        //    finally
        //    {
        //        if (flag)
        //        {
        //            Console.WriteLine("Window is Navigated with title");
        //        }
        //        else
        //        {
        //            Console.WriteLine("The Window with title: is not Selected");
        //        }
        //    }
        //}

        //public bool switchToOldWindow(IWebDriver driver)
        //{
        //    bool flag = false;
        //    try
        //    {

        //        Set<String> s = driver.getWindowHandles();
        //        Object popup[] = s.toArray();
        //        driver.switchTo().window(popup[0].toString());
        //        flag = true;
        //        return flag;
        //    }
        //    catch (Exception e)
        //    {
        //        flag = false;
        //        return flag;
        //    }
        //    finally
        //    {
        //        if (flag)
        //        {
        //            System.out.println("Focus navigated to the window with title");
        //        }
        //        else
        //        {
        //            System.out.println("The Window with title: is not Selected");
        //        }
        //    }
        //}
        public int GetColumncount(IWebElement row)
        {
            IList<IWebElement> columns = row.FindElements(By.TagName("tg"));
            int a = columns.Count();
            Console.WriteLine(columns.Count());
            foreach (IWebElement column in columns)
            {
                Console.WriteLine(column.Text);
                Console.WriteLine("|");
            }
            return a;
        }
        public void GetAllImagesOnWebPage(IWebElement img)
        {
            IList<IWebElement> images = img.FindElements(By.TagName("img"));
            foreach (IWebElement image in images)
            {
                Console.WriteLine(image.GetAttribute("src"));
                Console.WriteLine("|");
            }
        }
        public int GetRowCount(IWebElement table)
        {
            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));
            int a = rows.Count() - 1;
            return a;
        }
        public bool Alert(IWebDriver driver)
        {
            bool presentFlag = false;
            IAlert? alert = null;

            try
            {
                // Check the presence of alert
                alert = driver.SwitchTo().Alert();
                // if present consume the alert
                alert.Accept();
                presentFlag = true;
            }
            catch (NoAlertPresentException ex)
            {
                // Alert present; set the flag

                // Alert not present
                Console.WriteLine(ex.Message);

            }
            finally
            {
                if (!presentFlag)
                {
                    Console.WriteLine("The Alert is handled successfully");
                }
                else
                {
                    Console.WriteLine("There was no alert to handle");
                }
            }

            return presentFlag;
        }
        public bool LaunchUrl(IWebDriver driver, String url)
        {
            bool flag = false;
            try
            {
                driver.Navigate().GoToUrl(url);
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Successfully launched " + url + " ");
                }
                else
                {
                    Console.WriteLine("Failed to launch " + url + " ");
                }
            }
        }
        public bool IsAlertPresent(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            } // try
            catch (NoAlertPresentException e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            } // catch
        }
        public String GetTitle(IWebDriver driver)
        {
            bool flag = false;

            String text = driver.Title;
            if (flag)
            {
                Console.WriteLine("Title of the page is: " + text + " ");
            }
            return text;
        }
        public String GetCurrentURL(IWebDriver driver)
        {
            bool flag = false;

            String text = driver.Url;
            if (flag)
            {
                Console.WriteLine("Current URL is: " + text + " ");
            }
            return text;
        }
        public bool Click1(IWebElement locator, String locatorName)
        {
            bool flag = false;
            try
            {
                locator.Click();
                flag = true;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                if (flag)
                {
                    Console.WriteLine("Able to click on " + locatorName + " ");
                }
                else
                {
                    Console.WriteLine("Click Unable to click on " + locatorName + " ");
                }
            }

        }
        public void ExplicitWait(IWebDriver driver, IWebElement element, int timeOut)
        {
            IWait<IWebDriver> wait = null;
            try
            {

                WebDriverWait waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By)element));
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains("Text(Expected String"));
                //  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((By)element));

                element.Click();
            }
            catch (Exception e)
            {
            }
        }
        public void ExplicitWait_Text(IWebDriver driver, IWebElement element, int timeOut, string text)
        {
            IWait<IWebDriver> wait = null;
            try
            {

                WebDriverWait waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By)element));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains(text));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((By)element));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                    .TextToBePresentInElementLocated((By)element, text));
                element.Click();
            }
            catch (Exception e)
            {
            }
        }
        public void FluentWait(IWebDriver driver, IWebElement element, int timeOut)
        {
            IWait<IWebDriver> wait = null;
            try
            {

                //      wait = new IWait<IWebDriver>((IWebDriver)driver).withTimeout(Duration.ofSeconds(20))
                //                 .pollingEvery(Duration.ofSeconds(2)).ignoring(Exception.class);
                //wait.until(ExpectedConditions.visibilityOf(element));
                //element.click();
                var waitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut))
                    .PollingInterval = TimeSpan.FromMilliseconds(500);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By)element));
                element.Click();
                //ExpectedConditions.TitleContains
                //"ExpectedConditions.ElementIsVisible" to wait for element to become visible or
                //"ExpectedConditions.TitleContains" to wait for the page title to contain a specific string
                //ElementToBeClickable,TextToBePresentInElementLocated
            }

            catch (Exception e)
            {

            }
        }
        public void ImplicitWait(IWebDriver driver, int timeOut)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeOut);
        }
        public void PageLoadTimeOut(IWebDriver driver, int timeOut)
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeOut);
        }
        public String ScreenShot(IWebDriver driver, String filename)
        {
            DateTime time = DateTime.Now;
            String screenshottime = filename + time.ToString("dd-MM-yyyy hh:mm:ss");
            //new DateTime("yyyy-MM-dd-hh-mm").format(new Date());
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            takesScreenshot.GetScreenshot().SaveAsFile(screenshottime + ".png", ScreenshotImageFormat.Png);
            return screenshottime;
            //  String destination = System.getProperty("user.dir") + "ScreenShots" + filename + "_" + dateName + ".png";
            //try
            //{
            //    FileUtils.copyFile(source, new File(destination));
            //}
            //catch (Exception e)
            //{
            //   Console.WriteLine(e.StackTrace);
            // }
            // This new path for jenkins
            //String newImageString = "" + filename
            //        + "_" + dateName + ".png";
            //return newImageString;
            //
        }
        public String GetCurrentTime()
        {
            DateTime time = DateTime.Now;
            String screenshottime = time.ToString("dd-MM-yyyy hh:mm:ss");
            return screenshottime;
        }
        public void ScrollUpAndDown(IWebDriver driver, int x, int y)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy('" + x + "','" + y + "')", "");
        }
        public void GetText(IWebElement ele)
        {
             Console.WriteLine(ele.Text);
        }
        public void IterateElementbyText(IList<IWebElement> ele ,string text)
        {
            for (int i = 0; i < ele.Count; i++)
            {
                string textoutput = ele[i].Text;
                if (textoutput == text)
                {
                    ele[i].Click();
                }
            }
        }
        public void IterateListOfElementGetText(IList<IWebElement> ele)
        {
            foreach (IWebElement listmenu in ele)
            {
                Console.WriteLine("Total list of Elements are" + " " + ele.Count);
                for (int i = 0; i < ele.Count; i++)
                {
                    HighLighterMethod(driver.Value, ele[i]);
                    IsElementEnabled(driver.Value, listmenu);
                    string text = ele[i].Text;
                    Console.WriteLine(text);
                }
                break;
            }
        }
    }
}
